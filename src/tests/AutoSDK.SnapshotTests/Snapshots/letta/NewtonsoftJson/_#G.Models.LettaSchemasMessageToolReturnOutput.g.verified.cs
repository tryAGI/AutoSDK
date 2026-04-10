//HintName: G.Models.LettaSchemasMessageToolReturnOutput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LettaSchemasMessageToolReturnOutput
    {
        /// <summary>
        /// The ID for the tool call
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tool_call_id")]
        public object? ToolCallId { get; set; }

        /// <summary>
        /// The status of the tool call
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.LettaSchemasMessageToolReturnOutputStatusJsonConverter))]
        public global::G.LettaSchemasMessageToolReturnOutputStatus Status { get; set; } = default!;

        /// <summary>
        /// Captured stdout (e.g. prints, logs) from the tool invocation
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("stdout")]
        public global::System.Collections.Generic.IList<string>? Stdout { get; set; }

        /// <summary>
        /// Captured stderr from the tool invocation
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("stderr")]
        public global::System.Collections.Generic.IList<string>? Stderr { get; set; }

        /// <summary>
        /// The function response - either a string or list of content parts (text/image)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("func_response")]
        public global::G.AnyOf<string, global::System.Collections.Generic.IList<global::G.FuncResponseVariant2Item2>, object>? FuncResponse { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LettaSchemasMessageToolReturnOutput" /> class.
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
        public LettaSchemasMessageToolReturnOutput(
            global::G.LettaSchemasMessageToolReturnOutputStatus status,
            object? toolCallId,
            global::System.Collections.Generic.IList<string>? stdout,
            global::System.Collections.Generic.IList<string>? stderr,
            global::G.AnyOf<string, global::System.Collections.Generic.IList<global::G.FuncResponseVariant2Item2>, object>? funcResponse)
        {
            this.ToolCallId = toolCallId;
            this.Status = status;
            this.Stdout = stdout;
            this.Stderr = stderr;
            this.FuncResponse = funcResponse;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LettaSchemasMessageToolReturnOutput" /> class.
        /// </summary>
        public LettaSchemasMessageToolReturnOutput()
        {
        }
    }
}