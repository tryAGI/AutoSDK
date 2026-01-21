//HintName: G.Models.BodyCreateAgentV1ConvaiAgentsCreatePost.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyCreateAgentV1ConvaiAgentsCreatePost
    {
        /// <summary>
        /// Conversation configuration for an agent
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("conversation_config", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ConversationalConfigAPIModelInput ConversationConfig { get; set; } = default!;

        /// <summary>
        /// Platform settings for the agent are all settings that aren't related to the conversation orchestration and content.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("platform_settings")]
        public global::G.AgentPlatformSettingsRequestModel? PlatformSettings { get; set; }

        /// <summary>
        /// A name to make the agent easier to find
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Tags to help classify and filter the agent
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyCreateAgentV1ConvaiAgentsCreatePost" /> class.
        /// </summary>
        /// <param name="conversationConfig">
        /// Conversation configuration for an agent
        /// </param>
        /// <param name="platformSettings">
        /// Platform settings for the agent are all settings that aren't related to the conversation orchestration and content.
        /// </param>
        /// <param name="name">
        /// A name to make the agent easier to find
        /// </param>
        /// <param name="tags">
        /// Tags to help classify and filter the agent
        /// </param>
        public BodyCreateAgentV1ConvaiAgentsCreatePost(
            global::G.ConversationalConfigAPIModelInput conversationConfig,
            global::G.AgentPlatformSettingsRequestModel? platformSettings,
            string? name,
            global::System.Collections.Generic.IList<string>? tags)
        {
            this.ConversationConfig = conversationConfig ?? throw new global::System.ArgumentNullException(nameof(conversationConfig));
            this.PlatformSettings = platformSettings;
            this.Name = name;
            this.Tags = tags;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyCreateAgentV1ConvaiAgentsCreatePost" /> class.
        /// </summary>
        public BodyCreateAgentV1ConvaiAgentsCreatePost()
        {
        }
    }
}