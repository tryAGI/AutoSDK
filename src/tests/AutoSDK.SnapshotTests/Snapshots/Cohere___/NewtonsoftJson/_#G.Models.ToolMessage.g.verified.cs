//HintName: G.Models.ToolMessage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Represents tool result in the chat history.
    /// </summary>
    public sealed partial class ToolMessage
    {
        /// <summary>
        /// One of `CHATBOT`, `SYSTEM`, `TOOL` or `USER` to identify who the message is coming from.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("role", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ChatRole Role { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tool_results")]
        public global::System.Collections.Generic.IList<global::G.ToolResult>? ToolResults { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolMessage" /> class.
        /// </summary>
        /// <param name="role">
        /// One of `CHATBOT`, `SYSTEM`, `TOOL` or `USER` to identify who the message is coming from.
        /// </param>
        /// <param name="toolResults"></param>
        public ToolMessage(
            global::G.ChatRole role,
            global::System.Collections.Generic.IList<global::G.ToolResult>? toolResults)
        {
            this.Role = role;
            this.ToolResults = toolResults;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolMessage" /> class.
        /// </summary>
        public ToolMessage()
        {
        }
    }
}