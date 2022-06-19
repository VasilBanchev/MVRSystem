namespace PresentationLayer
{
    internal class MySQLDataAdapter
    {
        private string selectCommand;
        private string connectionString;

        public MySQLDataAdapter(string selectCommand, string connectionString)
        {
            this.selectCommand = selectCommand;
            this.connectionString = connectionString;
        }
    }
}