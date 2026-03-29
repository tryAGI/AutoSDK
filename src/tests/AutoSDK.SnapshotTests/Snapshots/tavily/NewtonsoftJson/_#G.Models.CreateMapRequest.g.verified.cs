//HintName: G.Models.CreateMapRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateMapRequest
    {
        /// <summary>
        /// The root URL to begin the mapping.<br/>
        /// Example: docs.tavily.com
        /// </summary>
        /// <example>docs.tavily.com</example>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// Natural language instructions for the crawler. When specified, the cost increases to 2 API credits per 10 successful pages instead of 1 API credit per 10 pages.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464<br/>
        /// Example: Find all pages about the Python SDK
        /// </summary>
        /// <example>Find all pages about the Python SDK</example>
        [global::Newtonsoft.Json.JsonProperty("instructions")]
        public string? Instructions { get; set; }

        /// <summary>
        /// Max depth of the mapping. Defines how far from the base URL the crawler can explore.<br/>
        /// Default Value: 1
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_depth")]
        public int? MaxDepth { get; set; }

        /// <summary>
        /// Max number of links to follow per level of the tree (i.e., per page).<br/>
        /// Default Value: 20
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_breadth")]
        public int? MaxBreadth { get; set; }

        /// <summary>
        /// Total number of links the crawler will process before stopping.<br/>
        /// Default Value: 50
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("limit")]
        public int? Limit { get; set; }

        /// <summary>
        /// Regex patterns to select only URLs with specific path patterns (e.g., `/docs/.*`, `/api/v1.*`).<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("select_paths")]
        public global::System.Collections.Generic.IList<string>? SelectPaths { get; set; }

        /// <summary>
        /// Regex patterns to select crawling to specific domains or subdomains (e.g., `^docs\.example\.com$`).<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("select_domains")]
        public global::System.Collections.Generic.IList<string>? SelectDomains { get; set; }

        /// <summary>
        /// Regex patterns to exclude URLs with specific path patterns (e.g., `/private/.*`, `/admin/.*`).<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("exclude_paths")]
        public global::System.Collections.Generic.IList<string>? ExcludePaths { get; set; }

        /// <summary>
        /// Regex patterns to exclude specific domains or subdomains from crawling (e.g., `^private\.example\.com$`).<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("exclude_domains")]
        public global::System.Collections.Generic.IList<string>? ExcludeDomains { get; set; }

        /// <summary>
        /// Whether to include external domain links in the final results list.<br/>
        /// Default Value: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("allow_external")]
        public bool? AllowExternal { get; set; }

        /// <summary>
        /// Maximum time in seconds to wait for the map operation before timing out. Must be between 10 and 150 seconds.<br/>
        /// Default Value: 150
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("timeout")]
        public float? Timeout { get; set; }

        /// <summary>
        /// Whether to include credit usage information in the response.`NOTE:`The value may be 0 if the total successful pages mapped has not yet reached 10 calls. See our [Credits &amp; Pricing documentation](https://docs.tavily.com/documentation/api-credits) for details.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("include_usage")]
        public bool? IncludeUsage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateMapRequest" /> class.
        /// </summary>
        /// <param name="url">
        /// The root URL to begin the mapping.<br/>
        /// Example: docs.tavily.com
        /// </param>
        /// <param name="instructions">
        /// Natural language instructions for the crawler. When specified, the cost increases to 2 API credits per 10 successful pages instead of 1 API credit per 10 pages.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464<br/>
        /// Example: Find all pages about the Python SDK
        /// </param>
        /// <param name="maxDepth">
        /// Max depth of the mapping. Defines how far from the base URL the crawler can explore.<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="maxBreadth">
        /// Max number of links to follow per level of the tree (i.e., per page).<br/>
        /// Default Value: 20
        /// </param>
        /// <param name="limit">
        /// Total number of links the crawler will process before stopping.<br/>
        /// Default Value: 50
        /// </param>
        /// <param name="selectPaths">
        /// Regex patterns to select only URLs with specific path patterns (e.g., `/docs/.*`, `/api/v1.*`).<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="selectDomains">
        /// Regex patterns to select crawling to specific domains or subdomains (e.g., `^docs\.example\.com$`).<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="excludePaths">
        /// Regex patterns to exclude URLs with specific path patterns (e.g., `/private/.*`, `/admin/.*`).<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="excludeDomains">
        /// Regex patterns to exclude specific domains or subdomains from crawling (e.g., `^private\.example\.com$`).<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="allowExternal">
        /// Whether to include external domain links in the final results list.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="timeout">
        /// Maximum time in seconds to wait for the map operation before timing out. Must be between 10 and 150 seconds.<br/>
        /// Default Value: 150
        /// </param>
        /// <param name="includeUsage">
        /// Whether to include credit usage information in the response.`NOTE:`The value may be 0 if the total successful pages mapped has not yet reached 10 calls. See our [Credits &amp; Pricing documentation](https://docs.tavily.com/documentation/api-credits) for details.<br/>
        /// Default Value: false
        /// </param>
        public CreateMapRequest(
            string url,
            string? instructions,
            int? maxDepth,
            int? maxBreadth,
            int? limit,
            global::System.Collections.Generic.IList<string>? selectPaths,
            global::System.Collections.Generic.IList<string>? selectDomains,
            global::System.Collections.Generic.IList<string>? excludePaths,
            global::System.Collections.Generic.IList<string>? excludeDomains,
            bool? allowExternal,
            float? timeout,
            bool? includeUsage)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Instructions = instructions;
            this.MaxDepth = maxDepth;
            this.MaxBreadth = maxBreadth;
            this.Limit = limit;
            this.SelectPaths = selectPaths;
            this.SelectDomains = selectDomains;
            this.ExcludePaths = excludePaths;
            this.ExcludeDomains = excludeDomains;
            this.AllowExternal = allowExternal;
            this.Timeout = timeout;
            this.IncludeUsage = includeUsage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateMapRequest" /> class.
        /// </summary>
        public CreateMapRequest()
        {
        }
    }
}