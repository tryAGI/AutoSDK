//HintName: G.Models.ModerationConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ModerationConfig
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
        [global::Newtonsoft.Json.JsonProperty("violence_graphic")]
        public global::G.ThresholdGuardrail? ViolenceGraphic { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("harassment")]
        public global::G.ThresholdGuardrail? Harassment { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("harassment_threatening")]
        public global::G.ThresholdGuardrail? HarassmentThreatening { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("hate")]
        public global::G.ThresholdGuardrail? Hate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("hate_threatening")]
        public global::G.ThresholdGuardrail? HateThreatening { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("self_harm_instructions")]
        public global::G.ThresholdGuardrail? SelfHarmInstructions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("self_harm")]
        public global::G.ThresholdGuardrail? SelfHarm { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("self_harm_intent")]
        public global::G.ThresholdGuardrail? SelfHarmIntent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sexual_minors")]
        public global::G.ThresholdGuardrail? SexualMinors { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModerationConfig" /> class.
        /// </summary>
        /// <param name="sexual"></param>
        /// <param name="violence"></param>
        /// <param name="violenceGraphic"></param>
        /// <param name="harassment"></param>
        /// <param name="harassmentThreatening"></param>
        /// <param name="hate"></param>
        /// <param name="hateThreatening"></param>
        /// <param name="selfHarmInstructions"></param>
        /// <param name="selfHarm"></param>
        /// <param name="selfHarmIntent"></param>
        /// <param name="sexualMinors"></param>
        public ModerationConfig(
            global::G.ThresholdGuardrail? sexual,
            global::G.ThresholdGuardrail? violence,
            global::G.ThresholdGuardrail? violenceGraphic,
            global::G.ThresholdGuardrail? harassment,
            global::G.ThresholdGuardrail? harassmentThreatening,
            global::G.ThresholdGuardrail? hate,
            global::G.ThresholdGuardrail? hateThreatening,
            global::G.ThresholdGuardrail? selfHarmInstructions,
            global::G.ThresholdGuardrail? selfHarm,
            global::G.ThresholdGuardrail? selfHarmIntent,
            global::G.ThresholdGuardrail? sexualMinors)
        {
            this.Sexual = sexual;
            this.Violence = violence;
            this.ViolenceGraphic = violenceGraphic;
            this.Harassment = harassment;
            this.HarassmentThreatening = harassmentThreatening;
            this.Hate = hate;
            this.HateThreatening = hateThreatening;
            this.SelfHarmInstructions = selfHarmInstructions;
            this.SelfHarm = selfHarm;
            this.SelfHarmIntent = selfHarmIntent;
            this.SexualMinors = sexualMinors;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModerationConfig" /> class.
        /// </summary>
        public ModerationConfig()
        {
        }
    }
}