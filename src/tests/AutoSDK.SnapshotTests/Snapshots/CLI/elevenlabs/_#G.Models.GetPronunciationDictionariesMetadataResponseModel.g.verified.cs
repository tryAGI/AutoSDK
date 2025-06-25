//HintName: G.Models.GetPronunciationDictionariesMetadataResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetPronunciationDictionariesMetadataResponseModel
    {
        /// <summary>
        /// A list of pronunciation dictionaries and their metadata.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pronunciation_dictionaries")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.GetPronunciationDictionaryMetadataResponseModel> PronunciationDictionaries { get; set; }

        /// <summary>
        /// The next cursor to use for pagination.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_cursor")]
        public string? NextCursor { get; set; }

        /// <summary>
        /// Whether there are more pronunciation dictionaries to fetch.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_more")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HasMore { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetPronunciationDictionariesMetadataResponseModel" /> class.
        /// </summary>
        /// <param name="pronunciationDictionaries">
        /// A list of pronunciation dictionaries and their metadata.
        /// </param>
        /// <param name="nextCursor">
        /// The next cursor to use for pagination.
        /// </param>
        /// <param name="hasMore">
        /// Whether there are more pronunciation dictionaries to fetch.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetPronunciationDictionariesMetadataResponseModel(
            global::System.Collections.Generic.IList<global::G.GetPronunciationDictionaryMetadataResponseModel> pronunciationDictionaries,
            bool hasMore,
            string? nextCursor)
        {
            this.PronunciationDictionaries = pronunciationDictionaries ?? throw new global::System.ArgumentNullException(nameof(pronunciationDictionaries));
            this.HasMore = hasMore;
            this.NextCursor = nextCursor;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetPronunciationDictionariesMetadataResponseModel" /> class.
        /// </summary>
        public GetPronunciationDictionariesMetadataResponseModel()
        {
        }
    }
}