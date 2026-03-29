//HintName: G.Models.CostDollarsPerPagePrices.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Standard price per page for different content operations
    /// </summary>
    public sealed partial class CostDollarsPerPagePrices
    {
        /// <summary>
        /// Standard price per page for text content<br/>
        /// Example: 0.001
        /// </summary>
        /// <example>0.001</example>
        [global::Newtonsoft.Json.JsonProperty("contentText")]
        public float? ContentText { get; set; }

        /// <summary>
        /// Standard price per page for highlights<br/>
        /// Example: 0.001
        /// </summary>
        /// <example>0.001</example>
        [global::Newtonsoft.Json.JsonProperty("contentHighlight")]
        public float? ContentHighlight { get; set; }

        /// <summary>
        /// Standard price per page for summaries<br/>
        /// Example: 0.001
        /// </summary>
        /// <example>0.001</example>
        [global::Newtonsoft.Json.JsonProperty("contentSummary")]
        public float? ContentSummary { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CostDollarsPerPagePrices" /> class.
        /// </summary>
        /// <param name="contentText">
        /// Standard price per page for text content<br/>
        /// Example: 0.001
        /// </param>
        /// <param name="contentHighlight">
        /// Standard price per page for highlights<br/>
        /// Example: 0.001
        /// </param>
        /// <param name="contentSummary">
        /// Standard price per page for summaries<br/>
        /// Example: 0.001
        /// </param>
        public CostDollarsPerPagePrices(
            float? contentText,
            float? contentHighlight,
            float? contentSummary)
        {
            this.ContentText = contentText;
            this.ContentHighlight = contentHighlight;
            this.ContentSummary = contentSummary;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CostDollarsPerPagePrices" /> class.
        /// </summary>
        public CostDollarsPerPagePrices()
        {
        }
    }
}