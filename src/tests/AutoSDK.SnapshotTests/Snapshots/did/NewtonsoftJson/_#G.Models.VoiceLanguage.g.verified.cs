//HintName: G.Models.VoiceLanguage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VoiceLanguage
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("language", Required = global::Newtonsoft.Json.Required.Always)]
        public string Language { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("locale", Required = global::Newtonsoft.Json.Required.Always)]
        public string Locale { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("accent")]
        public string? Accent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("config")]
        public object? Config { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("previewUrl")]
        public string? PreviewUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceLanguage" /> class.
        /// </summary>
        /// <param name="language"></param>
        /// <param name="locale"></param>
        /// <param name="accent"></param>
        /// <param name="config"></param>
        /// <param name="previewUrl"></param>
        public VoiceLanguage(
            string language,
            string locale,
            string? accent,
            object? config,
            string? previewUrl)
        {
            this.Language = language ?? throw new global::System.ArgumentNullException(nameof(language));
            this.Locale = locale ?? throw new global::System.ArgumentNullException(nameof(locale));
            this.Accent = accent;
            this.Config = config;
            this.PreviewUrl = previewUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceLanguage" /> class.
        /// </summary>
        public VoiceLanguage()
        {
        }
    }
}