//HintName: G.Models.AgentSwapTool.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentSwapTool
    {
        /// <summary>
        /// Name of the tool. Must be unique within all tools available to LLM at any given time (general tools + state tools + state edges).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.AgentSwapToolType Type { get; set; }

        /// <summary>
        /// Describes what the tool does, sometimes can also include information about when to call the tool.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The id of the agent to swap to.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("agent_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string AgentId { get; set; } = default!;

        /// <summary>
        /// The version of the agent to swap to. If not specified, will use the latest version.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("agent_version")]
        public double? AgentVersion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("speak_during_execution")]
        public bool? SpeakDuringExecution { get; set; }

        /// <summary>
        /// The message for the agent to speak when executing agent swap.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("execution_message_description")]
        public string? ExecutionMessageDescription { get; set; }

        /// <summary>
        /// Type of execution message. "prompt" means the agent will use execution_message_description as a prompt to generate the message. "static_text" means the agent will speak the execution_message_description directly. Defaults to "prompt".
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("execution_message_type")]
        public global::G.AgentSwapToolExecutionMessageType? ExecutionMessageType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("post_call_analysis_setting", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.PostCallAnalysisSetting PostCallAnalysisSetting { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("webhook_setting")]
        public global::G.AgentSwapWebhookSetting? WebhookSetting { get; set; }

        /// <summary>
        /// If true, keep the current voice when swapping agents. Defaults to false.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("keep_current_voice")]
        public bool? KeepCurrentVoice { get; set; }

        /// <summary>
        /// If true, keep the current language when swapping agents. Defaults to false.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("keep_current_language")]
        public bool? KeepCurrentLanguage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentSwapTool" /> class.
        /// </summary>
        /// <param name="name">
        /// Name of the tool. Must be unique within all tools available to LLM at any given time (general tools + state tools + state edges).
        /// </param>
        /// <param name="agentId">
        /// The id of the agent to swap to.
        /// </param>
        /// <param name="postCallAnalysisSetting"></param>
        /// <param name="type"></param>
        /// <param name="description">
        /// Describes what the tool does, sometimes can also include information about when to call the tool.
        /// </param>
        /// <param name="agentVersion">
        /// The version of the agent to swap to. If not specified, will use the latest version.
        /// </param>
        /// <param name="speakDuringExecution"></param>
        /// <param name="executionMessageDescription">
        /// The message for the agent to speak when executing agent swap.
        /// </param>
        /// <param name="executionMessageType">
        /// Type of execution message. "prompt" means the agent will use execution_message_description as a prompt to generate the message. "static_text" means the agent will speak the execution_message_description directly. Defaults to "prompt".
        /// </param>
        /// <param name="webhookSetting"></param>
        /// <param name="keepCurrentVoice">
        /// If true, keep the current voice when swapping agents. Defaults to false.
        /// </param>
        /// <param name="keepCurrentLanguage">
        /// If true, keep the current language when swapping agents. Defaults to false.
        /// </param>
        public AgentSwapTool(
            string name,
            string agentId,
            global::G.PostCallAnalysisSetting postCallAnalysisSetting,
            global::G.AgentSwapToolType type,
            string? description,
            double? agentVersion,
            bool? speakDuringExecution,
            string? executionMessageDescription,
            global::G.AgentSwapToolExecutionMessageType? executionMessageType,
            global::G.AgentSwapWebhookSetting? webhookSetting,
            bool? keepCurrentVoice,
            bool? keepCurrentLanguage)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Type = type;
            this.Description = description;
            this.AgentId = agentId ?? throw new global::System.ArgumentNullException(nameof(agentId));
            this.AgentVersion = agentVersion;
            this.SpeakDuringExecution = speakDuringExecution;
            this.ExecutionMessageDescription = executionMessageDescription;
            this.ExecutionMessageType = executionMessageType;
            this.PostCallAnalysisSetting = postCallAnalysisSetting;
            this.WebhookSetting = webhookSetting;
            this.KeepCurrentVoice = keepCurrentVoice;
            this.KeepCurrentLanguage = keepCurrentLanguage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentSwapTool" /> class.
        /// </summary>
        public AgentSwapTool()
        {
        }
    }
}