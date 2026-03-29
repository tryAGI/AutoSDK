//HintName: G.Models.LlamaParsePageRanges.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Page selection options for processing specific pages or limiting page count.
    /// </summary>
    public sealed partial class LlamaParsePageRanges
    {
        /// <summary>
        /// Maximum number of pages to process. Pages are processed in order starting from page 1. If both max_pages and target_pages are set, target_pages takes precedence
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_pages")]
        public int? MaxPages { get; set; }

        /// <summary>
        /// Comma-separated list of specific pages to process using 1-based indexing. Supports individual pages and ranges. Examples: '1,3,5' (pages 1, 3, 5), '1-5' (pages 1 through 5 inclusive), '1,3,5-8,10' (pages 1, 3, 5-8, and 10). Pages are sorted and deduplicated automatically. Duplicate pages cause an error
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("target_pages")]
        public string? TargetPages { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LlamaParsePageRanges" /> class.
        /// </summary>
        /// <param name="maxPages">
        /// Maximum number of pages to process. Pages are processed in order starting from page 1. If both max_pages and target_pages are set, target_pages takes precedence
        /// </param>
        /// <param name="targetPages">
        /// Comma-separated list of specific pages to process using 1-based indexing. Supports individual pages and ranges. Examples: '1,3,5' (pages 1, 3, 5), '1-5' (pages 1 through 5 inclusive), '1,3,5-8,10' (pages 1, 3, 5-8, and 10). Pages are sorted and deduplicated automatically. Duplicate pages cause an error
        /// </param>
        public LlamaParsePageRanges(
            int? maxPages,
            string? targetPages)
        {
            this.MaxPages = maxPages;
            this.TargetPages = targetPages;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LlamaParsePageRanges" /> class.
        /// </summary>
        public LlamaParsePageRanges()
        {
        }
    }
}