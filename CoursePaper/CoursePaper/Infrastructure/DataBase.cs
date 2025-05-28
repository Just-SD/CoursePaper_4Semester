using CoursePaper.Domain;
using Npgsql;
using NpgsqlTypes;

namespace CoursePaper
{
    internal static class DataBase
    {
        /*
         command.ExecuteScalar() возвращает первый столбец первой строки (когда нужно одно значение)
         command.ExecuteReader() возвращает весь список полученных строк
         */

        private static string connectPath = "Host=localhost;Port=5432;Database=course_paper;Username=postgres;Password=1234";

        private static NpgsqlConnection connection;
        private static NpgsqlConnection selectConnection;
        private static NpgsqlConnection addConnection;

        static DataBase()
        {
            connection = new NpgsqlConnection(connectPath);
            connection.Open();
        }

        public static async Task<string?> GetOnceValueAsync(string sqlRequest)
        {
            await using (var command = new NpgsqlCommand(sqlRequest, connection))
            {
                var result = await command.ExecuteScalarAsync();
                return result?.ToString();
            }
        }

        public static string? GetOnceValue(string sqlRequest)
        {
            using (var command = new NpgsqlCommand(sqlRequest, connection))
            {
                var result = command.ExecuteScalar();
                if (result == null)
                    return null;
                return result.ToString();
            }
        }

        public static async IAsyncEnumerable<string> GetSingleValuesAsync(string sqlRequest)
        {
            await using (var command = new NpgsqlCommand(sqlRequest, connection))
            {
                await using (var reader = await command.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                    {
                        yield return reader.GetString(0);
                    }
                }
            }
        }

        public static async Task<string[]> GetAllNamesFrom(string tableName)
        {
            List<string> names = new List<string>();

            await foreach (var nameBrand in GetSingleValuesAsync($"SELECT name FROM {tableName}"))
                names.Add(nameBrand);

            return [.. names];
        }

        public static void AddCar(string sqlRequest)
        {
            using (var command = new NpgsqlCommand(sqlRequest, connection))
            {
                command.ExecuteNonQuery();
            }
        }

        public static void AddClient(string sqlRequest)
        {
            using (var command = new NpgsqlCommand(sqlRequest, connection))
            {
                command.ExecuteNonQuery();
            }
        }

        public static async Task<int> GetIdToNameAsync(string nameTable, string nameElement)
        {
            var result = await GetOnceValueAsync($"SELECT id FROM {nameTable} WHERE name = '{nameElement}'");

            if (result == null)
                return -1;

            return int.Parse(result);
        }

        public static int GetIdToName(string nameTable, string nameElement)
        {
            var result = GetOnceValue($"SELECT id FROM {nameTable} WHERE name = '{nameElement}'");

            if (result == null)
                return -1;

            return int.Parse(result);
        }

        public static async Task<string?> GetNameToIdAsync(string nameTable, int id)
        {
            string sql = $"SELECT name FROM {nameTable} WHERE id = {id}";
            var result = await GetOnceValueAsync(sql);
            return result;
        }

        public static string? GetNameToId(string nameTable, int id)
        {
            string sql = $"SELECT name FROM {nameTable} WHERE id = {id}";
            var result = GetOnceValue(sql);
            return result;
        }

        public static async IAsyncEnumerable<Car> GetCarsAsync(string sqlRequest)
        {
            selectConnection = new NpgsqlConnection(connectPath);
            await selectConnection.OpenAsync();

            await using (var command = new NpgsqlCommand(sqlRequest, selectConnection))
            {
                using (var reader = await command.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                    {
                        int id = reader.GetInt32(0);
                        int brandId = reader.GetInt32(1);
                        Brand brand = new Brand(brandId, await GetNameToIdAsync("brands", brandId));

                        int modelId = reader.GetInt32(2);
                        Domain.Model model = new Domain.Model(modelId, brand, await GetNameToIdAsync("models", modelId));

                        int releaseYear = reader.GetInt32(3);
                        int enginePower = reader.GetInt32(4);
                        string gearShiftBoxType = reader.GetString(5);
                        string condition = reader.GetString(6);
                        int price = reader.GetInt32(7);

                        int cityId = reader.GetInt32(8);
                        City city = new City(cityId, await GetNameToIdAsync("citys", cityId));

                        bool isRelevant = reader.GetBoolean(9);

                        yield return new Car(brand, model, releaseYear, enginePower,
                            gearShiftBoxType, condition, price, city, isRelevant, id);
                    }
                }
            }

            selectConnection.Close();
        }

        public static IEnumerable<Client> GetAllClients()
        {
            selectConnection = new NpgsqlConnection(connectPath);
            selectConnection.Open();

            using (var command = new NpgsqlCommand("SELECT * FROM clients WHERE is_relevant", selectConnection))
            {
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int id = reader.GetInt32(0);

                        int cityId = reader.GetInt32(1);
                        City city = new City(cityId, GetNameToId("citys", cityId));

                        int brandId = reader.GetInt32(2);
                        Brand brand = new Brand(brandId, GetNameToId("brands", brandId));

                        int modelId = reader.GetInt32(3);
                        Domain.Model model = new Domain.Model(modelId, brand, GetNameToId("models", modelId));

                        var temp = reader.GetFieldValue<NpgsqlRange<int>>(4);
                        NpgsqlRange<int> releaseYearRange = new NpgsqlRange<int>(temp.LowerBound, temp.UpperBound - 1);

                        temp = reader.GetFieldValue<NpgsqlRange<int>>(5);
                        NpgsqlRange<int> enginePowerRange = new NpgsqlRange<int>(temp.LowerBound, temp.UpperBound - 1);

                        string gearShiftBoxType = reader.GetString(6);
                        string condition = reader.GetString(7);

                        temp = reader.GetFieldValue<NpgsqlRange<int>>(8);
                        NpgsqlRange<int> priceRange = new NpgsqlRange<int>(temp.LowerBound, temp.UpperBound - 1);

                        yield return new Client(city, brand, model, releaseYearRange,
                            enginePowerRange, gearShiftBoxType, condition, priceRange, true, id);
                    }
                }
            }
        }

        public static void UnRelevantCar(int id)
        {
            addConnection = new NpgsqlConnection(connectPath);
            addConnection.Open();

            string sqlRequest = $"UPDATE cars SET is_relevant = false WHERE id = {id}";
            var command = new NpgsqlCommand(sqlRequest, addConnection);
            command.ExecuteScalar();

            addConnection.Close();
        }

        public static void UnRelevantClient(int id)
        {
            addConnection = new NpgsqlConnection(connectPath);
            addConnection.Open();

            string sqlRequest = $"UPDATE clients SET is_relevant = false WHERE id = {id}";
            var command = new NpgsqlCommand(sqlRequest, addConnection);
            command.ExecuteScalar();

            addConnection.Close();
        }
    }
}
