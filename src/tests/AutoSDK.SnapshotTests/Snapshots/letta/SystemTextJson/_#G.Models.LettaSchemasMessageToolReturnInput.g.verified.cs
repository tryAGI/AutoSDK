//HintName: G.Models.LettaSchemasMessageToolReturnInput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LettaSchemasMessageToolReturnInput
    {
        /// <summary>
        /// The ID for the tool call
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_call_id")]
        public object? ToolCallId { get; set; }

        /// <summary>
        /// The status of the tool call
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.LettaSchemasMessageToolReturnInputStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.LettaSchemasMessageToolReturnInputStatus Status { get; set; }

        /// <summary>
        /// Captured stdout (e.g. prints, logs) from the tool invocation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stdout")]
        public global::System.Collections.Generic.IList<string>? Stdout { get; set; }

        /// <summary>
        /// Captured stderr from the tool invocation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stderr")]
        public global::System.Collections.Generic.IList<string>? Stderr { get; set; }

        /// <summary>
        /// The function response - either a string or list of content parts (text/image)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("func_response")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::G.FuncResponseVariant2Item>, object>))]
        public global::G.AnyOf<string, global::System.Collections.Generic.IList<global::G.FuncResponseVariant2Item>, object>? FuncResponse { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LettaSchemasMessageToolReturnInput" /> class.
        /// </summary>
        /// <param name="status">
        /// The status of the tool call
        /// </param>
        /// <param name="toolCallId">
        /// The ID for the tool call
        /// </param>
        /// <param name="stdout">
        /// Captured stdout (e.g. prints, logs) from the tool invocation
        /// </param>
        /// <param name="stderr">
        /// Captured stderr from the tool invocation
        /// </param>
        /// <param name="funcResponse">
        /// The function response - either a string or list of content parts (text/image)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LettaSchemasMessageToolReturnInput(
            global::G.LettaSchemasMessageToolReturnInputStatus status,
            object? toolCallId,
            global::System.Collections.Generic.IList<string>? stdout,
            global::System.Collections.Generic.IList<string>? stderr,
            global::G.AnyOf<string, global::System.Collections.Generic.IList<global::G.FuncResponseVariant2Item>, object>? funcResponse)
        {
            this.ToolCallId = toolCallId;
            this.Status = status;
            this.Stdout = stdout;
            this.Stderr = stderr;
            this.FuncResponse = funcResponse;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LettaSchemasMessageToolReturnInput" /> class.
        /// </summary>
        public LettaSchemasMessageToolReturnInput()
        {
        }
    }
}