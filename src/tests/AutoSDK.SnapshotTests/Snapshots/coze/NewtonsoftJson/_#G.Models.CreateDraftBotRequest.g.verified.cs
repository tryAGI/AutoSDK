//HintName: G.Models.CreateDraftBotRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateDraftBotRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 头像文件id
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("icon_file_id")]
        public string? IconFileId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("media_config")]
        public global::G.PropertiesMediaConfig? MediaConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model_info_config")]
        public global::G.PropertiesModelInfoConfig? ModelInfoConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("onboarding_info")]
        public global::G.PropertiesOnboardingInfo? OnboardingInfo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("plugin_id_list")]
        public global::G.PropertiesPluginIdList? PluginIdList { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt_info")]
        public global::G.PropertiesPromptInfo? PromptInfo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("space_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string SpaceId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("suggest_reply_info")]
        public global::G.PropertiesSuggestReplyInfo? SuggestReplyInfo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("workflow_id_list")]
        public global::G.PropertiesWorkflowIdList? WorkflowIdList { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDraftBotRequest" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="spaceId"></param>
        /// <param name="description"></param>
        /// <param name="iconFileId">
        /// 头像文件id
        /// </param>
        /// <param name="mediaConfig"></param>
        /// <param name="modelInfoConfig"></param>
        /// <param name="onboardingInfo"></param>
        /// <param name="pluginIdList"></param>
        /// <param name="promptInfo"></param>
        /// <param name="suggestReplyInfo"></param>
        /// <param name="workflowIdList"></param>
        public CreateDraftBotRequest(
            string name,
            string spaceId,
            string? description,
            string? iconFileId,
            global::G.PropertiesMediaConfig? mediaConfig,
            global::G.PropertiesModelInfoConfig? modelInfoConfig,
            global::G.PropertiesOnboardingInfo? onboardingInfo,
            global::G.PropertiesPluginIdList? pluginIdList,
            global::G.PropertiesPromptInfo? promptInfo,
            global::G.PropertiesSuggestReplyInfo? suggestReplyInfo,
            global::G.PropertiesWorkflowIdList? workflowIdList)
        {
            this.Description = description;
            this.IconFileId = iconFileId;
            this.MediaConfig = mediaConfig;
            this.ModelInfoConfig = modelInfoConfig;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.OnboardingInfo = onboardingInfo;
            this.PluginIdList = pluginIdList;
            this.PromptInfo = promptInfo;
            this.SpaceId = spaceId ?? throw new global::System.ArgumentNullException(nameof(spaceId));
            this.SuggestReplyInfo = suggestReplyInfo;
            this.WorkflowIdList = workflowIdList;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDraftBotRequest" /> class.
        /// </summary>
        public CreateDraftBotRequest()
        {
        }
    }
}