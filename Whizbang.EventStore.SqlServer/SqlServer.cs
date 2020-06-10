namespace Whizbang.Core.Data.FluentSqlClient
{
    public static class SqlServer
    {
        public static IExecutor With(string connectionString)
        {
            return new MsSqlExecutor(connectionString);
        }
    }
}