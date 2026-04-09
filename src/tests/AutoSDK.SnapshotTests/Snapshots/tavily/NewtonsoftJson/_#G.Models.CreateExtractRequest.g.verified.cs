//HintName: G.Models.CreateExtractRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateExtractRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("urls", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.OneOf<string, global::System.Collections.Generic.IList<string>> Urls { get; set; } = default!;

        /// <summary>
        /// User intent for reranking extracted content chunks. When provided, chunks are reranked based on relevance to this query.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("query")]
        public string? Query { get; set; }

        /// <summary>
        /// Chunks are short content snippets (maximum 500 characters each) pulled directly from the source. Use `chunks_per_source` to define the maximum number of relevant chunks returned per source and to control the `raw_content` length. Chunks will appear in the `raw_content` field as: `&lt;chunk 1&gt; [...] &lt;chunk 2&gt; [...] &lt;chunk 3&gt;`. Available only when `query` is provided. Must be between 1 and 5.<br/>
        /// Default Value: 3
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("chunks_per_source")]
        public int? ChunksPerSource { get; set; }

        /// <summary>
        /// The depth of the extraction process. `advanced` extraction retrieves more data, including tables and embedded content, with higher success but may increase latency.`basic` extraction costs 1 credit per 5 successful URL extractions, while `advanced` extraction costs 2 credits per 5 successful URL extractions.<br/>
        /// Default Value: basic
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("extract_depth")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.CreateExtractRequestExtractDepthJsonConverter))]
        public global::G.CreateExtractRequestExtractDepth? ExtractDepth { get; set; }

        /// <summary>
        /// Include a list of images extracted from the URLs in the response. Default is false.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("include_images")]
        public bool? IncludeImages { get; set; }

        /// <summary>
        /// Whether to include the favicon URL for each result.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("include_favicon")]
        public bool? IncludeFavicon { get; set; }

        /// <summary>
        /// The format of the extracted web page content. `markdown` returns content in markdown format. `text` returns plain text and may increase latency.<br/>
        /// Default Value: markdown
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("format")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.CreateExtractRequestFormatJsonConverter))]
        public global::G.CreateExtractRequestFormat? Format { get; set; }

        /// <summary>
        /// Maximum time in seconds to wait for the URL extraction before timing out. Must be between 1.0 and 60.0 seconds. If not specified, default timeouts are applied based on extract_depth: 10 seconds for basic extraction and 30 seconds for advanced extraction.<br/>
        /// Default Value: None
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("timeout")]
        public float? Timeout { get; set; }

        /// <summary>
        /// Whether to include credit usage information in the response. `NOTE:`The value may be 0 if the total successful URL extractions has not yet reached 5 calls. See our [Credits &amp; Pricing documentation](https://docs.tavily.com/documentation/api-credits) for details.<br/>
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
        /// Initializes a new instance of the <see cref="CreateExtractRequest" /> class.
        /// </summary>
        /// <param name="urls"></param>
        /// <param name="query">
        /// User intent for reranking extracted content chunks. When provided, chunks are reranked based on relevance to this query.
        /// </param>
        /// <param name="chunksPerSource">
        /// Chunks are short content snippets (maximum 500 characters each) pulled directly from the source. Use `chunks_per_source` to define the maximum number of relevant chunks returned per source and to control the `raw_content` length. Chunks will appear in the `raw_content` field as: `&lt;chunk 1&gt; [...] &lt;chunk 2&gt; [...] &lt;chunk 3&gt;`. Available only when `query` is provided. Must be between 1 and 5.<br/>
        /// Default Value: 3
        /// </param>
        /// <param name="extractDepth">
        /// The depth of the extraction process. `advanced` extraction retrieves more data, including tables and embedded content, with higher success but may increase latency.`basic` extraction costs 1 credit per 5 successful URL extractions, while `advanced` extraction costs 2 credits per 5 successful URL extractions.<br/>
        /// Default Value: basic
        /// </param>
        /// <param name="includeImages">
        /// Include a list of images extracted from the URLs in the response. Default is false.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="includeFavicon">
        /// Whether to include the favicon URL for each result.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="format">
        /// The format of the extracted web page content. `markdown` returns content in markdown format. `text` returns plain text and may increase latency.<br/>
        /// Default Value: markdown
        /// </param>
        /// <param name="timeout">
        /// Maximum time in seconds to wait for the URL extraction before timing out. Must be between 1.0 and 60.0 seconds. If not specified, default timeouts are applied based on extract_depth: 10 seconds for basic extraction and 30 seconds for advanced extraction.<br/>
        /// Default Value: None
        /// </param>
        /// <param name="includeUsage">
        /// Whether to include credit usage information in the response. `NOTE:`The value may be 0 if the total successful URL extractions has not yet reached 5 calls. See our [Credits &amp; Pricing documentation](https://docs.tavily.com/documentation/api-credits) for details.<br/>
        /// Default Value: false
        /// </param>
        public CreateExtractRequest(
            global::G.OneOf<string, global::System.Collections.Generic.IList<string>> urls,
            string? query,
            int? chunksPerSource,
            global::G.CreateExtractRequestExtractDepth? extractDepth,
            bool? includeImages,
            bool? includeFavicon,
            global::G.CreateExtractRequestFormat? format,
            float? timeout,
            bool? includeUsage)
        {
            this.Urls = urls;
            this.Query = query;
            this.ChunksPerSource = chunksPerSource;
            this.ExtractDepth = extractDepth;
            this.IncludeImages = includeImages;
            this.IncludeFavicon = includeFavicon;
            this.Format = format;
            this.Timeout = timeout;
            this.IncludeUsage = includeUsage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateExtractRequest" /> class.
        /// </summary>
        public CreateExtractRequest()
        {
        }
    }
}