//HintName: G.Models.SnowballParams.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SnowballParams
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.SnowballType Type { get; set; }

        /// <summary>
        /// Languages supported by snowball stemmer.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("language", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.SnowballLanguage Language { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SnowballParams" /> class.
        /// </summary>
        /// <param name="language">
        /// Languages supported by snowball stemmer.
        /// </param>
        /// <param name="type"></param>
        public SnowballParams(
            global::G.SnowballLanguage language,
            global::G.SnowballType type)
        {
            this.Type = type;
            this.Language = language;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SnowballParams" /> class.
        /// </summary>
        public SnowballParams()
        {
        }
    }
}