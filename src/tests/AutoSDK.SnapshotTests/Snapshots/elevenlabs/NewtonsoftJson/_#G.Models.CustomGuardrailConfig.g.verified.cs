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
        [global::Newtonsoft.Json.JsonProperty("is_enabled")]
        public bool? IsEnabled { get; set; }

        /// <summary>
        /// User-facing name for this guardrail
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Instruction describing what to block, e.g. 'don't talk about politics'
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt", Required = global::Newtonsoft.Json.Required.Always)]
        public string Prompt { get; set; } = default!;

        /// <summary>
        /// Default Value: streaming
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("execution_mode")]
        public global::G.GuardrailExecutionMode? ExecutionMode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomGuardrailConfig" /> class.
        /// </summary>
        /// <param name="isEnabled">
        /// Default Value: false
        /// </param>
        /// <param name="name">
        /// User-facing name for this guardrail
        /// </param>
        /// <param name="prompt">
        /// Instruction describing what to block, e.g. 'don't talk about politics'
        /// </param>
        /// <param name="executionMode">
        /// Default Value: streaming
        /// </param>
        public CustomGuardrailConfig(
            string name,
            string prompt,
            bool? isEnabled,
            global::G.GuardrailExecutionMode? executionMode)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.IsEnabled = isEnabled;
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