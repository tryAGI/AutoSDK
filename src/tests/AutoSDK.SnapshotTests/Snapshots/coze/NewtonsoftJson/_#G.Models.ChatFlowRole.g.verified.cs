//HintName: G.Models.ChatFlowRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatFlowRole
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("audio_config")]
        public global::G.AudioConfig? AudioConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("avatar")]
        public global::G.AvatarConfig? Avatar { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("background_image_info")]
        public global::G.BackgroundImageInfo? BackgroundImageInfo { get; set; }

        /// <summary>
        /// 渠道ID
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("connector_id")]
        public string? ConnectorId { get; set; }

        /// <summary>
        /// 角色描述
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 角色名称
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("onboarding_info")]
        public global::G.OnboardingInfo? OnboardingInfo { get; set; }

        /// <summary>
        /// 项目版本
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project_version")]
        public string? ProjectVersion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("suggest_reply_info")]
        public global::G.SuggestReplyInfo1? SuggestReplyInfo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user_input_config")]
        public global::G.UserInputConfig? UserInputConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("workflow_id")]
        public string? WorkflowId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatFlowRole" /> class.
        /// </summary>
        /// <param name="audioConfig"></param>
        /// <param name="avatar"></param>
        /// <param name="backgroundImageInfo"></param>
        /// <param name="connectorId">
        /// 渠道ID
        /// </param>
        /// <param name="description">
        /// 角色描述
        /// </param>
        /// <param name="id"></param>
        /// <param name="name">
        /// 角色名称
        /// </param>
        /// <param name="onboardingInfo"></param>
        /// <param name="projectVersion">
        /// 项目版本
        /// </param>
        /// <param name="suggestReplyInfo"></param>
        /// <param name="userInputConfig"></param>
        /// <param name="workflowId"></param>
        public ChatFlowRole(
            global::G.AudioConfig? audioConfig,
            global::G.AvatarConfig? avatar,
            global::G.BackgroundImageInfo? backgroundImageInfo,
            string? connectorId,
            string? description,
            string? id,
            string? name,
            global::G.OnboardingInfo? onboardingInfo,
            string? projectVersion,
            global::G.SuggestReplyInfo1? suggestReplyInfo,
            global::G.UserInputConfig? userInputConfig,
            string? workflowId)
        {
            this.AudioConfig = audioConfig;
            this.Avatar = avatar;
            this.BackgroundImageInfo = backgroundImageInfo;
            this.ConnectorId = connectorId;
            this.Description = description;
            this.Id = id;
            this.Name = name;
            this.OnboardingInfo = onboardingInfo;
            this.ProjectVersion = projectVersion;
            this.SuggestReplyInfo = suggestReplyInfo;
            this.UserInputConfig = userInputConfig;
            this.WorkflowId = workflowId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatFlowRole" /> class.
        /// </summary>
        public ChatFlowRole()
        {
        }
    }
}