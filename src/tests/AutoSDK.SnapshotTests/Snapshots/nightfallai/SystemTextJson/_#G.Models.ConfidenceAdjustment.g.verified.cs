//HintName: G.Models.ConfidenceAdjustment.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ConfidenceAdjustment
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fixedConfidence")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ConfidenceJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.Confidence FixedConfidence { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConfidenceAdjustment" /> class.
        /// </summary>
        /// <param name="fixedConfidence"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConfidenceAdjustment(
            global::G.Confidence fixedConfidence)
        {
            this.FixedConfidence = fixedConfidence;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConfidenceAdjustment" /> class.
        /// </summary>
        public ConfidenceAdjustment()
        {
        }
    }
}