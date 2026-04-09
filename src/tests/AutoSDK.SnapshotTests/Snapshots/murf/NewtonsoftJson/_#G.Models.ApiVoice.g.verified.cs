//HintName: G.Models.ApiVoice.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ApiVoice
    {
        /// <summary>
        /// This field has been deprecated. Please refer to 'supportedLocales.detail' instead.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("accent")]
        public string? Accent { get; set; }

        /// <summary>
        /// This field has been deprecated. Please refer to 'supportedLocales.availableStyles' instead.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("availableStyles")]
        public global::System.Collections.Generic.IList<string>? AvailableStyles { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// This field has been deprecated. Please refer to 'supportedLocales.detail' instead.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("displayLanguage")]
        public string? DisplayLanguage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("displayName")]
        public string? DisplayName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("gender")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ApiVoiceGenderJsonConverter))]
        public global::G.ApiVoiceGender? Gender { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("locale")]
        public string? Locale { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("supportedLocales")]
        public global::System.Collections.Generic.Dictionary<string, global::G.StyleDetails>? SupportedLocales { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("voiceId")]
        public string? VoiceId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiVoice" /> class.
        /// </summary>
        /// <param name="accent">
        /// This field has been deprecated. Please refer to 'supportedLocales.detail' instead.
        /// </param>
        /// <param name="availableStyles">
        /// This field has been deprecated. Please refer to 'supportedLocales.availableStyles' instead.
        /// </param>
        /// <param name="description"></param>
        /// <param name="displayLanguage">
        /// This field has been deprecated. Please refer to 'supportedLocales.detail' instead.
        /// </param>
        /// <param name="displayName"></param>
        /// <param name="gender"></param>
        /// <param name="locale"></param>
        /// <param name="supportedLocales"></param>
        /// <param name="voiceId"></param>
        public ApiVoice(
            string? accent,
            global::System.Collections.Generic.IList<string>? availableStyles,
            string? description,
            string? displayLanguage,
            string? displayName,
            global::G.ApiVoiceGender? gender,
            string? locale,
            global::System.Collections.Generic.Dictionary<string, global::G.StyleDetails>? supportedLocales,
            string? voiceId)
        {
            this.Accent = accent;
            this.AvailableStyles = availableStyles;
            this.Description = description;
            this.DisplayLanguage = displayLanguage;
            this.DisplayName = displayName;
            this.Gender = gender;
            this.Locale = locale;
            this.SupportedLocales = supportedLocales;
            this.VoiceId = voiceId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiVoice" /> class.
        /// </summary>
        public ApiVoice()
        {
        }
    }
}