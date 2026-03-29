//HintName: G.Models.ClassifyV2ParsingConfiguration.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Parsing configuration for classify jobs.
    /// </summary>
    public sealed partial class ClassifyV2ParsingConfiguration
    {
        /// <summary>
        /// Comma-separated page numbers or ranges to process (1-based). Omit to process all pages.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("target_pages")]
        public string? TargetPages { get; set; }

        /// <summary>
        /// Maximum number of pages to process. Omit for no limit.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_pages")]
        public int? MaxPages { get; set; }

        /// <summary>
        /// ISO 639-1 language code for the document<br/>
        /// Default Value: en
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("lang")]
        public string? Lang { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ClassifyV2ParsingConfiguration" /> class.
        /// </summary>
        /// <param name="targetPages">
        /// Comma-separated page numbers or ranges to process (1-based). Omit to process all pages.
        /// </param>
        /// <param name="maxPages">
        /// Maximum number of pages to process. Omit for no limit.
        /// </param>
        /// <param name="lang">
        /// ISO 639-1 language code for the document<br/>
        /// Default Value: en
        /// </param>
        public ClassifyV2ParsingConfiguration(
            string? targetPages,
            int? maxPages,
            string? lang)
        {
            this.TargetPages = targetPages;
            this.MaxPages = maxPages;
            this.Lang = lang;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClassifyV2ParsingConfiguration" /> class.
        /// </summary>
        public ClassifyV2ParsingConfiguration()
        {
        }
    }
}