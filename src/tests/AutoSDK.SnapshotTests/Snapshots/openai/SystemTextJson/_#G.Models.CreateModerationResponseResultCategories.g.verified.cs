//HintName: G.Models.CreateModerationResponseResultCategories.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A list of the categories, and whether they are flagged or not.
    /// </summary>
    public sealed partial class CreateModerationResponseResultCategories
    {
        /// <summary>
        /// Content that expresses, incites, or promotes hate based on race, gender, ethnicity, religion, nationality, sexual orientation, disability status, or caste. Hateful content aimed at non-protected groups (e.g., chess players) is harassment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hate")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Hate { get; set; }

        /// <summary>
        /// Hateful content that also includes violence or serious harm towards the targeted group based on race, gender, ethnicity, religion, nationality, sexual orientation, disability status, or caste.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hate/threatening")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HateThreatening { get; set; }

        /// <summary>
        /// Content that expresses, incites, or promotes harassing language towards any target.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("harassment")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Harassment { get; set; }

        /// <summary>
        /// Harassment content that also includes violence or serious harm towards any target.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("harassment/threatening")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HarassmentThreatening { get; set; }

        /// <summary>
        /// Content that includes instructions or advice that facilitate the planning or execution of wrongdoing, or that gives advice or instruction on how to commit illicit acts. For example, "how to shoplift" would fit this category.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("illicit")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Illicit { get; set; }

        /// <summary>
        /// Content that includes instructions or advice that facilitate the planning or execution of wrongdoing that also includes violence, or that gives advice or instruction on the procurement of any weapon.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("illicit/violent")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IllicitViolent { get; set; }

        /// <summary>
        /// Content that promotes, encourages, or depicts acts of self-harm, such as suicide, cutting, and eating disorders.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("self-harm")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool SelfHarm { get; set; }

        /// <summary>
        /// Content where the speaker expresses that they are engaging or intend to engage in acts of self-harm, such as suicide, cutting, and eating disorders.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("self-harm/intent")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool SelfHarmIntent { get; set; }

        /// <summary>
        /// Content that encourages performing acts of self-harm, such as suicide, cutting, and eating disorders, or that gives instructions or advice on how to commit such acts.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("self-harm/instructions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool SelfHarmInstructions { get; set; }

        /// <summary>
        /// Content meant to arouse sexual excitement, such as the description of sexual activity, or that promotes sexual services (excluding sex education and wellness).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sexual")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Sexual { get; set; }

        /// <summary>
        /// Sexual content that includes an individual who is under 18 years old.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sexual/minors")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool SexualMinors { get; set; }

        /// <summary>
        /// Content that depicts death, violence, or physical injury.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("violence")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Violence { get; set; }

        /// <summary>
        /// Content that depicts death, violence, or physical injury in graphic detail.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("violence/graphic")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool ViolenceGraphic { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateModerationResponseResultCategories" /> class.
        /// </summary>
        /// <param name="hate">
        /// Content that expresses, incites, or promotes hate based on race, gender, ethnicity, religion, nationality, sexual orientation, disability status, or caste. Hateful content aimed at non-protected groups (e.g., chess players) is harassment.
        /// </param>
        /// <param name="hateThreatening">
        /// Hateful content that also includes violence or serious harm towards the targeted group based on race, gender, ethnicity, religion, nationality, sexual orientation, disability status, or caste.
        /// </param>
        /// <param name="harassment">
        /// Content that expresses, incites, or promotes harassing language towards any target.
        /// </param>
        /// <param name="harassmentThreatening">
        /// Harassment content that also includes violence or serious harm towards any target.
        /// </param>
        /// <param name="illicit">
        /// Content that includes instructions or advice that facilitate the planning or execution of wrongdoing, or that gives advice or instruction on how to commit illicit acts. For example, "how to shoplift" would fit this category.
        /// </param>
        /// <param name="illicitViolent">
        /// Content that includes instructions or advice that facilitate the planning or execution of wrongdoing that also includes violence, or that gives advice or instruction on the procurement of any weapon.
        /// </param>
        /// <param name="selfHarm">
        /// Content that promotes, encourages, or depicts acts of self-harm, such as suicide, cutting, and eating disorders.
        /// </param>
        /// <param name="selfHarmIntent">
        /// Content where the speaker expresses that they are engaging or intend to engage in acts of self-harm, such as suicide, cutting, and eating disorders.
        /// </param>
        /// <param name="selfHarmInstructions">
        /// Content that encourages performing acts of self-harm, such as suicide, cutting, and eating disorders, or that gives instructions or advice on how to commit such acts.
        /// </param>
        /// <param name="sexual">
        /// Content meant to arouse sexual excitement, such as the description of sexual activity, or that promotes sexual services (excluding sex education and wellness).
        /// </param>
        /// <param name="sexualMinors">
        /// Sexual content that includes an individual who is under 18 years old.
        /// </param>
        /// <param name="violence">
        /// Content that depicts death, violence, or physical injury.
        /// </param>
        /// <param name="violenceGraphic">
        /// Content that depicts death, violence, or physical injury in graphic detail.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public CreateModerationResponseResultCategories(
            bool hate,
            bool hateThreatening,
            bool harassment,
            bool harassmentThreatening,
            bool illicit,
            bool illicitViolent,
            bool selfHarm,
            bool selfHarmIntent,
            bool selfHarmInstructions,
            bool sexual,
            bool sexualMinors,
            bool violence,
            bool violenceGraphic)
        {
            this.Hate = hate;
            this.HateThreatening = hateThreatening;
            this.Harassment = harassment;
            this.HarassmentThreatening = harassmentThreatening;
            this.Illicit = illicit;
            this.IllicitViolent = illicitViolent;
            this.SelfHarm = selfHarm;
            this.SelfHarmIntent = selfHarmIntent;
            this.SelfHarmInstructions = selfHarmInstructions;
            this.Sexual = sexual;
            this.SexualMinors = sexualMinors;
            this.Violence = violence;
            this.ViolenceGraphic = violenceGraphic;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateModerationResponseResultCategories" /> class.
        /// </summary>
        public CreateModerationResponseResultCategories()
        {
        }
    }
}