//HintName: G.Models.CostDollarsBreakDownItemBreakdown.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CostDollarsBreakDownItemBreakdown
    {
        /// <summary>
        /// Cost of your neural search operations<br/>
        /// Example: 0.005
        /// </summary>
        /// <example>0.005</example>
        [global::Newtonsoft.Json.JsonProperty("neuralSearch")]
        public float? NeuralSearch { get; set; }

        /// <summary>
        /// Cost of your deep search operations<br/>
        /// Example: 0.015
        /// </summary>
        /// <example>0.015</example>
        [global::Newtonsoft.Json.JsonProperty("deepSearch")]
        public float? DeepSearch { get; set; }

        /// <summary>
        /// Cost of your text content retrieval<br/>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::Newtonsoft.Json.JsonProperty("contentText")]
        public float? ContentText { get; set; }

        /// <summary>
        /// Cost of your highlight generation<br/>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::Newtonsoft.Json.JsonProperty("contentHighlight")]
        public float? ContentHighlight { get; set; }

        /// <summary>
        /// Cost of your summary generation<br/>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::Newtonsoft.Json.JsonProperty("contentSummary")]
        public float? ContentSummary { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CostDollarsBreakDownItemBreakdown" /> class.
        /// </summary>
        /// <param name="neuralSearch">
        /// Cost of your neural search operations<br/>
        /// Example: 0.005
        /// </param>
        /// <param name="deepSearch">
        /// Cost of your deep search operations<br/>
        /// Example: 0.015
        /// </param>
        /// <param name="contentText">
        /// Cost of your text content retrieval<br/>
        /// Example: 0
        /// </param>
        /// <param name="contentHighlight">
        /// Cost of your highlight generation<br/>
        /// Example: 0
        /// </param>
        /// <param name="contentSummary">
        /// Cost of your summary generation<br/>
        /// Example: 0
        /// </param>
        public CostDollarsBreakDownItemBreakdown(
            float? neuralSearch,
            float? deepSearch,
            float? contentText,
            float? contentHighlight,
            float? contentSummary)
        {
            this.NeuralSearch = neuralSearch;
            this.DeepSearch = deepSearch;
            this.ContentText = contentText;
            this.ContentHighlight = contentHighlight;
            this.ContentSummary = contentSummary;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CostDollarsBreakDownItemBreakdown" /> class.
        /// </summary>
        public CostDollarsBreakDownItemBreakdown()
        {
        }
    }
}