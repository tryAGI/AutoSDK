//HintName: G.Models.ContentConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ContentConfig
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sexual")]
        public global::G.ThresholdGuardrail? Sexual { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("violence")]
        public global::G.ThresholdGuardrail? Violence { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("harassment")]
        public global::G.ThresholdGuardrail? Harassment { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("self_harm")]
        public global::G.ThresholdGuardrail? SelfHarm { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("profanity")]
        public global::G.ThresholdGuardrail? Profanity { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("religion_or_politics")]
        public global::G.ThresholdGuardrail? ReligionOrPolitics { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("medical_and_legal_information")]
        public global::G.ThresholdGuardrail? MedicalAndLegalInformation { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ContentConfig" /> class.
        /// </summary>
        /// <param name="sexual"></param>
        /// <param name="violence"></param>
        /// <param name="harassment"></param>
        /// <param name="selfHarm"></param>
        /// <param name="profanity"></param>
        /// <param name="religionOrPolitics"></param>
        /// <param name="medicalAndLegalInformation"></param>
        public ContentConfig(
            global::G.ThresholdGuardrail? sexual,
            global::G.ThresholdGuardrail? violence,
            global::G.ThresholdGuardrail? harassment,
            global::G.ThresholdGuardrail? selfHarm,
            global::G.ThresholdGuardrail? profanity,
            global::G.ThresholdGuardrail? religionOrPolitics,
            global::G.ThresholdGuardrail? medicalAndLegalInformation)
        {
            this.Sexual = sexual;
            this.Violence = violence;
            this.Harassment = harassment;
            this.SelfHarm = selfHarm;
            this.Profanity = profanity;
            this.ReligionOrPolitics = religionOrPolitics;
            this.MedicalAndLegalInformation = medicalAndLegalInformation;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContentConfig" /> class.
        /// </summary>
        public ContentConfig()
        {
        }
    }
}