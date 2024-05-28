using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trydex_core
{

    public class SearchResult
    {
        public string Link { get; set; }
        public string IconUrl { get; set; }
        public string SiteName { get; set; }
        public string Description { get; set; }
    }

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
}
