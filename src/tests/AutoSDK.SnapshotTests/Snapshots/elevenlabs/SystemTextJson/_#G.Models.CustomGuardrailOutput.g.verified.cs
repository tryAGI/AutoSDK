//HintName: G.Models.CustomGuardrailOutput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Container for custom guardrails, matching ModerationGuardrail pattern
    /// </summary>
    public sealed partial class CustomGuardrailOutput
    {
        /// <summary>
        /// Config container for custom guardrails list
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        public global::G.CustomGuardrailsConfigOutput? Config { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomGuardrailOutput" /> class.
        /// </summary>
        /// <param name="config">
        /// Config container for custom guardrails list
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CustomGuardrailOutput(
            global::G.CustomGuardrailsConfigOutput? config)
        {
            this.Config = config;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomGuardrailOutput" /> class.
        /// </summary>
        public CustomGuardrailOutput()
        {
        }
    }
}