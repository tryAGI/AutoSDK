//HintName: G.Models.ModerationGuardrailInput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ModerationGuardrailInput
    {
        /// <summary>
        /// Default Value: streaming
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("execution_mode")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.GuardrailExecutionModeJsonConverter))]
        public global::G.GuardrailExecutionMode? ExecutionMode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("config")]
        public global::G.ModerationConfig? Config { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModerationGuardrailInput" /> class.
        /// </summary>
        /// <param name="executionMode">
        /// Default Value: streaming
        /// </param>
        /// <param name="config"></param>
        public ModerationGuardrailInput(
            global::G.GuardrailExecutionMode? executionMode,
            global::G.ModerationConfig? config)
        {
            this.ExecutionMode = executionMode;
            this.Config = config;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModerationGuardrailInput" /> class.
        /// </summary>
        public ModerationGuardrailInput()
        {
        }
    }
}