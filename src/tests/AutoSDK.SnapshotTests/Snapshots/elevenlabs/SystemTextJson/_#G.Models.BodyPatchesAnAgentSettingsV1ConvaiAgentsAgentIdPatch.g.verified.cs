//HintName: G.Models.BodyPatchesAnAgentSettingsV1ConvaiAgentsAgentIdPatch.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyPatchesAnAgentSettingsV1ConvaiAgentsAgentIdPatch
    {
        /// <summary>
        /// Conversation configuration for an agent
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversation_config")]
        public object? ConversationConfig { get; set; }

        /// <summary>
        /// Platform settings for the agent are all settings that aren't related to the conversation orchestration and content.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("platform_settings")]
        public object? PlatformSettings { get; set; }

        /// <summary>
        /// A name to make the agent easier to find<br/>
        /// Example: My agent
        /// </summary>
        /// <example>My agent</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Tags to help classify and filter the agent<br/>
        /// Example: [Customer Support, Technical Help, Eleven]
        /// </summary>
        /// <example>[Customer Support, Technical Help, Eleven]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyPatchesAnAgentSettingsV1ConvaiAgentsAgentIdPatch" /> class.
        /// </summary>
        /// <param name="conversationConfig">
        /// Conversation configuration for an agent
        /// </param>
        /// <param name="platformSettings">
        /// Platform settings for the agent are all settings that aren't related to the conversation orchestration and content.
        /// </param>
        /// <param name="name">
        /// A name to make the agent easier to find<br/>
        /// Example: My agent
        /// </param>
        /// <param name="tags">
        /// Tags to help classify and filter the agent<br/>
        /// Example: [Customer Support, Technical Help, Eleven]
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BodyPatchesAnAgentSettingsV1ConvaiAgentsAgentIdPatch(
            object? conversationConfig,
            object? platformSettings,
            string? name,
            global::System.Collections.Generic.IList<string>? tags)
        {
            this.ConversationConfig = conversationConfig;
            this.PlatformSettings = platformSettings;
            this.Name = name;
            this.Tags = tags;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyPatchesAnAgentSettingsV1ConvaiAgentsAgentIdPatch" /> class.
        /// </summary>
        public BodyPatchesAnAgentSettingsV1ConvaiAgentsAgentIdPatch()
        {
        }
    }
}