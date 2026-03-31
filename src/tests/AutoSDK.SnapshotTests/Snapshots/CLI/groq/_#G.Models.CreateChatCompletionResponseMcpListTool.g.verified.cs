//HintName: G.Models.CreateChatCompletionResponseMcpListTool.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateChatCompletionResponseMcpListTool
    {
        /// <summary>
        /// Unique identifier for this tool list response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The type identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Human-readable label for the MCP server.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("server_label")]
        public string? ServerLabel { get; set; }

        /// <summary>
        /// Array of discovered tools from the server.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        public global::System.Collections.Generic.IList<global::G.CreateChatCompletionResponseMcpListToolTool>? Tools { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateChatCompletionResponseMcpListTool" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for this tool list response.
        /// </param>
        /// <param name="type">
        /// The type identifier.
        /// </param>
        /// <param name="serverLabel">
        /// Human-readable label for the MCP server.
        /// </param>
        /// <param name="tools">
        /// Array of discovered tools from the server.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateChatCompletionResponseMcpListTool(
            string? id,
            string? type,
            string? serverLabel,
            global::System.Collections.Generic.IList<global::G.CreateChatCompletionResponseMcpListToolTool>? tools)
        {
            this.Id = id;
            this.Type = type;
            this.ServerLabel = serverLabel;
            this.Tools = tools;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateChatCompletionResponseMcpListTool" /> class.
        /// </summary>
        public CreateChatCompletionResponseMcpListTool()
        {
        }
    }
}