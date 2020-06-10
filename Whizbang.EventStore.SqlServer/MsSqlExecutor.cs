using System.Data.SqlClient;

namespace Whizbang.Core.Data.FluentSqlClient
{
    public class MsSqlExecutor : Executor
    {
        public MsSqlExecutor(string connectionString)
            : base(
                () => new SqlConnection(connectionString),
                () => new SqlCommand(),
                (cmd, paramName, value) => ((SqlCommand) cmd).Parameters.AddWithValue(paramName, value))
        {
        }
    }
}