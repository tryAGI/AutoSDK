//HintName: G.Models.ToolResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The output from a server-side `ToolCall` execution. This message contains the results of a tool invocation that was initiated by a `ToolCall` from the model. The client should pass this `ToolResponse` back to the API in a subsequent turn within a `Content` message, along with the corresponding `ToolCall`.
    /// </summary>
    public sealed partial class ToolResponse
    {
        /// <summary>
        /// Optional. The identifier of the tool call this response is for.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Required. The type of tool that was called, matching the `tool_type` in the corresponding `ToolCall`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("toolType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ToolResponseToolTypeJsonConverter))]
        public global::G.ToolResponseToolType? ToolType { get; set; }

        /// <summary>
        /// Optional. The tool response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response")]
        public object? Response { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// Optional. The identifier of the tool call this response is for.
        /// </param>
        /// <param name="toolType">
        /// Required. The type of tool that was called, matching the `tool_type` in the corresponding `ToolCall`.
        /// </param>
        /// <param name="response">
        /// Optional. The tool response.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolResponse(
            string? id,
            global::G.ToolResponseToolType? toolType,
            object? response)
        {
            this.Id = id;
            this.ToolType = toolType;
            this.Response = response;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolResponse" /> class.
        /// </summary>
        public ToolResponse()
        {
        }
    }
}