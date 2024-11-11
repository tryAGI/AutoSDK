//HintName: G.Models.BodyGenerateARandomVoiceV1VoiceGenerationGenerateVoicePost.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyGenerateARandomVoiceV1VoiceGenerationGenerateVoicePost
    {
        /// <summary>
        /// Category code corresponding to the gender of the generated voice. Possible values: female, male.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gender")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.BodyGenerateARandomVoiceV1VoiceGenerationGenerateVoicePostGenderJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.BodyGenerateARandomVoiceV1VoiceGenerationGenerateVoicePostGender Gender { get; set; }

        /// <summary>
        /// Category code corresponding to the accent of the generated voice. Possible values: american, british, african, australian, indian.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("accent")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Accent { get; set; }

        /// <summary>
        /// Category code corresponding to the age of the generated voice. Possible values: young, middle_aged, old.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("age")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.BodyGenerateARandomVoiceV1VoiceGenerationGenerateVoicePostAgeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.BodyGenerateARandomVoiceV1VoiceGenerationGenerateVoicePostAge Age { get; set; }

        /// <summary>
        /// The strength of the accent of the generated voice. Has to be between 0.3 and 2.0.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("accent_strength")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double AccentStrength { get; set; }

        /// <summary>
        /// Text to generate, text length has to be between 100 and 1000.<br/>
        /// Example: Every act of kindness, no matter how small, carries value and can make a difference, as no gesture of goodwill is ever wasted.
        /// </summary>
        /// <example>Every act of kindness, no matter how small, carries value and can make a difference, as no gesture of goodwill is ever wasted.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyGenerateARandomVoiceV1VoiceGenerationGenerateVoicePost" /> class.
        /// </summary>
        /// <param name="gender">
        /// Category code corresponding to the gender of the generated voice. Possible values: female, male.
        /// </param>
        /// <param name="accent">
        /// Category code corresponding to the accent of the generated voice. Possible values: american, british, african, australian, indian.
        /// </param>
        /// <param name="age">
        /// Category code corresponding to the age of the generated voice. Possible values: young, middle_aged, old.
        /// </param>
        /// <param name="accentStrength">
        /// The strength of the accent of the generated voice. Has to be between 0.3 and 2.0.
        /// </param>
        /// <param name="text">
        /// Text to generate, text length has to be between 100 and 1000.<br/>
        /// Example: Every act of kindness, no matter how small, carries value and can make a difference, as no gesture of goodwill is ever wasted.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public BodyGenerateARandomVoiceV1VoiceGenerationGenerateVoicePost(
            global::G.BodyGenerateARandomVoiceV1VoiceGenerationGenerateVoicePostGender gender,
            string accent,
            global::G.BodyGenerateARandomVoiceV1VoiceGenerationGenerateVoicePostAge age,
            double accentStrength,
            string text)
        {
            this.Gender = gender;
            this.Accent = accent ?? throw new global::System.ArgumentNullException(nameof(accent));
            this.Age = age;
            this.AccentStrength = accentStrength;
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyGenerateARandomVoiceV1VoiceGenerationGenerateVoicePost" /> class.
        /// </summary>
        public BodyGenerateARandomVoiceV1VoiceGenerationGenerateVoicePost()
        {
        }
    }
}