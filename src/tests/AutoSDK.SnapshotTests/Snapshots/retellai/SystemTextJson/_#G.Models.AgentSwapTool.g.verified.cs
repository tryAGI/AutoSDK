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
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AgentSwapToolTypeJsonConverter))]
        public global::G.AgentSwapToolType Type { get; set; }

        /// <summary>
        /// Describes what the tool does, sometimes can also include information about when to call the tool.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The id of the agent to swap to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AgentId { get; set; }

        /// <summary>
        /// The version of the agent to swap to. If not specified, will use the latest version.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_version")]
        public double? AgentVersion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speak_during_execution")]
        public bool? SpeakDuringExecution { get; set; }

        /// <summary>
        /// The message for the agent to speak when executing agent swap.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("execution_message_description")]
        public string? ExecutionMessageDescription { get; set; }

        /// <summary>
        /// Type of execution message. "prompt" means the agent will use execution_message_description as a prompt to generate the message. "static_text" means the agent will speak the execution_message_description directly. Defaults to "prompt".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("execution_message_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AgentSwapToolExecutionMessageTypeJsonConverter))]
        public global::G.AgentSwapToolExecutionMessageType? ExecutionMessageType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("post_call_analysis_setting")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.PostCallAnalysisSettingJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.PostCallAnalysisSetting PostCallAnalysisSetting { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook_setting")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AgentSwapWebhookSettingJsonConverter))]
        public global::G.AgentSwapWebhookSetting? WebhookSetting { get; set; }

        /// <summary>
        /// If true, keep the current voice when swapping agents. Defaults to false.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("keep_current_voice")]
        public bool? KeepCurrentVoice { get; set; }

        /// <summary>
        /// If true, keep the current language when swapping agents. Defaults to false.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("keep_current_language")]
        public bool? KeepCurrentLanguage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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