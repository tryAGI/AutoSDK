//HintName: G.Models.GetLanguagesResponseItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetLanguagesResponseItem
    {
        /// <summary>
        /// The language code of the given language.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("language", Required = global::Newtonsoft.Json.Required.Always)]
        public string Language { get; set; } = default!;

        /// <summary>
        /// Name of the language in English.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Denotes formality support in case of a target language listing.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("supports_formality")]
        public bool? SupportsFormality { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetLanguagesResponseItem" /> class.
        /// </summary>
        /// <param name="language">
        /// The language code of the given language.
        /// </param>
        /// <param name="name">
        /// Name of the language in English.
        /// </param>
        /// <param name="supportsFormality">
        /// Denotes formality support in case of a target language listing.
        /// </param>
        public GetLanguagesResponseItem(
            string language,
            string name,
            bool? supportsFormality)
        {
            this.Language = language ?? throw new global::System.ArgumentNullException(nameof(language));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.SupportsFormality = supportsFormality;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetLanguagesResponseItem" /> class.
        /// </summary>
        public GetLanguagesResponseItem()
        {
        }
    }
}