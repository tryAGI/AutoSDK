//HintName: G.Models.ChatCompletionMessageParamTool.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatCompletionMessageParamTool
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content")]
        public global::G.AnyOf<string, global::System.Collections.Generic.IList<global::G.ChatCompletionContentPartText>>? Content { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("role")]
        public global::G.ChatCompletionMessageParamToolRole Role { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tool_call_id")]
        public string? ToolCallId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionMessageParamTool" /> class.
        /// </summary>
        /// <param name="content"></param>
        /// <param name="role"></param>
        /// <param name="toolCallId"></param>
        public ChatCompletionMessageParamTool(
            global::G.AnyOf<string, global::System.Collections.Generic.IList<global::G.ChatCompletionContentPartText>>? content,
            global::G.ChatCompletionMessageParamToolRole role,
            string? toolCallId)
        {
            this.Content = content;
            this.Role = role;
            this.ToolCallId = toolCallId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionMessageParamTool" /> class.
        /// </summary>
        public ChatCompletionMessageParamTool()
        {
        }
    }
}