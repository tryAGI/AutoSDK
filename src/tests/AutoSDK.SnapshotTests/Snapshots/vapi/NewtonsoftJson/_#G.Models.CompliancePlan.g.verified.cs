//HintName: G.Models.CompliancePlan.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CompliancePlan
    {
        /// <summary>
        /// When this is enabled, logs, recordings, and transcriptions will be stored in HIPAA-compliant storage. Defaults to false. Only HIPAA-compliant providers will be available for LLM, Voice, and Transcriber respectively. This setting is only honored if the organization is on an Enterprise subscription or has purchased the HIPAA add-on.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("hipaaEnabled")]
        public bool? HipaaEnabled { get; set; }

        /// <summary>
        /// When this is enabled, the user will be restricted to use PCI-compliant providers, and no logs or transcripts are stored.<br/>
        /// At the end of the call, you will receive an end-of-call-report message to store on your server. Defaults to false.<br/>
        /// Example: {"pciEnabled":false}
        /// </summary>
        /// <example>{"pciEnabled":false}</example>
        [global::Newtonsoft.Json.JsonProperty("pciEnabled")]
        public bool? PciEnabled { get; set; }

        /// <summary>
        /// This is the security filter plan for the assistant. It allows filtering of transcripts for security threats before sending to LLM.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("securityFilterPlan")]
        public global::G.SecurityFilterPlan? SecurityFilterPlan { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("recordingConsentPlan")]
        public global::G.RecordingConsentPlan? RecordingConsentPlan { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CompliancePlan" /> class.
        /// </summary>
        /// <param name="hipaaEnabled">
        /// When this is enabled, logs, recordings, and transcriptions will be stored in HIPAA-compliant storage. Defaults to false. Only HIPAA-compliant providers will be available for LLM, Voice, and Transcriber respectively. This setting is only honored if the organization is on an Enterprise subscription or has purchased the HIPAA add-on.
        /// </param>
        /// <param name="pciEnabled">
        /// When this is enabled, the user will be restricted to use PCI-compliant providers, and no logs or transcripts are stored.<br/>
        /// At the end of the call, you will receive an end-of-call-report message to store on your server. Defaults to false.<br/>
        /// Example: {"pciEnabled":false}
        /// </param>
        /// <param name="securityFilterPlan">
        /// This is the security filter plan for the assistant. It allows filtering of transcripts for security threats before sending to LLM.
        /// </param>
        /// <param name="recordingConsentPlan"></param>
        public CompliancePlan(
            bool? hipaaEnabled,
            bool? pciEnabled,
            global::G.SecurityFilterPlan? securityFilterPlan,
            global::G.RecordingConsentPlan? recordingConsentPlan)
        {
            this.HipaaEnabled = hipaaEnabled;
            this.PciEnabled = pciEnabled;
            this.SecurityFilterPlan = securityFilterPlan;
            this.RecordingConsentPlan = recordingConsentPlan;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CompliancePlan" /> class.
        /// </summary>
        public CompliancePlan()
        {
        }
    }
}