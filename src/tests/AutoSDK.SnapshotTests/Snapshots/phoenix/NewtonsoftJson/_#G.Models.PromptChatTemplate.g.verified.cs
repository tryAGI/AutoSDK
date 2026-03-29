//HintName: G.Models.PromptChatTemplate.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PromptChatTemplate
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"chat"</default>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string Type { get; set; } = "chat";

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("messages", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.PromptMessage> Messages { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptChatTemplate" /> class.
        /// </summary>
        /// <param name="messages"></param>
        /// <param name="type"></param>
        public PromptChatTemplate(
            global::System.Collections.Generic.IList<global::G.PromptMessage> messages,
            string type = "chat")
        {
            this.Type = type;
            this.Messages = messages ?? throw new global::System.ArgumentNullException(nameof(messages));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptChatTemplate" /> class.
        /// </summary>
        public PromptChatTemplate()
        {
        }
    }
}