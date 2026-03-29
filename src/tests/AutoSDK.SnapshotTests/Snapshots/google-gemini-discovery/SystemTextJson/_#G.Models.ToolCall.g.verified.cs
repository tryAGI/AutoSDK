//HintName: G.Models.ToolCall.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A predicted server-side `ToolCall` returned from the model. This message contains information about a tool that the model wants to invoke. The client is NOT expected to execute this `ToolCall`. Instead, the client should pass this `ToolCall` back to the API in a subsequent turn within a `Content` message, along with the corresponding `ToolResponse`.
    /// </summary>
    public sealed partial class ToolCall
    {
        /// <summary>
        /// Optional. Unique identifier of the tool call. The server returns the tool response with the matching `id`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Required. The type of tool that was called.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("toolType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ToolCallToolTypeJsonConverter))]
        public global::G.ToolCallToolType? ToolType { get; set; }

        /// <summary>
        /// Optional. The tool call arguments. Example: {"arg1" : "value1", "arg2" : "value2" , ...}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("args")]
        public object? Args { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolCall" /> class.
        /// </summary>
        /// <param name="id">
        /// Optional. Unique identifier of the tool call. The server returns the tool response with the matching `id`.
        /// </param>
        /// <param name="toolType">
        /// Required. The type of tool that was called.
        /// </param>
        /// <param name="args">
        /// Optional. The tool call arguments. Example: {"arg1" : "value1", "arg2" : "value2" , ...}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolCall(
            string? id,
            global::G.ToolCallToolType? toolType,
            object? args)
        {
            this.Id = id;
            this.ToolType = toolType;
            this.Args = args;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolCall" /> class.
        /// </summary>
        public ToolCall()
        {
        }
    }
}