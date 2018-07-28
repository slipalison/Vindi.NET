namespace Vindi.NET
{
    public class VindiConfiguration
    {
        public VindiConfiguration(string urlApi, int version, string authorization)
        {
            UrlApi = urlApi;
            Version = version;
            Authorization = authorization;
        }

        public string UrlApi { get; }
        public int Version { get; }
        public string Authorization { get; }
    }
}
