//HintName: G.Models.LettaSchemasLettaMessageToolReturn.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LettaSchemasLettaMessageToolReturn
    {
        /// <summary>
        /// The message type to be created.<br/>
        /// Default Value: tool
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// The tool return value - either a string or list of content parts (text/image)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_return")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::G.LettaToolReturnContentUnion>, string>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.AnyOf<global::System.Collections.Generic.IList<global::G.LettaToolReturnContentUnion>, string> ToolReturn { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.LettaSchemasLettaMessageToolReturnStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.LettaSchemasLettaMessageToolReturnStatus Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_call_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ToolCallId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stdout")]
        public global::System.Collections.Generic.IList<string>? Stdout { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stderr")]
        public global::System.Collections.Generic.IList<string>? Stderr { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LettaSchemasLettaMessageToolReturn" /> class.
        /// </summary>
        /// <param name="toolReturn">
        /// The tool return value - either a string or list of content parts (text/image)
        /// </param>
        /// <param name="status"></param>
        /// <param name="toolCallId"></param>
        /// <param name="type">
        /// The message type to be created.<br/>
        /// Default Value: tool
        /// </param>
        /// <param name="stdout"></param>
        /// <param name="stderr"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LettaSchemasLettaMessageToolReturn(
            global::G.AnyOf<global::System.Collections.Generic.IList<global::G.LettaToolReturnContentUnion>, string> toolReturn,
            global::G.LettaSchemasLettaMessageToolReturnStatus status,
            string toolCallId,
            string? type,
            global::System.Collections.Generic.IList<string>? stdout,
            global::System.Collections.Generic.IList<string>? stderr)
        {
            this.Type = type;
            this.ToolReturn = toolReturn;
            this.Status = status;
            this.ToolCallId = toolCallId ?? throw new global::System.ArgumentNullException(nameof(toolCallId));
            this.Stdout = stdout;
            this.Stderr = stderr;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LettaSchemasLettaMessageToolReturn" /> class.
        /// </summary>
        public LettaSchemasLettaMessageToolReturn()
        {
        }
    }
}