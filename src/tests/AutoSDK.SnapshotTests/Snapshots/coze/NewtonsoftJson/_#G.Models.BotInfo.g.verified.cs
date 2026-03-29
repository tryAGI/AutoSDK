//HintName: G.Models.BotInfo.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BotInfo
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("background_image_info")]
        public global::G.BackgroundImageInfo1? BackgroundImageInfo { get; set; }

        /// <summary>
        /// bot id
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("bot_id")]
        public string? BotId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("bot_mode")]
        public int? BotMode { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("create_time")]
        public int? CreateTime { get; set; }

        /// <summary>
        /// 默认用户输入类型
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("default_user_input_type")]
        public string? DefaultUserInputType { get; set; }

        /// <summary>
        /// bot描述
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// bot图像url
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("icon_url")]
        public string? IconUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("knowledge")]
        public global::G.CommonKnowledge? Knowledge { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model_info")]
        public global::G.ModelInfo? ModelInfo { get; set; }

        /// <summary>
        /// bot名称
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("onboarding_info")]
        public global::G.OnboardingInfoV2? OnboardingInfo { get; set; }

        /// <summary>
        /// owner_id
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("owner_user_id")]
        public string? OwnerUserId { get; set; }

        /// <summary>
        /// 插件信息列表
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("plugin_info_list")]
        public global::System.Collections.Generic.IList<global::G.PluginInfo>? PluginInfoList { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt_info")]
        public global::G.PromptInfo? PromptInfo { get; set; }

        /// <summary>
        /// 快捷指令信息列表
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("shortcut_commands")]
        public global::System.Collections.Generic.IList<global::G.ShortcutCommandInfo>? ShortcutCommands { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("update_time")]
        public int? UpdateTime { get; set; }

        /// <summary>
        /// 变量列表
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("variables")]
        public global::System.Collections.Generic.IList<global::G.Variable>? Variables { get; set; }

        /// <summary>
        /// 版本
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("version")]
        public string? Version { get; set; }

        /// <summary>
        /// 音色配置
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("voice_info_list")]
        public global::System.Collections.Generic.IList<global::G.Voice>? VoiceInfoList { get; set; }

        /// <summary>
        /// workflow信息列表
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("workflow_info_list")]
        public global::System.Collections.Generic.IList<global::G.WorkflowInfo>? WorkflowInfoList { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BotInfo" /> class.
        /// </summary>
        /// <param name="backgroundImageInfo"></param>
        /// <param name="botId">
        /// bot id
        /// </param>
        /// <param name="botMode"></param>
        /// <param name="createTime">
        /// 创建时间
        /// </param>
        /// <param name="defaultUserInputType">
        /// 默认用户输入类型
        /// </param>
        /// <param name="description">
        /// bot描述
        /// </param>
        /// <param name="iconUrl">
        /// bot图像url
        /// </param>
        /// <param name="knowledge"></param>
        /// <param name="modelInfo"></param>
        /// <param name="name">
        /// bot名称
        /// </param>
        /// <param name="onboardingInfo"></param>
        /// <param name="ownerUserId">
        /// owner_id
        /// </param>
        /// <param name="pluginInfoList">
        /// 插件信息列表
        /// </param>
        /// <param name="promptInfo"></param>
        /// <param name="shortcutCommands">
        /// 快捷指令信息列表
        /// </param>
        /// <param name="updateTime">
        /// 更新时间
        /// </param>
        /// <param name="variables">
        /// 变量列表
        /// </param>
        /// <param name="version">
        /// 版本
        /// </param>
        /// <param name="voiceInfoList">
        /// 音色配置
        /// </param>
        /// <param name="workflowInfoList">
        /// workflow信息列表
        /// </param>
        public BotInfo(
            global::G.BackgroundImageInfo1? backgroundImageInfo,
            string? botId,
            int? botMode,
            int? createTime,
            string? defaultUserInputType,
            string? description,
            string? iconUrl,
            global::G.CommonKnowledge? knowledge,
            global::G.ModelInfo? modelInfo,
            string? name,
            global::G.OnboardingInfoV2? onboardingInfo,
            string? ownerUserId,
            global::System.Collections.Generic.IList<global::G.PluginInfo>? pluginInfoList,
            global::G.PromptInfo? promptInfo,
            global::System.Collections.Generic.IList<global::G.ShortcutCommandInfo>? shortcutCommands,
            int? updateTime,
            global::System.Collections.Generic.IList<global::G.Variable>? variables,
            string? version,
            global::System.Collections.Generic.IList<global::G.Voice>? voiceInfoList,
            global::System.Collections.Generic.IList<global::G.WorkflowInfo>? workflowInfoList)
        {
            this.BackgroundImageInfo = backgroundImageInfo;
            this.BotId = botId;
            this.BotMode = botMode;
            this.CreateTime = createTime;
            this.DefaultUserInputType = defaultUserInputType;
            this.Description = description;
            this.IconUrl = iconUrl;
            this.Knowledge = knowledge;
            this.ModelInfo = modelInfo;
            this.Name = name;
            this.OnboardingInfo = onboardingInfo;
            this.OwnerUserId = ownerUserId;
            this.PluginInfoList = pluginInfoList;
            this.PromptInfo = promptInfo;
            this.ShortcutCommands = shortcutCommands;
            this.UpdateTime = updateTime;
            this.Variables = variables;
            this.Version = version;
            this.VoiceInfoList = voiceInfoList;
            this.WorkflowInfoList = workflowInfoList;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BotInfo" /> class.
        /// </summary>
        public BotInfo()
        {
        }
    }
}