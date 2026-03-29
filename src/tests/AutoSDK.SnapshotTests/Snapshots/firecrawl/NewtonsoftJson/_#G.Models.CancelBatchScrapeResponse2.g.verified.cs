//HintName: G.Models.CancelBatchScrapeResponse2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CancelBatchScrapeResponse2
    {
        /// <summary>
        /// Example: Batch scrape job not found.
        /// </summary>
        /// <example>Batch scrape job not found.</example>
        [global::Newtonsoft.Json.JsonProperty("error")]
        public string? Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CancelBatchScrapeResponse2" /> class.
        /// </summary>
        /// <param name="error">
        /// Example: Batch scrape job not found.
        /// </param>
        public CancelBatchScrapeResponse2(
            string? error)
        {
            this.Error = error;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CancelBatchScrapeResponse2" /> class.
        /// </summary>
        public CancelBatchScrapeResponse2()
        {
        }
    }
}