internal class MySqlServerVersion
{
    private Version version;
    private int v1;
    private int v2;
    private int v3;

    public MySqlServerVersion(Version version)
    {
        this.version = version;
    }

    public MySqlServerVersion(int v, Version version)
    {
        this.version = version;
    }

    public MySqlServerVersion(int v, Version version, string connectionString)
    {
        this.version = version;
    }

    public MySqlServerVersion(int v1, int v2, int v3)
    {
        this.v1 = v1;
        this.v2 = v2;
        this.v3 = v3;
    }
}