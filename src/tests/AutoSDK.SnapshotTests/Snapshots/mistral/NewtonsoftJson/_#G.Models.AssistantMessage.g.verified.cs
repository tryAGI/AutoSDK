//HintName: G.Models.AssistantMessage.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AssistantMessage
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content")]
        public global::G.AnyOf<string, object, global::System.Collections.Generic.IList<global::G.ContentChunk>>? Content { get; set; }

        /// <summary>
        /// Set this to `true` when adding an assistant message as prefix to condition the model response. The role of the prefix message is to force the model to start its answer by the content of the message.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prefix")]
        public bool? Prefix { get; set; }

        /// <summary>
        /// Default Value: assistant
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("role")]
        public global::G.AssistantMessageRole? Role { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tool_calls")]
        public global::System.Collections.Generic.IList<global::G.ToolCall>? ToolCalls { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AssistantMessage" /> class.
        /// </summary>
        /// <param name="content"></param>
        /// <param name="prefix">
        /// Set this to `true` when adding an assistant message as prefix to condition the model response. The role of the prefix message is to force the model to start its answer by the content of the message.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="role">
        /// Default Value: assistant
        /// </param>
        /// <param name="toolCalls"></param>
        public AssistantMessage(
            global::G.AnyOf<string, object, global::System.Collections.Generic.IList<global::G.ContentChunk>>? content,
            bool? prefix,
            global::G.AssistantMessageRole? role,
            global::System.Collections.Generic.IList<global::G.ToolCall>? toolCalls)
        {
            this.Content = content;
            this.Prefix = prefix;
            this.Role = role;
            this.ToolCalls = toolCalls;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AssistantMessage" /> class.
        /// </summary>
        public AssistantMessage()
        {
        }
    }
}