//HintName: G.Models.BedrockGuardParameters.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BedrockGuardParameters
    {
        /// <summary>
        /// Version of the guardrail to use
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("guardrailVersion", Required = global::Newtonsoft.Json.Required.Always)]
        public string GuardrailVersion { get; set; } = default!;

        /// <summary>
        /// ID of the guardrail
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("guardrailId", Required = global::Newtonsoft.Json.Required.Always)]
        public string GuardrailId { get; set; } = default!;

        /// <summary>
        /// Whether to redact detected PII<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("redact")]
        public bool? Redact { get; set; }

        /// <summary>
        /// Timeout in milliseconds<br/>
        /// Default Value: 5000
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("timeout")]
        public double? Timeout { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BedrockGuardParameters" /> class.
        /// </summary>
        /// <param name="guardrailVersion">
        /// Version of the guardrail to use
        /// </param>
        /// <param name="guardrailId">
        /// ID of the guardrail
        /// </param>
        /// <param name="redact">
        /// Whether to redact detected PII<br/>
        /// Default Value: false
        /// </param>
        /// <param name="timeout">
        /// Timeout in milliseconds<br/>
        /// Default Value: 5000
        /// </param>
        public BedrockGuardParameters(
            string guardrailVersion,
            string guardrailId,
            bool? redact,
            double? timeout)
        {
            this.GuardrailVersion = guardrailVersion ?? throw new global::System.ArgumentNullException(nameof(guardrailVersion));
            this.GuardrailId = guardrailId ?? throw new global::System.ArgumentNullException(nameof(guardrailId));
            this.Redact = redact;
            this.Timeout = timeout;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BedrockGuardParameters" /> class.
        /// </summary>
        public BedrockGuardParameters()
        {
        }
    }
}