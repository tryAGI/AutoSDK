//HintName: G.Models.ModerationGuardrailOutput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ModerationGuardrailOutput
    {
        /// <summary>
        /// Default Value: streaming
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("execution_mode")]
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
        /// Initializes a new instance of the <see cref="ModerationGuardrailOutput" /> class.
        /// </summary>
        /// <param name="executionMode">
        /// Default Value: streaming
        /// </param>
        /// <param name="config"></param>
        public ModerationGuardrailOutput(
            global::G.GuardrailExecutionMode? executionMode,
            global::G.ModerationConfig? config)
        {
            this.ExecutionMode = executionMode;
            this.Config = config;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModerationGuardrailOutput" /> class.
        /// </summary>
        public ModerationGuardrailOutput()
        {
        }
    }
}