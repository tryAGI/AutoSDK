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
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("gender", Required = global::Newtonsoft.Json.Required.Always)]
        public string Gender { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("access", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.IVoiceAccess Access { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("language")]
        public string? Language { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("config")]
        public global::G.IVoiceConfig? Config { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("provider", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.IVoiceProvider Provider { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("languages", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.IVoiceLanguage> Languages { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("styles", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> Styles { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("age")]
        public string? Age { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("useCase")]
        public string? UseCase { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("voiceType")]
        public global::G.IVoiceVoiceType? VoiceType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("isLegacy")]
        public bool? IsLegacy { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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