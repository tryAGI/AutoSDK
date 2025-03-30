//HintName: G.Models.GetAgentResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetAgentResponseModel
    {
        /// <summary>
        /// The ID of the agent
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("agent_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string AgentId { get; set; } = default!;

        /// <summary>
        /// The name of the agent
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("conversation_config", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ConversationalConfigAPIModelOutput ConversationConfig { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AgentMetadataResponseModel Metadata { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("platform_settings")]
        public global::G.AgentPlatformSettingsResponseModel? PlatformSettings { get; set; }

        /// <summary>
        /// The phone numbers of the agent
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("phone_numbers")]
        public global::System.Collections.Generic.IList<global::G.GetPhoneNumberResponseModel>? PhoneNumbers { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAgentResponseModel" /> class.
        /// </summary>
        /// <param name="agentId">
        /// The ID of the agent
        /// </param>
        /// <param name="name">
        /// The name of the agent
        /// </param>
        /// <param name="conversationConfig"></param>
        /// <param name="metadata"></param>
        /// <param name="platformSettings"></param>
        /// <param name="phoneNumbers">
        /// The phone numbers of the agent
        /// </param>
        public GetAgentResponseModel(
            string agentId,
            string name,
            global::G.ConversationalConfigAPIModelOutput conversationConfig,
            global::G.AgentMetadataResponseModel metadata,
            global::G.AgentPlatformSettingsResponseModel? platformSettings,
            global::System.Collections.Generic.IList<global::G.GetPhoneNumberResponseModel>? phoneNumbers)
        {
            this.AgentId = agentId ?? throw new global::System.ArgumentNullException(nameof(agentId));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.ConversationConfig = conversationConfig ?? throw new global::System.ArgumentNullException(nameof(conversationConfig));
            this.Metadata = metadata ?? throw new global::System.ArgumentNullException(nameof(metadata));
            this.PlatformSettings = platformSettings;
            this.PhoneNumbers = phoneNumbers;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAgentResponseModel" /> class.
        /// </summary>
        public GetAgentResponseModel()
        {
        }
    }
}