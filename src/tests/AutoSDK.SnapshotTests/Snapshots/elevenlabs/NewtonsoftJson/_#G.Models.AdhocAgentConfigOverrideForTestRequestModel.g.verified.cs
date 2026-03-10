//HintName: G.Models.AdhocAgentConfigOverrideForTestRequestModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AdhocAgentConfigOverrideForTestRequestModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("conversation_config", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ConversationalConfigAPIModelInput ConversationConfig { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("platform_settings", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AgentPlatformSettingsRequestModel PlatformSettings { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("workflow")]
        public global::G.AgentWorkflowRequestModel? Workflow { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AdhocAgentConfigOverrideForTestRequestModel" /> class.
        /// </summary>
        /// <param name="conversationConfig"></param>
        /// <param name="platformSettings"></param>
        /// <param name="workflow"></param>
        public AdhocAgentConfigOverrideForTestRequestModel(
            global::G.ConversationalConfigAPIModelInput conversationConfig,
            global::G.AgentPlatformSettingsRequestModel platformSettings,
            global::G.AgentWorkflowRequestModel? workflow)
        {
            this.ConversationConfig = conversationConfig ?? throw new global::System.ArgumentNullException(nameof(conversationConfig));
            this.PlatformSettings = platformSettings ?? throw new global::System.ArgumentNullException(nameof(platformSettings));
            this.Workflow = workflow;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AdhocAgentConfigOverrideForTestRequestModel" /> class.
        /// </summary>
        public AdhocAgentConfigOverrideForTestRequestModel()
        {
        }
    }
}