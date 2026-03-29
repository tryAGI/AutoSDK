//HintName: G.Models.McpToolMessages.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class McpToolMessages
    {
        /// <summary>
        /// The name of the tool from the MCP server.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Custom messages for this specific tool. Set to an empty array to suppress all messages for this tool. If not provided, the tool will use the default messages from the parent MCP tool configuration.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("messages")]
        public global::System.Collections.Generic.IList<global::G.OneOf<global::G.ToolMessageStart, global::G.ToolMessageComplete, global::G.ToolMessageFailed, global::G.ToolMessageDelayed>>? Messages { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="McpToolMessages" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the tool from the MCP server.
        /// </param>
        /// <param name="messages">
        /// Custom messages for this specific tool. Set to an empty array to suppress all messages for this tool. If not provided, the tool will use the default messages from the parent MCP tool configuration.
        /// </param>
        public McpToolMessages(
            string name,
            global::System.Collections.Generic.IList<global::G.OneOf<global::G.ToolMessageStart, global::G.ToolMessageComplete, global::G.ToolMessageFailed, global::G.ToolMessageDelayed>>? messages)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Messages = messages;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="McpToolMessages" /> class.
        /// </summary>
        public McpToolMessages()
        {
        }
    }
}