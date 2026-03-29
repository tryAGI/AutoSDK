//HintName: G.Models.GetTranslationsResponse2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetTranslationsResponse2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("translations", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.GetTranslationsResponseTranslation2> Translations { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("token")]
        public string? Token { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTranslationsResponse2" /> class.
        /// </summary>
        /// <param name="translations"></param>
        /// <param name="token"></param>
        public GetTranslationsResponse2(
            global::System.Collections.Generic.IList<global::G.GetTranslationsResponseTranslation2> translations,
            string? token)
        {
            this.Translations = translations ?? throw new global::System.ArgumentNullException(nameof(translations));
            this.Token = token;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTranslationsResponse2" /> class.
        /// </summary>
        public GetTranslationsResponse2()
        {
        }
    }
}