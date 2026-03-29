//HintName: G.Models.CreateModerationResponseResultCategoryScores.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A list of the categories along with their scores as predicted by model.
    /// </summary>
    public sealed partial class CreateModerationResponseResultCategoryScores
    {
        /// <summary>
        /// The score for the category 'hate'.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("hate", Required = global::Newtonsoft.Json.Required.Always)]
        public double Hate { get; set; } = default!;

        /// <summary>
        /// The score for the category 'hate/threatening'.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("hate/threatening", Required = global::Newtonsoft.Json.Required.Always)]
        public double HateThreatening { get; set; } = default!;

        /// <summary>
        /// The score for the category 'harassment'.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("harassment", Required = global::Newtonsoft.Json.Required.Always)]
        public double Harassment { get; set; } = default!;

        /// <summary>
        /// The score for the category 'harassment/threatening'.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("harassment/threatening", Required = global::Newtonsoft.Json.Required.Always)]
        public double HarassmentThreatening { get; set; } = default!;

        /// <summary>
        /// The score for the category 'self-harm'.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("self-harm", Required = global::Newtonsoft.Json.Required.Always)]
        public double SelfHarm { get; set; } = default!;

        /// <summary>
        /// The score for the category 'self-harm/intent'.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("self-harm/intent", Required = global::Newtonsoft.Json.Required.Always)]
        public double SelfHarmIntent { get; set; } = default!;

        /// <summary>
        /// The score for the category 'self-harm/instructions'.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("self-harm/instructions", Required = global::Newtonsoft.Json.Required.Always)]
        public double SelfHarmInstructions { get; set; } = default!;

        /// <summary>
        /// The score for the category 'sexual'.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sexual", Required = global::Newtonsoft.Json.Required.Always)]
        public double Sexual { get; set; } = default!;

        /// <summary>
        /// The score for the category 'sexual/minors'.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sexual/minors", Required = global::Newtonsoft.Json.Required.Always)]
        public double SexualMinors { get; set; } = default!;

        /// <summary>
        /// The score for the category 'violence'.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("violence", Required = global::Newtonsoft.Json.Required.Always)]
        public double Violence { get; set; } = default!;

        /// <summary>
        /// The score for the category 'violence/graphic'.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("violence/graphic", Required = global::Newtonsoft.Json.Required.Always)]
        public double ViolenceGraphic { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateModerationResponseResultCategoryScores" /> class.
        /// </summary>
        /// <param name="hate">
        /// The score for the category 'hate'.
        /// </param>
        /// <param name="hateThreatening">
        /// The score for the category 'hate/threatening'.
        /// </param>
        /// <param name="harassment">
        /// The score for the category 'harassment'.
        /// </param>
        /// <param name="harassmentThreatening">
        /// The score for the category 'harassment/threatening'.
        /// </param>
        /// <param name="selfHarm">
        /// The score for the category 'self-harm'.
        /// </param>
        /// <param name="selfHarmIntent">
        /// The score for the category 'self-harm/intent'.
        /// </param>
        /// <param name="selfHarmInstructions">
        /// The score for the category 'self-harm/instructions'.
        /// </param>
        /// <param name="sexual">
        /// The score for the category 'sexual'.
        /// </param>
        /// <param name="sexualMinors">
        /// The score for the category 'sexual/minors'.
        /// </param>
        /// <param name="violence">
        /// The score for the category 'violence'.
        /// </param>
        /// <param name="violenceGraphic">
        /// The score for the category 'violence/graphic'.
        /// </param>
        public CreateModerationResponseResultCategoryScores(
            double hate,
            double hateThreatening,
            double harassment,
            double harassmentThreatening,
            double selfHarm,
            double selfHarmIntent,
            double selfHarmInstructions,
            double sexual,
            double sexualMinors,
            double violence,
            double violenceGraphic)
        {
            this.Hate = hate;
            this.HateThreatening = hateThreatening;
            this.Harassment = harassment;
            this.HarassmentThreatening = harassmentThreatening;
            this.SelfHarm = selfHarm;
            this.SelfHarmIntent = selfHarmIntent;
            this.SelfHarmInstructions = selfHarmInstructions;
            this.Sexual = sexual;
            this.SexualMinors = sexualMinors;
            this.Violence = violence;
            this.ViolenceGraphic = violenceGraphic;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateModerationResponseResultCategoryScores" /> class.
        /// </summary>
        public CreateModerationResponseResultCategoryScores()
        {
        }
    }
}