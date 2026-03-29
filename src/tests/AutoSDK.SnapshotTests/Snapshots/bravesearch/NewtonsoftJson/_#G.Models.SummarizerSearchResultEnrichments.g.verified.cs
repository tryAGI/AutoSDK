//HintName: G.Models.SummarizerSearchResultEnrichments.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Enrichment data for the summary.
    /// </summary>
    public sealed partial class SummarizerSearchResultEnrichments
    {
        /// <summary>
        /// Raw enrichment text.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("raw")]
        public string? Raw { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SummarizerSearchResultEnrichments" /> class.
        /// </summary>
        /// <param name="raw">
        /// Raw enrichment text.
        /// </param>
        public SummarizerSearchResultEnrichments(
            string? raw)
        {
            this.Raw = raw;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SummarizerSearchResultEnrichments" /> class.
        /// </summary>
        public SummarizerSearchResultEnrichments()
        {
        }
    }
}