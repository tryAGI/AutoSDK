//HintName: G.Models.IVoice.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class IVoice
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gender")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Gender { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("access")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.IVoiceAccessJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.IVoiceAccess Access { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        public string? Language { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        public global::G.IVoiceConfig? Config { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.IVoiceProviderJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.IVoiceProvider Provider { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("languages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.IVoiceLanguage> Languages { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("styles")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Styles { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("age")]
        public string? Age { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("useCase")]
        public string? UseCase { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voiceType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.IVoiceVoiceTypeJsonConverter))]
        public global::G.IVoiceVoiceType? VoiceType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isLegacy")]
        public bool? IsLegacy { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IVoice" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="gender"></param>
        /// <param name="access"></param>
        /// <param name="provider"></param>
        /// <param name="languages"></param>
        /// <param name="styles"></param>
        /// <param name="language"></param>
        /// <param name="config"></param>
        /// <param name="description"></param>
        /// <param name="age"></param>
        /// <param name="useCase"></param>
        /// <param name="voiceType"></param>
        /// <param name="isLegacy"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IVoice(
            string id,
            string name,
            string gender,
            global::G.IVoiceAccess access,
            global::G.IVoiceProvider provider,
            global::System.Collections.Generic.IList<global::G.IVoiceLanguage> languages,
            global::System.Collections.Generic.IList<string> styles,
            string? language,
            global::G.IVoiceConfig? config,
            string? description,
            string? age,
            string? useCase,
            global::G.IVoiceVoiceType? voiceType,
            bool? isLegacy)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Gender = gender ?? throw new global::System.ArgumentNullException(nameof(gender));
            this.Access = access;
            this.Language = language;
            this.Config = config;
            this.Provider = provider;
            this.Languages = languages ?? throw new global::System.ArgumentNullException(nameof(languages));
            this.Styles = styles ?? throw new global::System.ArgumentNullException(nameof(styles));
            this.Description = description;
            this.Age = age;
            this.UseCase = useCase;
            this.VoiceType = voiceType;
            this.IsLegacy = isLegacy;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IVoice" /> class.
        /// </summary>
        public IVoice()
        {
        }
    }
}