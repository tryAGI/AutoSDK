//HintName: G.Models.CommonRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CommonRequest
    {
        /// <summary>
        /// Number of results to return (up to thousands of results available for custom plans)<br/>
        /// Default Value: 10<br/>
        /// Example: 10
        /// </summary>
        /// <example>10</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("numResults")]
        public int? NumResults { get; set; }

        /// <summary>
        /// List of domains to include in the search. If specified, results will only come from these domains.<br/>
        /// Example: [arxiv.org, paperswithcode.com]
        /// </summary>
        /// <example>[arxiv.org, paperswithcode.com]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("includeDomains")]
        public global::System.Collections.Generic.IList<string>? IncludeDomains { get; set; }

        /// <summary>
        /// List of domains to exclude from search results. If specified, no results will be returned from these domains.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("excludeDomains")]
        public global::System.Collections.Generic.IList<string>? ExcludeDomains { get; set; }

        /// <summary>
        /// Crawl date refers to the date that Exa discovered a link. Results will include links that were crawled after this date. Must be specified in ISO 8601 format.<br/>
        /// Example: 2023-01-01
        /// </summary>
        /// <example>2023-01-01</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("startCrawlDate")]
        public global::System.DateTime? StartCrawlDate { get; set; }

        /// <summary>
        /// Crawl date refers to the date that Exa discovered a link. Results will include links that were crawled before this date. Must be specified in ISO 8601 format.<br/>
        /// Example: 2023-12-31
        /// </summary>
        /// <example>2023-12-31</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("endCrawlDate")]
        public global::System.DateTime? EndCrawlDate { get; set; }

        /// <summary>
        /// Only links with a published date after this will be returned. Must be specified in ISO 8601 format.<br/>
        /// Example: 2023-01-01
        /// </summary>
        /// <example>2023-01-01</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("startPublishedDate")]
        public global::System.DateTime? StartPublishedDate { get; set; }

        /// <summary>
        /// Only links with a published date before this will be returned. Must be specified in ISO 8601 format.<br/>
        /// Example: 2023-12-31
        /// </summary>
        /// <example>2023-12-31</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("endPublishedDate")]
        public global::System.DateTime? EndPublishedDate { get; set; }

        /// <summary>
        /// List of strings that must be present in webpage text of results. Currently, only 1 string is supported, of up to 5 words.<br/>
        /// Example: [large language model]
        /// </summary>
        /// <example>[large language model]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("includeText")]
        public global::System.Collections.Generic.IList<string>? IncludeText { get; set; }

        /// <summary>
        /// List of strings that must not be present in webpage text of results. Currently, only 1 string is supported, of up to 5 words. Checks from the first 1000 words of the webpage text.<br/>
        /// Example: [course]
        /// </summary>
        /// <example>[course]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("excludeText")]
        public global::System.Collections.Generic.IList<string>? ExcludeText { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("context")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverter<bool?, global::G.CommonRequestContext>))]
        public global::G.OneOf<bool?, global::G.CommonRequestContext>? Context { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contents")]
        public global::G.ContentsRequest? Contents { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CommonRequest" /> class.
        /// </summary>
        /// <param name="numResults">
        /// Number of results to return (up to thousands of results available for custom plans)<br/>
        /// Default Value: 10<br/>
        /// Example: 10
        /// </param>
        /// <param name="includeDomains">
        /// List of domains to include in the search. If specified, results will only come from these domains.<br/>
        /// Example: [arxiv.org, paperswithcode.com]
        /// </param>
        /// <param name="excludeDomains">
        /// List of domains to exclude from search results. If specified, no results will be returned from these domains.
        /// </param>
        /// <param name="startCrawlDate">
        /// Crawl date refers to the date that Exa discovered a link. Results will include links that were crawled after this date. Must be specified in ISO 8601 format.<br/>
        /// Example: 2023-01-01
        /// </param>
        /// <param name="endCrawlDate">
        /// Crawl date refers to the date that Exa discovered a link. Results will include links that were crawled before this date. Must be specified in ISO 8601 format.<br/>
        /// Example: 2023-12-31
        /// </param>
        /// <param name="startPublishedDate">
        /// Only links with a published date after this will be returned. Must be specified in ISO 8601 format.<br/>
        /// Example: 2023-01-01
        /// </param>
        /// <param name="endPublishedDate">
        /// Only links with a published date before this will be returned. Must be specified in ISO 8601 format.<br/>
        /// Example: 2023-12-31
        /// </param>
        /// <param name="includeText">
        /// List of strings that must be present in webpage text of results. Currently, only 1 string is supported, of up to 5 words.<br/>
        /// Example: [large language model]
        /// </param>
        /// <param name="excludeText">
        /// List of strings that must not be present in webpage text of results. Currently, only 1 string is supported, of up to 5 words. Checks from the first 1000 words of the webpage text.<br/>
        /// Example: [course]
        /// </param>
        /// <param name="context"></param>
        /// <param name="contents"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CommonRequest(
            int? numResults,
            global::System.Collections.Generic.IList<string>? includeDomains,
            global::System.Collections.Generic.IList<string>? excludeDomains,
            global::System.DateTime? startCrawlDate,
            global::System.DateTime? endCrawlDate,
            global::System.DateTime? startPublishedDate,
            global::System.DateTime? endPublishedDate,
            global::System.Collections.Generic.IList<string>? includeText,
            global::System.Collections.Generic.IList<string>? excludeText,
            global::G.OneOf<bool?, global::G.CommonRequestContext>? context,
            global::G.ContentsRequest? contents)
        {
            this.NumResults = numResults;
            this.IncludeDomains = includeDomains;
            this.ExcludeDomains = excludeDomains;
            this.StartCrawlDate = startCrawlDate;
            this.EndCrawlDate = endCrawlDate;
            this.StartPublishedDate = startPublishedDate;
            this.EndPublishedDate = endPublishedDate;
            this.IncludeText = includeText;
            this.ExcludeText = excludeText;
            this.Context = context;
            this.Contents = contents;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CommonRequest" /> class.
        /// </summary>
        public CommonRequest()
        {
        }
    }
}