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
        /// <param name="piiZrmWorkspace">
        /// Default Value: false
        /// </param>
        /// <param name="piiZrmAgent">
        /// Default Value: false
        /// </param>
        public FeaturesUsageCommonModel(
            global::G.FeatureStatusCommonModel? languageDetection,
            global::G.FeatureStatusCommonModel? transferToAgent,
            global::G.FeatureStatusCommonModel? transferToNumber,
            global::G.FeatureStatusCommonModel? multivoice,
            bool? piiZrmWorkspace,
            bool? piiZrmAgent)
        {
            this.LanguageDetection = languageDetection;
            this.TransferToAgent = transferToAgent;
            this.TransferToNumber = transferToNumber;
            this.Multivoice = multivoice;
            this.PiiZrmWorkspace = piiZrmWorkspace;
            this.PiiZrmAgent = piiZrmAgent;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FeaturesUsageCommonModel" /> class.
        /// </summary>
        public FeaturesUsageCommonModel()
        {
        }
    }
}