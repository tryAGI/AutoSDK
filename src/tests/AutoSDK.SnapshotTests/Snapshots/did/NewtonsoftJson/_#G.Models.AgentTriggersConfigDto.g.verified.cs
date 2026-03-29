//HintName: G.Models.AgentTriggersConfigDto.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentTriggersConfigDto
    {
        /// <summary>
        /// Configuration triggered when a chat session ends.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("chat/end")]
        public global::G.AgentTriggersConfigDtoChatEnd? ChatEnd { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentTriggersConfigDto" /> class.
        /// </summary>
        /// <param name="chatEnd">
        /// Configuration triggered when a chat session ends.
        /// </param>
        public AgentTriggersConfigDto(
            global::G.AgentTriggersConfigDtoChatEnd? chatEnd)
        {
            this.ChatEnd = chatEnd;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentTriggersConfigDto" /> class.
        /// </summary>
        public AgentTriggersConfigDto()
        {
        }
    }
}