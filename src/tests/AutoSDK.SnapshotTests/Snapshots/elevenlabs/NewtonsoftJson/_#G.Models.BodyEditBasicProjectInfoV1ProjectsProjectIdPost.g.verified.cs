//HintName: G.Models.BodyEditBasicProjectInfoV1ProjectsProjectIdPost.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyEditBasicProjectInfoV1ProjectsProjectIdPost
    {
        /// <summary>
        /// The name of the project, used for identification only.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// The voice_id that corresponds to the default voice used for new titles.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("default_title_voice_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string DefaultTitleVoiceId { get; set; } = default!;

        /// <summary>
        /// The voice_id that corresponds to the default voice used for new paragraphs.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("default_paragraph_voice_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string DefaultParagraphVoiceId { get; set; } = default!;

        /// <summary>
        /// An optional name of the author of the project, this will be added as metadata to the mp3 file on project / chapter download.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("title")]
        public string? Title { get; set; }

        /// <summary>
        /// An optional name of the author of the project, this will be added as metadata to the mp3 file on project / chapter download.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("author")]
        public string? Author { get; set; }

        /// <summary>
        /// An optional ISBN number of the project you want to create, this will be added as metadata to the mp3 file on project / chapter download.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("isbn_number")]
        public string? IsbnNumber { get; set; }

        /// <summary>
        /// When the project is downloaded, should the returned audio have postprocessing in order to make it compliant with audiobook normalized volume requirements<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("volume_normalization")]
        public bool? VolumeNormalization { get; set; }

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
        public static global::G.BodyEditBasicProjectInfoV1ProjectsProjectIdPost? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.BodyEditBasicProjectInfoV1ProjectsProjectIdPost>(
                json,
                jsonSerializerOptions);
        }

    }
}