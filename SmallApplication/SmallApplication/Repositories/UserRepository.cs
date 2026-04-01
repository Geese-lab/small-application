using Dapper;
using Npgsql;
using SmallApplication.Models;

namespace SmallApplication.Repositories;

public class UserRepository
{
    private readonly string _connectionString;

    public UserRepository()
    {
        _connectionString = Environment.GetEnvironmentVariable("DB_CONNECTION");

        if (string.IsNullOrWhiteSpace(_connectionString))
            throw new ArgumentNullException(nameof(_connectionString), "DB_CONNECTION is not set");
    }

    public async Task<IEnumerable<User>> GetUsers()
    {
        using var connection = new NpgsqlConnection(_connectionString);

        var sql = "SELECT id, name, email FROM users";

        return await connection.QueryAsync<User>(sql);
    }
}
