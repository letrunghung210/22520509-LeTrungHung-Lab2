using System.Data;

namespace Lab2
{
    internal class SQLiteConnection
    {
        private string v;

        public SQLiteConnection(string v)
        {
            this.v = v;
        }

        public ConnectionState State { get; internal set; }
    }
}