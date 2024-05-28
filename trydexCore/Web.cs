namespace trydexCore
{
    public class Web
    {
        public SearchResult[] GetSearchResults()
        {
            return new[]
            {
                new SearchResult
                {
                    Link = "https://example.com",
                    IconUrl = "https://search.exfreedomist.com/images/favicon.ico",
                    SiteName = "Example Site 1",
                    Description = "This is an example site 1."
                },
                new SearchResult
                {
                    Link = "https://example2.com",
                    IconUrl = "icon2.png",
                    SiteName = "Example Site 2",
                    Description = "This is an example site 2."
                }
            };
        }
    }

    public class SearchResult
    {
        public string Link { get; set; }
        public string IconUrl { get; set; }
        public string SiteName { get; set; }
        public string Description { get; set; }
    }
}
