namespace Data.Entity
{
    public class ApiAccess
    {
        public ApiAccess() : base() { }
        public ApiAccess(int id, string apiSlug, string apiHost, string token) : this()
        {
            Id = id;
            ApiSlug = apiSlug;
            ApiHost = apiHost;
            Token = token;
        }
        public int Id { get; set; }
        public string ApiSlug { get; set; }
        public string ApiHost { get; set; }
        public string Token { get; set; }
    }
}
