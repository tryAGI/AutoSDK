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
        /// The score for the category 'harassment'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("harassment")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Harassment { get; set; }

        /// <summary>
        /// The score for the category 'harassment/threatening'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("harassment/threatening")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double HarassmentThreatening { get; set; }

        /// <summary>
        /// The score for the category 'hate'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hate")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Hate { get; set; }

        /// <summary>
        /// The score for the category 'hate/threatening'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hate/threatening")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double HateThreatening { get; set; }

        /// <summary>
        /// The score for the category 'illicit'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("illicit")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Illicit { get; set; }

        /// <summary>
        /// The score for the category 'illicit/violent'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("illicit/violent")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double IllicitViolent { get; set; }

        /// <summary>
        /// The score for the category 'self-harm'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("self-harm")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double SelfHarm { get; set; }

        /// <summary>
        /// The score for the category 'self-harm/instructions'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("self-harm/instructions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double SelfHarmInstructions { get; set; }

        /// <summary>
        /// The score for the category 'self-harm/intent'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("self-harm/intent")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double SelfHarmIntent { get; set; }

        /// <summary>
        /// The score for the category 'sexual'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sexual")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Sexual { get; set; }

        /// <summary>
        /// The score for the category 'sexual/minors'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sexual/minors")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double SexualMinors { get; set; }

        /// <summary>
        /// The score for the category 'violence'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("violence")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Violence { get; set; }

        /// <summary>
        /// The score for the category 'violence/graphic'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("violence/graphic")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double ViolenceGraphic { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateModerationResponseResultCategoryScores" /> class.
        /// </summary>
        /// <param name="harassment">
        /// The score for the category 'harassment'.
        /// </param>
        /// <param name="harassmentThreatening">
        /// The score for the category 'harassment/threatening'.
        /// </param>
        /// <param name="hate">
        /// The score for the category 'hate'.
        /// </param>
        /// <param name="hateThreatening">
        /// The score for the category 'hate/threatening'.
        /// </param>
        /// <param name="illicit">
        /// The score for the category 'illicit'.
        /// </param>
        /// <param name="illicitViolent">
        /// The score for the category 'illicit/violent'.
        /// </param>
        /// <param name="selfHarm">
        /// The score for the category 'self-harm'.
        /// </param>
        /// <param name="selfHarmInstructions">
        /// The score for the category 'self-harm/instructions'.
        /// </param>
        /// <param name="selfHarmIntent">
        /// The score for the category 'self-harm/intent'.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateModerationResponseResultCategoryScores(
            double harassment,
            double harassmentThreatening,
            double hate,
            double hateThreatening,
            double illicit,
            double illicitViolent,
            double selfHarm,
            double selfHarmInstructions,
            double selfHarmIntent,
            double sexual,
            double sexualMinors,
            double violence,
            double violenceGraphic)
        {
            this.Harassment = harassment;
            this.HarassmentThreatening = harassmentThreatening;
            this.Hate = hate;
            this.HateThreatening = hateThreatening;
            this.Illicit = illicit;
            this.IllicitViolent = illicitViolent;
            this.SelfHarm = selfHarm;
            this.SelfHarmInstructions = selfHarmInstructions;
            this.SelfHarmIntent = selfHarmIntent;
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