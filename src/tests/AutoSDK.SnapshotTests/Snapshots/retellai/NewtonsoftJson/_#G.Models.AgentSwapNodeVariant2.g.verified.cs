//HintName: G.Models.AgentSwapNodeVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentSwapNodeVariant2
    {
        /// <summary>
        /// Type of the node
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.AgentSwapNodeVariant2Type Type { get; set; }

        /// <summary>
        /// The ID of the agent to swap to
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("agent_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string AgentId { get; set; } = default!;

        /// <summary>
        /// The version of the agent to swap to. If not specified, will use the latest version
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("agent_version")]
        public double? AgentVersion { get; set; }

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
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("edge", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.TransferFailedEdge Edge { get; set; } = default!;

        /// <summary>
        /// If true, will speak during execution
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("speak_during_execution")]
        public bool? SpeakDuringExecution { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("instruction")]
        public global::G.NodeInstruction? Instruction { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentSwapNodeVariant2" /> class.
        /// </summary>
        /// <param name="agentId">
        /// The ID of the agent to swap to
        /// </param>
        /// <param name="postCallAnalysisSetting"></param>
        /// <param name="edge"></param>
        /// <param name="type">
        /// Type of the node
        /// </param>
        /// <param name="agentVersion">
        /// The version of the agent to swap to. If not specified, will use the latest version
        /// </param>
        /// <param name="webhookSetting"></param>
        /// <param name="keepCurrentVoice">
        /// If true, keep the current voice when swapping agents. Defaults to false.
        /// </param>
        /// <param name="keepCurrentLanguage">
        /// If true, keep the current language when swapping agents. Defaults to false.
        /// </param>
        /// <param name="speakDuringExecution">
        /// If true, will speak during execution
        /// </param>
        /// <param name="instruction"></param>
        public AgentSwapNodeVariant2(
            string agentId,
            global::G.PostCallAnalysisSetting postCallAnalysisSetting,
            global::G.TransferFailedEdge edge,
            global::G.AgentSwapNodeVariant2Type type,
            double? agentVersion,
            global::G.AgentSwapWebhookSetting? webhookSetting,
            bool? keepCurrentVoice,
            bool? keepCurrentLanguage,
            bool? speakDuringExecution,
            global::G.NodeInstruction? instruction)
        {
            this.Type = type;
            this.AgentId = agentId ?? throw new global::System.ArgumentNullException(nameof(agentId));
            this.AgentVersion = agentVersion;
            this.PostCallAnalysisSetting = postCallAnalysisSetting;
            this.WebhookSetting = webhookSetting;
            this.KeepCurrentVoice = keepCurrentVoice;
            this.KeepCurrentLanguage = keepCurrentLanguage;
            this.Edge = edge;
            this.SpeakDuringExecution = speakDuringExecution;
            this.Instruction = instruction;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentSwapNodeVariant2" /> class.
        /// </summary>
        public AgentSwapNodeVariant2()
        {
        }
    }
}