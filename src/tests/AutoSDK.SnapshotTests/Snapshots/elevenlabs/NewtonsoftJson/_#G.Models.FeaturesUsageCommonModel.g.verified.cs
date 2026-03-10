//HintName: G.Models.FeaturesUsageCommonModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FeaturesUsageCommonModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("language_detection")]
        public global::G.FeatureStatusCommonModel? LanguageDetection { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("transfer_to_agent")]
        public global::G.FeatureStatusCommonModel? TransferToAgent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("transfer_to_number")]
        public global::G.FeatureStatusCommonModel? TransferToNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("multivoice")]
        public global::G.FeatureStatusCommonModel? Multivoice { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dtmf_tones")]
        public global::G.FeatureStatusCommonModel? DtmfTones { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("external_mcp_servers")]
        public global::G.FeatureStatusCommonModel? ExternalMcpServers { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pii_zrm_workspace")]
        public bool? PiiZrmWorkspace { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pii_zrm_agent")]
        public bool? PiiZrmAgent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tool_dynamic_variable_updates")]
        public global::G.FeatureStatusCommonModel? ToolDynamicVariableUpdates { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_livekit")]
        public bool? IsLivekit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("voicemail_detection")]
        public global::G.FeatureStatusCommonModel? VoicemailDetection { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("workflow")]
        public global::G.WorkflowFeaturesUsageCommonModel? Workflow { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("agent_testing")]
        public global::G.TestsFeatureUsageCommonModel? AgentTesting { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("versioning")]
        public global::G.FeatureStatusCommonModel? Versioning { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FeaturesUsageCommonModel" /> class.
        /// </summary>
        /// <param name="languageDetection"></param>
        /// <param name="transferToAgent"></param>
        /// <param name="transferToNumber"></param>
        /// <param name="multivoice"></param>
        /// <param name="dtmfTones"></param>
        /// <param name="externalMcpServers"></param>
        /// <param name="piiZrmWorkspace">
        /// Default Value: false
        /// </param>
        /// <param name="piiZrmAgent">
        /// Default Value: false
        /// </param>
        /// <param name="toolDynamicVariableUpdates"></param>
        /// <param name="isLivekit">
        /// Default Value: false
        /// </param>
        /// <param name="voicemailDetection"></param>
        /// <param name="workflow"></param>
        /// <param name="agentTesting"></param>
        /// <param name="versioning"></param>
        public FeaturesUsageCommonModel(
            global::G.FeatureStatusCommonModel? languageDetection,
            global::G.FeatureStatusCommonModel? transferToAgent,
            global::G.FeatureStatusCommonModel? transferToNumber,
            global::G.FeatureStatusCommonModel? multivoice,
            global::G.FeatureStatusCommonModel? dtmfTones,
            global::G.FeatureStatusCommonModel? externalMcpServers,
            bool? piiZrmWorkspace,
            bool? piiZrmAgent,
            global::G.FeatureStatusCommonModel? toolDynamicVariableUpdates,
            bool? isLivekit,
            global::G.FeatureStatusCommonModel? voicemailDetection,
            global::G.WorkflowFeaturesUsageCommonModel? workflow,
            global::G.TestsFeatureUsageCommonModel? agentTesting,
            global::G.FeatureStatusCommonModel? versioning)
        {
            this.LanguageDetection = languageDetection;
            this.TransferToAgent = transferToAgent;
            this.TransferToNumber = transferToNumber;
            this.Multivoice = multivoice;
            this.DtmfTones = dtmfTones;
            this.ExternalMcpServers = externalMcpServers;
            this.PiiZrmWorkspace = piiZrmWorkspace;
            this.PiiZrmAgent = piiZrmAgent;
            this.ToolDynamicVariableUpdates = toolDynamicVariableUpdates;
            this.IsLivekit = isLivekit;
            this.VoicemailDetection = voicemailDetection;
            this.Workflow = workflow;
            this.AgentTesting = agentTesting;
            this.Versioning = versioning;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FeaturesUsageCommonModel" /> class.
        /// </summary>
        public FeaturesUsageCommonModel()
        {
        }
    }
}