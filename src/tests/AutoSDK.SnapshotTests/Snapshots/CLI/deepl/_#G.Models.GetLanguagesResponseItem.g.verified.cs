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
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Language { get; set; }

        /// <summary>
        /// Name of the language in English.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Denotes formality support in case of a target language listing.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("supports_formality")]
        public bool? SupportsFormality { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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