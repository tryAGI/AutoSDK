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
        /// Text to generate, text length has to be between 100 and 1000.<br/>
        /// Example: Every act of kindness, no matter how small, carries value and can make a difference, as no gesture of goodwill is ever wasted.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text", Required = global::Newtonsoft.Json.Required.Always)]
        public string Text { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();


        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public string ToJson(
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.SerializeObject(
                this,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.BodyGenerateARandomVoiceV1VoiceGenerationGenerateVoicePost? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.BodyGenerateARandomVoiceV1VoiceGenerationGenerateVoicePost>(
                json,
                jsonSerializerOptions);
        }

    }
}