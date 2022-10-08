namespace ZeniStudioWebBlazor.Data
{
    public class SqlCpnfiguration
    {
        public SqlCpnfiguration(string conectionstring) => ConnectionString = conectionstring;
        public string ConnectionString { get; }
    }
}
