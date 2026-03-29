//HintName: G.Models.ChatCompletionToolMessageParam.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatCompletionToolMessageParam
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AnyOf<string, global::System.Collections.Generic.IList<global::G.ChatCompletionContentPartTextParam>> Content { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        /// <default>"tool"</default>
        [global::Newtonsoft.Json.JsonProperty("role")]
        public string Role { get; set; } = "tool";

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tool_call_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ToolCallId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionToolMessageParam" /> class.
        /// </summary>
        /// <param name="content"></param>
        /// <param name="toolCallId"></param>
        /// <param name="role"></param>
        public ChatCompletionToolMessageParam(
            global::G.AnyOf<string, global::System.Collections.Generic.IList<global::G.ChatCompletionContentPartTextParam>> content,
            string toolCallId,
            string role = "tool")
        {
            this.Content = content;
            this.Role = role;
            this.ToolCallId = toolCallId ?? throw new global::System.ArgumentNullException(nameof(toolCallId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionToolMessageParam" /> class.
        /// </summary>
        public ChatCompletionToolMessageParam()
        {
        }
    }
}