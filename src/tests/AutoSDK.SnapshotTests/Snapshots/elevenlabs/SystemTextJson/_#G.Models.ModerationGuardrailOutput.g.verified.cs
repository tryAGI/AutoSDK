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
        [global::System.Text.Json.Serialization.JsonPropertyName("execution_mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.GuardrailExecutionModeJsonConverter))]
        public global::G.GuardrailExecutionMode? ExecutionMode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        public global::G.ModerationConfig? Config { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModerationGuardrailOutput" /> class.
        /// </summary>
        /// <param name="executionMode">
        /// Default Value: streaming
        /// </param>
        /// <param name="config"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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