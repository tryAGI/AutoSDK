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
        [global::Newtonsoft.Json.JsonProperty("gender", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.BodyGenerateARandomVoiceV1VoiceGenerationGenerateVoicePostGender Gender { get; set; } = default!;

        /// <summary>
        /// Category code corresponding to the accent of the generated voice. Possible values: american, british, african, australian, indian.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("accent", Required = global::Newtonsoft.Json.Required.Always)]
        public string Accent { get; set; } = default!;

        /// <summary>
        /// Category code corresponding to the age of the generated voice. Possible values: young, middle_aged, old.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("age", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.BodyGenerateARandomVoiceV1VoiceGenerationGenerateVoicePostAge Age { get; set; } = default!;

        /// <summary>
        /// The strength of the accent of the generated voice. Has to be between 0.3 and 2.0.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("accent_strength", Required = global::Newtonsoft.Json.Required.Always)]
        public double AccentStrength { get; set; } = default!;

        /// <summary>
        /// Text to generate, text length has to be between 100 and 1000.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text", Required = global::Newtonsoft.Json.Required.Always)]
        public string Text { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}