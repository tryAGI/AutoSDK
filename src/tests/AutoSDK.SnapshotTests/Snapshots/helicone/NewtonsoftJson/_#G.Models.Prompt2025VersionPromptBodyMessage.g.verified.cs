//HintName: G.Models.Prompt2025VersionPromptBodyMessage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Prompt2025VersionPromptBodyMessage
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tool_calls")]
        public global::System.Collections.Generic.IList<global::G.Prompt2025VersionPromptBodyMessageToolCall>? ToolCalls { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tool_call_id")]
        public string? ToolCallId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content")]
        public global::G.AnyOf<string, global::System.Collections.Generic.IList<global::G.Prompt2025VersionPromptBodyMessageContentVariant2Item>>? Content { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("role", Required = global::Newtonsoft.Json.Required.Always)]
        public string Role { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Prompt2025VersionPromptBodyMessage" /> class.
        /// </summary>
        /// <param name="role"></param>
        /// <param name="toolCalls"></param>
        /// <param name="toolCallId"></param>
        /// <param name="name"></param>
        /// <param name="content"></param>
        public Prompt2025VersionPromptBodyMessage(
            string role,
            global::System.Collections.Generic.IList<global::G.Prompt2025VersionPromptBodyMessageToolCall>? toolCalls,
            string? toolCallId,
            string? name,
            global::G.AnyOf<string, global::System.Collections.Generic.IList<global::G.Prompt2025VersionPromptBodyMessageContentVariant2Item>>? content)
        {
            this.ToolCalls = toolCalls;
            this.ToolCallId = toolCallId;
            this.Name = name;
            this.Content = content;
            this.Role = role ?? throw new global::System.ArgumentNullException(nameof(role));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Prompt2025VersionPromptBodyMessage" /> class.
        /// </summary>
        public Prompt2025VersionPromptBodyMessage()
        {
        }
    }
}