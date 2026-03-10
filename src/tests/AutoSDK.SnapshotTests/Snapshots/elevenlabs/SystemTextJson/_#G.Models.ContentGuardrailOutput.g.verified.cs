//HintName: G.Models.ContentGuardrailOutput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ContentGuardrailOutput
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
        public global::G.ContentConfig? Config { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ContentGuardrailOutput" /> class.
        /// </summary>
        /// <param name="executionMode">
        /// Default Value: streaming
        /// </param>
        /// <param name="config"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ContentGuardrailOutput(
            global::G.GuardrailExecutionMode? executionMode,
            global::G.ContentConfig? config)
        {
            this.ExecutionMode = executionMode;
            this.Config = config;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContentGuardrailOutput" /> class.
        /// </summary>
        public ContentGuardrailOutput()
        {
        }
    }
}