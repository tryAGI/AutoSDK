//HintName: G.Models.SydeGuardParameters.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SydeGuardParameters
    {
        /// <summary>
        /// Threshold for prompt injection risk score (0-1)<br/>
        /// Default Value: 0.5
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_injection_threshold")]
        public double? PromptInjectionThreshold { get; set; }

        /// <summary>
        /// Threshold for toxicity risk score (0-1)<br/>
        /// Default Value: 0.5
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("toxicity_threshold")]
        public double? ToxicityThreshold { get; set; }

        /// <summary>
        /// Threshold for evasion risk score (0-1)<br/>
        /// Default Value: 0.5
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("evasion_threshold")]
        public double? EvasionThreshold { get; set; }

        /// <summary>
        /// Timeout in milliseconds<br/>
        /// Default Value: 5000
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timeout")]
        public double? Timeout { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SydeGuardParameters" /> class.
        /// </summary>
        /// <param name="promptInjectionThreshold">
        /// Threshold for prompt injection risk score (0-1)<br/>
        /// Default Value: 0.5
        /// </param>
        /// <param name="toxicityThreshold">
        /// Threshold for toxicity risk score (0-1)<br/>
        /// Default Value: 0.5
        /// </param>
        /// <param name="evasionThreshold">
        /// Threshold for evasion risk score (0-1)<br/>
        /// Default Value: 0.5
        /// </param>
        /// <param name="timeout">
        /// Timeout in milliseconds<br/>
        /// Default Value: 5000
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SydeGuardParameters(
            double? promptInjectionThreshold,
            double? toxicityThreshold,
            double? evasionThreshold,
            double? timeout)
        {
            this.PromptInjectionThreshold = promptInjectionThreshold;
            this.ToxicityThreshold = toxicityThreshold;
            this.EvasionThreshold = evasionThreshold;
            this.Timeout = timeout;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SydeGuardParameters" /> class.
        /// </summary>
        public SydeGuardParameters()
        {
        }
    }
}