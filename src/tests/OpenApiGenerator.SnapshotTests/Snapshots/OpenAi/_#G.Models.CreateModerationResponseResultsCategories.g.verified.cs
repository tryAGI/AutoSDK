//HintName: G.Models.CreateModerationResponseResultsCategories.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A list of the categories, and whether they are flagged or not.
    /// </summary>
    public sealed partial class CreateModerationResponseResultsCategories
    {
        /// <summary>
        /// Content that expresses, incites, or promotes hate based on race, gender, ethnicity, religion, nationality, sexual orientation, disability status, or caste. Hateful content aimed at non-protected groups (e.g., chess players) is harassment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hate")]
        public required bool Hate { get; set; }

        /// <summary>
        /// Hateful content that also includes violence or serious harm towards the targeted group based on race, gender, ethnicity, religion, nationality, sexual orientation, disability status, or caste.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hate/threatening")]
        public required bool HateThreatening { get; set; }

        /// <summary>
        /// Content that expresses, incites, or promotes harassing language towards any target.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("harassment")]
        public required bool Harassment { get; set; }

        /// <summary>
        /// Harassment content that also includes violence or serious harm towards any target.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("harassment/threatening")]
        public required bool HarassmentThreatening { get; set; }

        /// <summary>
        /// Content that promotes, encourages, or depicts acts of self-harm, such as suicide, cutting, and eating disorders.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("self-harm")]
        public required bool SelfHarm { get; set; }

        /// <summary>
        /// Content where the speaker expresses that they are engaging or intend to engage in acts of self-harm, such as suicide, cutting, and eating disorders.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("self-harm/intent")]
        public required bool SelfHarmIntent { get; set; }

        /// <summary>
        /// Content that encourages performing acts of self-harm, such as suicide, cutting, and eating disorders, or that gives instructions or advice on how to commit such acts.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("self-harm/instructions")]
        public required bool SelfHarmInstructions { get; set; }

        /// <summary>
        /// Content meant to arouse sexual excitement, such as the description of sexual activity, or that promotes sexual services (excluding sex education and wellness).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sexual")]
        public required bool Sexual { get; set; }

        /// <summary>
        /// Sexual content that includes an individual who is under 18 years old.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sexual/minors")]
        public required bool SexualMinors { get; set; }

        /// <summary>
        /// Content that depicts death, violence, or physical injury.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("violence")]
        public required bool Violence { get; set; }

        /// <summary>
        /// Content that depicts death, violence, or physical injury in graphic detail.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("violence/graphic")]
        public required bool ViolenceGraphic { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}