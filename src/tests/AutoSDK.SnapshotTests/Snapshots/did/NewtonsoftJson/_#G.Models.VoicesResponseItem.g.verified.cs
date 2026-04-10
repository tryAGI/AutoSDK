//HintName: G.Models.VoicesResponseItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VoicesResponseItem
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
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.VoicesResponseItemAccessJsonConverter))]
        public global::G.VoicesResponseItemAccess Access { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("language")]
        public string? Language { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("config")]
        public global::G.VoicesResponseItemConfig? Config { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("provider", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.VoicesResponseItemProviderJsonConverter))]
        public global::G.VoicesResponseItemProvider Provider { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("languages", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.VoicesResponseItemLanguage> Languages { get; set; } = default!;

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
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.VoicesResponseItemVoiceTypeJsonConverter))]
        public global::G.VoicesResponseItemVoiceType? VoiceType { get; set; }

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
        /// Initializes a new instance of the <see cref="VoicesResponseItem" /> class.
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
        public VoicesResponseItem(
            string id,
            string name,
            string gender,
            global::G.VoicesResponseItemAccess access,
            global::G.VoicesResponseItemProvider provider,
            global::System.Collections.Generic.IList<global::G.VoicesResponseItemLanguage> languages,
            global::System.Collections.Generic.IList<string> styles,
            string? language,
            global::G.VoicesResponseItemConfig? config,
            string? description,
            string? age,
            string? useCase,
            global::G.VoicesResponseItemVoiceType? voiceType,
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
        /// Initializes a new instance of the <see cref="VoicesResponseItem" /> class.
        /// </summary>
        public VoicesResponseItem()
        {
        }
    }
}