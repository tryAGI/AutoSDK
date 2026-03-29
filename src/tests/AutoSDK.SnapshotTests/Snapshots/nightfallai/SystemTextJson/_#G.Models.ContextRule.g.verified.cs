//HintName: G.Models.ContextRule.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ContextRule
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("regex")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.Regex Regex { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("proximity")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.Proximity Proximity { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("confidenceAdjustment")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ConfidenceAdjustment ConfidenceAdjustment { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ContextRule" /> class.
        /// </summary>
        /// <param name="regex"></param>
        /// <param name="proximity"></param>
        /// <param name="confidenceAdjustment"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ContextRule(
            global::G.Regex regex,
            global::G.Proximity proximity,
            global::G.ConfidenceAdjustment confidenceAdjustment)
        {
            this.Regex = regex ?? throw new global::System.ArgumentNullException(nameof(regex));
            this.Proximity = proximity ?? throw new global::System.ArgumentNullException(nameof(proximity));
            this.ConfidenceAdjustment = confidenceAdjustment ?? throw new global::System.ArgumentNullException(nameof(confidenceAdjustment));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContextRule" /> class.
        /// </summary>
        public ContextRule()
        {
        }
    }
}