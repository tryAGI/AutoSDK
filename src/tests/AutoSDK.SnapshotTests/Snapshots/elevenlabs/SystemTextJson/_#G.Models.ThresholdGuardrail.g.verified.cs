//HintName: G.Models.ThresholdGuardrail.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ThresholdGuardrail
    {
        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_enabled")]
        public bool? IsEnabled { get; set; }

        /// <summary>
        /// Default Value: 0.3F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("threshold")]
        public double? Threshold { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ThresholdGuardrail" /> class.
        /// </summary>
        /// <param name="isEnabled">
        /// Default Value: false
        /// </param>
        /// <param name="threshold">
        /// Default Value: 0.3F
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ThresholdGuardrail(
            bool? isEnabled,
            double? threshold)
        {
            this.IsEnabled = isEnabled;
            this.Threshold = threshold;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ThresholdGuardrail" /> class.
        /// </summary>
        public ThresholdGuardrail()
        {
        }
    }
}