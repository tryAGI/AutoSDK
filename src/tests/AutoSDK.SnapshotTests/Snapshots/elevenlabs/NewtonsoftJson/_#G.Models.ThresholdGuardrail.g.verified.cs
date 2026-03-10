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
        [global::Newtonsoft.Json.JsonProperty("is_enabled")]
        public bool? IsEnabled { get; set; }

        /// <summary>
        /// Default Value: 0.3F
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("threshold")]
        public double? Threshold { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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