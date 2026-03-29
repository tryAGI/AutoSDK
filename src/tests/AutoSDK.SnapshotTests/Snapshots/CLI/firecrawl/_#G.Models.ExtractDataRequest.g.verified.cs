//HintName: G.Models.ExtractDataRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ExtractDataRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("urls")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Urls { get; set; }

        /// <summary>
        /// Prompt to guide the extraction process
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// Schema to define the structure of the extracted data. Must conform to [JSON Schema](https://json-schema.org/).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("schema")]
        public object? Schema { get; set; }

        /// <summary>
        /// When true, the extraction will use web search to find additional data<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enableWebSearch")]
        public bool? EnableWebSearch { get; set; }

        /// <summary>
        /// When true, sitemap.xml files will be ignored during website scanning<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ignoreSitemap")]
        public bool? IgnoreSitemap { get; set; }

        /// <summary>
        /// When true, subdomains of the provided URLs will also be scanned<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("includeSubdomains")]
        public bool? IncludeSubdomains { get; set; }

        /// <summary>
        /// When true, the sources used to extract the data will be included in the response as `sources` key<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("showSources")]
        public bool? ShowSources { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scrapeOptions")]
        public global::G.ScrapeOptions? ScrapeOptions { get; set; }

        /// <summary>
        /// If invalid URLs are specified in the urls array, they will be ignored. Instead of them failing the entire request, an extract using the remaining valid URLs will be performed, and the invalid URLs will be returned in the invalidURLs field of the response.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ignoreInvalidURLs")]
        public bool? IgnoreInvalidURLs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtractDataRequest" /> class.
        /// </summary>
        /// <param name="urls"></param>
        /// <param name="prompt">
        /// Prompt to guide the extraction process
        /// </param>
        /// <param name="schema">
        /// Schema to define the structure of the extracted data. Must conform to [JSON Schema](https://json-schema.org/).
        /// </param>
        /// <param name="enableWebSearch">
        /// When true, the extraction will use web search to find additional data<br/>
        /// Default Value: false
        /// </param>
        /// <param name="ignoreSitemap">
        /// When true, sitemap.xml files will be ignored during website scanning<br/>
        /// Default Value: false
        /// </param>
        /// <param name="includeSubdomains">
        /// When true, subdomains of the provided URLs will also be scanned<br/>
        /// Default Value: true
        /// </param>
        /// <param name="showSources">
        /// When true, the sources used to extract the data will be included in the response as `sources` key<br/>
        /// Default Value: false
        /// </param>
        /// <param name="scrapeOptions"></param>
        /// <param name="ignoreInvalidURLs">
        /// If invalid URLs are specified in the urls array, they will be ignored. Instead of them failing the entire request, an extract using the remaining valid URLs will be performed, and the invalid URLs will be returned in the invalidURLs field of the response.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExtractDataRequest(
            global::System.Collections.Generic.IList<string> urls,
            string? prompt,
            object? schema,
            bool? enableWebSearch,
            bool? ignoreSitemap,
            bool? includeSubdomains,
            bool? showSources,
            global::G.ScrapeOptions? scrapeOptions,
            bool? ignoreInvalidURLs)
        {
            this.Urls = urls ?? throw new global::System.ArgumentNullException(nameof(urls));
            this.Prompt = prompt;
            this.Schema = schema;
            this.EnableWebSearch = enableWebSearch;
            this.IgnoreSitemap = ignoreSitemap;
            this.IncludeSubdomains = includeSubdomains;
            this.ShowSources = showSources;
            this.ScrapeOptions = scrapeOptions;
            this.IgnoreInvalidURLs = ignoreInvalidURLs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtractDataRequest" /> class.
        /// </summary>
        public ExtractDataRequest()
        {
        }
    }
}