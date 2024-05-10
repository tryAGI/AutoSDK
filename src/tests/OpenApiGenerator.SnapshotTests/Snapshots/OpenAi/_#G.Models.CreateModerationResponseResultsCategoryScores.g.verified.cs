//HintName: G.Models.CreateModerationResponseResultsCategoryScores.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A list of the categories along with their scores as predicted by model.
    /// </summary>
    public sealed partial class CreateModerationResponseResultsCategoryScores
    {
        /// <summary>
        /// The score for the category 'hate'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hate")]
        public required double Hate { get; set; }

        /// <summary>
        /// The score for the category 'hate/threatening'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hate/threatening")]
        public required double HateThreatening { get; set; }

        /// <summary>
        /// The score for the category 'harassment'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("harassment")]
        public required double Harassment { get; set; }

        /// <summary>
        /// The score for the category 'harassment/threatening'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("harassment/threatening")]
        public required double HarassmentThreatening { get; set; }

        /// <summary>
        /// The score for the category 'self-harm'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("self-harm")]
        public required double SelfHarm { get; set; }

        /// <summary>
        /// The score for the category 'self-harm/intent'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("self-harm/intent")]
        public required double SelfHarmIntent { get; set; }

        /// <summary>
        /// The score for the category 'self-harm/instructions'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("self-harm/instructions")]
        public required double SelfHarmInstructions { get; set; }

        /// <summary>
        /// The score for the category 'sexual'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sexual")]
        public required double Sexual { get; set; }

        /// <summary>
        /// The score for the category 'sexual/minors'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sexual/minors")]
        public required double SexualMinors { get; set; }

        /// <summary>
        /// The score for the category 'violence'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("violence")]
        public required double Violence { get; set; }

        /// <summary>
        /// The score for the category 'violence/graphic'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("violence/graphic")]
        public required double ViolenceGraphic { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}