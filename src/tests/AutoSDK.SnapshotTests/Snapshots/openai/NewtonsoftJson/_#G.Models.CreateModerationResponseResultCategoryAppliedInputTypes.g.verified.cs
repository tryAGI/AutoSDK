//HintName: G.Models.CreateModerationResponseResultCategoryAppliedInputTypes.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A list of the categories along with the input type(s) that the score applies to.
    /// </summary>
    public sealed partial class CreateModerationResponseResultCategoryAppliedInputTypes
    {
        /// <summary>
        /// The applied input type(s) for the category 'hate'.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("hate", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.CreateModerationResponseResultCategoryAppliedInputTypesHateItem> Hate { get; set; } = default!;

        /// <summary>
        /// The applied input type(s) for the category 'hate/threatening'.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("hate/threatening", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.CreateModerationResponseResultCategoryAppliedInputTypesHateThreateningItem> HateThreatening { get; set; } = default!;

        /// <summary>
        /// The applied input type(s) for the category 'harassment'.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("harassment", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.CreateModerationResponseResultCategoryAppliedInputTypesHarassmentItem> Harassment { get; set; } = default!;

        /// <summary>
        /// The applied input type(s) for the category 'harassment/threatening'.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("harassment/threatening", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.CreateModerationResponseResultCategoryAppliedInputTypesHarassmentThreateningItem> HarassmentThreatening { get; set; } = default!;

        /// <summary>
        /// The applied input type(s) for the category 'illicit'.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("illicit", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.CreateModerationResponseResultCategoryAppliedInputTypesIllicitItem> Illicit { get; set; } = default!;

        /// <summary>
        /// The applied input type(s) for the category 'illicit/violent'.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("illicit/violent", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.CreateModerationResponseResultCategoryAppliedInputTypesIllicitViolentItem> IllicitViolent { get; set; } = default!;

        /// <summary>
        /// The applied input type(s) for the category 'self-harm'.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("self-harm", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.CreateModerationResponseResultCategoryAppliedInputTypesSelfHarmItem> SelfHarm { get; set; } = default!;

        /// <summary>
        /// The applied input type(s) for the category 'self-harm/intent'.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("self-harm/intent", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.CreateModerationResponseResultCategoryAppliedInputTypesSelfHarmIntentItem> SelfHarmIntent { get; set; } = default!;

        /// <summary>
        /// The applied input type(s) for the category 'self-harm/instructions'.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("self-harm/instructions", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.CreateModerationResponseResultCategoryAppliedInputTypesSelfHarmInstruction> SelfHarmInstructions { get; set; } = default!;

        /// <summary>
        /// The applied input type(s) for the category 'sexual'.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sexual", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.CreateModerationResponseResultCategoryAppliedInputTypesSexualItem> Sexual { get; set; } = default!;

        /// <summary>
        /// The applied input type(s) for the category 'sexual/minors'.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sexual/minors", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.CreateModerationResponseResultCategoryAppliedInputTypesSexualMinor> SexualMinors { get; set; } = default!;

        /// <summary>
        /// The applied input type(s) for the category 'violence'.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("violence", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.CreateModerationResponseResultCategoryAppliedInputTypesViolenceItem> Violence { get; set; } = default!;

        /// <summary>
        /// The applied input type(s) for the category 'violence/graphic'.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("violence/graphic", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.CreateModerationResponseResultCategoryAppliedInputTypesViolenceGraphicItem> ViolenceGraphic { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateModerationResponseResultCategoryAppliedInputTypes" /> class.
        /// </summary>
        /// <param name="hate">
        /// The applied input type(s) for the category 'hate'.
        /// </param>
        /// <param name="hateThreatening">
        /// The applied input type(s) for the category 'hate/threatening'.
        /// </param>
        /// <param name="harassment">
        /// The applied input type(s) for the category 'harassment'.
        /// </param>
        /// <param name="harassmentThreatening">
        /// The applied input type(s) for the category 'harassment/threatening'.
        /// </param>
        /// <param name="illicit">
        /// The applied input type(s) for the category 'illicit'.
        /// </param>
        /// <param name="illicitViolent">
        /// The applied input type(s) for the category 'illicit/violent'.
        /// </param>
        /// <param name="selfHarm">
        /// The applied input type(s) for the category 'self-harm'.
        /// </param>
        /// <param name="selfHarmIntent">
        /// The applied input type(s) for the category 'self-harm/intent'.
        /// </param>
        /// <param name="selfHarmInstructions">
        /// The applied input type(s) for the category 'self-harm/instructions'.
        /// </param>
        /// <param name="sexual">
        /// The applied input type(s) for the category 'sexual'.
        /// </param>
        /// <param name="sexualMinors">
        /// The applied input type(s) for the category 'sexual/minors'.
        /// </param>
        /// <param name="violence">
        /// The applied input type(s) for the category 'violence'.
        /// </param>
        /// <param name="violenceGraphic">
        /// The applied input type(s) for the category 'violence/graphic'.
        /// </param>
        public CreateModerationResponseResultCategoryAppliedInputTypes(
            global::System.Collections.Generic.IList<global::G.CreateModerationResponseResultCategoryAppliedInputTypesHateItem> hate,
            global::System.Collections.Generic.IList<global::G.CreateModerationResponseResultCategoryAppliedInputTypesHateThreateningItem> hateThreatening,
            global::System.Collections.Generic.IList<global::G.CreateModerationResponseResultCategoryAppliedInputTypesHarassmentItem> harassment,
            global::System.Collections.Generic.IList<global::G.CreateModerationResponseResultCategoryAppliedInputTypesHarassmentThreateningItem> harassmentThreatening,
            global::System.Collections.Generic.IList<global::G.CreateModerationResponseResultCategoryAppliedInputTypesIllicitItem> illicit,
            global::System.Collections.Generic.IList<global::G.CreateModerationResponseResultCategoryAppliedInputTypesIllicitViolentItem> illicitViolent,
            global::System.Collections.Generic.IList<global::G.CreateModerationResponseResultCategoryAppliedInputTypesSelfHarmItem> selfHarm,
            global::System.Collections.Generic.IList<global::G.CreateModerationResponseResultCategoryAppliedInputTypesSelfHarmIntentItem> selfHarmIntent,
            global::System.Collections.Generic.IList<global::G.CreateModerationResponseResultCategoryAppliedInputTypesSelfHarmInstruction> selfHarmInstructions,
            global::System.Collections.Generic.IList<global::G.CreateModerationResponseResultCategoryAppliedInputTypesSexualItem> sexual,
            global::System.Collections.Generic.IList<global::G.CreateModerationResponseResultCategoryAppliedInputTypesSexualMinor> sexualMinors,
            global::System.Collections.Generic.IList<global::G.CreateModerationResponseResultCategoryAppliedInputTypesViolenceItem> violence,
            global::System.Collections.Generic.IList<global::G.CreateModerationResponseResultCategoryAppliedInputTypesViolenceGraphicItem> violenceGraphic)
        {
            this.Hate = hate ?? throw new global::System.ArgumentNullException(nameof(hate));
            this.HateThreatening = hateThreatening ?? throw new global::System.ArgumentNullException(nameof(hateThreatening));
            this.Harassment = harassment ?? throw new global::System.ArgumentNullException(nameof(harassment));
            this.HarassmentThreatening = harassmentThreatening ?? throw new global::System.ArgumentNullException(nameof(harassmentThreatening));
            this.Illicit = illicit ?? throw new global::System.ArgumentNullException(nameof(illicit));
            this.IllicitViolent = illicitViolent ?? throw new global::System.ArgumentNullException(nameof(illicitViolent));
            this.SelfHarm = selfHarm ?? throw new global::System.ArgumentNullException(nameof(selfHarm));
            this.SelfHarmIntent = selfHarmIntent ?? throw new global::System.ArgumentNullException(nameof(selfHarmIntent));
            this.SelfHarmInstructions = selfHarmInstructions ?? throw new global::System.ArgumentNullException(nameof(selfHarmInstructions));
            this.Sexual = sexual ?? throw new global::System.ArgumentNullException(nameof(sexual));
            this.SexualMinors = sexualMinors ?? throw new global::System.ArgumentNullException(nameof(sexualMinors));
            this.Violence = violence ?? throw new global::System.ArgumentNullException(nameof(violence));
            this.ViolenceGraphic = violenceGraphic ?? throw new global::System.ArgumentNullException(nameof(violenceGraphic));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateModerationResponseResultCategoryAppliedInputTypes" /> class.
        /// </summary>
        public CreateModerationResponseResultCategoryAppliedInputTypes()
        {
        }
    }
}