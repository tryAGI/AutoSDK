//HintName: G.Models.LocaleResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LocaleResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("locale", Required = global::Newtonsoft.Json.Required.Always)]
        public string Locale { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("language", Required = global::Newtonsoft.Json.Required.Always)]
        public string Language { get; set; } = default!;

        /// <summary>
        /// Dubbing Type supported by locale
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("supports", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.LocaleResponseSupportsItems> Supports { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LocaleResponse" /> class.
        /// </summary>
        /// <param name="locale"></param>
        /// <param name="language"></param>
        /// <param name="supports">
        /// Dubbing Type supported by locale
        /// </param>
        public LocaleResponse(
            string locale,
            string language,
            global::System.Collections.Generic.IList<global::G.LocaleResponseSupportsItems> supports)
        {
            this.Locale = locale ?? throw new global::System.ArgumentNullException(nameof(locale));
            this.Language = language ?? throw new global::System.ArgumentNullException(nameof(language));
            this.Supports = supports ?? throw new global::System.ArgumentNullException(nameof(supports));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LocaleResponse" /> class.
        /// </summary>
        public LocaleResponse()
        {
        }
    }
}