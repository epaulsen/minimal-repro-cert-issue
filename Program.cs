// See https://aka.ms/new-console-template for more information


using Npgsql;

Console.WriteLine("Hello, World!");





var connection = new NpgsqlConnection(args[0]);

await connection.OpenAsync();
var command = connection.CreateCommand();
command.CommandText = "SELECT 1";
await command.ExecuteNonQueryAsync();

await connection.CloseAsync();

Console.WriteLine("Success if we got here!");
