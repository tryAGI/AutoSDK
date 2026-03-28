//HintName: G.Models.CustomGuardrailConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Single custom guardrail configuration
    /// </summary>
    public sealed partial class CustomGuardrailConfig
    {
        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_enabled")]
        public bool? IsEnabled { get; set; }

        /// <summary>
        /// User-facing name for this guardrail
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Instruction describing what to block, e.g. 'don't talk about politics'
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// Default Value: streaming
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("execution_mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.GuardrailExecutionModeJsonConverter))]
        public global::G.GuardrailExecutionMode? ExecutionMode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomGuardrailConfig" /> class.
        /// </summary>
        /// <param name="name">
        /// User-facing name for this guardrail
        /// </param>
        /// <param name="prompt">
        /// Instruction describing what to block, e.g. 'don't talk about politics'
        /// </param>
        /// <param name="isEnabled">
        /// Default Value: false
        /// </param>
        /// <param name="executionMode">
        /// Default Value: streaming
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CustomGuardrailConfig(
            string name,
            string prompt,
            bool? isEnabled,
            global::G.GuardrailExecutionMode? executionMode)
        {
            this.IsEnabled = isEnabled;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.ExecutionMode = executionMode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomGuardrailConfig" /> class.
        /// </summary>
        public CustomGuardrailConfig()
        {
        }
    }
}