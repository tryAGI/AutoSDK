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
        [global::System.Text.Json.Serialization.JsonPropertyName("hate")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.CreateModerationResponseResultCategoryAppliedInputTypesHateItem> Hate { get; set; }

        /// <summary>
        /// The applied input type(s) for the category 'hate/threatening'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hate/threatening")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.CreateModerationResponseResultCategoryAppliedInputTypesHateThreateningItem> HateThreatening { get; set; }

        /// <summary>
        /// The applied input type(s) for the category 'harassment'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("harassment")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.CreateModerationResponseResultCategoryAppliedInputTypesHarassmentItem> Harassment { get; set; }

        /// <summary>
        /// The applied input type(s) for the category 'harassment/threatening'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("harassment/threatening")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.CreateModerationResponseResultCategoryAppliedInputTypesHarassmentThreateningItem> HarassmentThreatening { get; set; }

        /// <summary>
        /// The applied input type(s) for the category 'illicit'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("illicit")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.CreateModerationResponseResultCategoryAppliedInputTypesIllicitItem> Illicit { get; set; }

        /// <summary>
        /// The applied input type(s) for the category 'illicit/violent'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("illicit/violent")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.CreateModerationResponseResultCategoryAppliedInputTypesIllicitViolentItem> IllicitViolent { get; set; }

        /// <summary>
        /// The applied input type(s) for the category 'self-harm'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("self-harm")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.CreateModerationResponseResultCategoryAppliedInputTypesSelfHarmItem> SelfHarm { get; set; }

        /// <summary>
        /// The applied input type(s) for the category 'self-harm/intent'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("self-harm/intent")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.CreateModerationResponseResultCategoryAppliedInputTypesSelfHarmIntentItem> SelfHarmIntent { get; set; }

        /// <summary>
        /// The applied input type(s) for the category 'self-harm/instructions'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("self-harm/instructions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.CreateModerationResponseResultCategoryAppliedInputTypesSelfHarmInstruction> SelfHarmInstructions { get; set; }

        /// <summary>
        /// The applied input type(s) for the category 'sexual'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sexual")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.CreateModerationResponseResultCategoryAppliedInputTypesSexualItem> Sexual { get; set; }

        /// <summary>
        /// The applied input type(s) for the category 'sexual/minors'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sexual/minors")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.CreateModerationResponseResultCategoryAppliedInputTypesSexualMinor> SexualMinors { get; set; }

        /// <summary>
        /// The applied input type(s) for the category 'violence'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("violence")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.CreateModerationResponseResultCategoryAppliedInputTypesViolenceItem> Violence { get; set; }

        /// <summary>
        /// The applied input type(s) for the category 'violence/graphic'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("violence/graphic")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.CreateModerationResponseResultCategoryAppliedInputTypesViolenceGraphicItem> ViolenceGraphic { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
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