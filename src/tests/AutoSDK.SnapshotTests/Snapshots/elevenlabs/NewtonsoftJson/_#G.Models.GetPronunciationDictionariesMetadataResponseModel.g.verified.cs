//HintName: G.Models.GetPronunciationDictionariesMetadataResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: {"has_more":false,"next_cursor":"5xM3yVvZQKV0EfqQpLr2"}
    /// </summary>
    public sealed partial class GetPronunciationDictionariesMetadataResponseModel
    {
        /// <summary>
        /// A list of pronunciation dictionaries and their metadata.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pronunciation_dictionaries", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.GetPronunciationDictionaryMetadataResponseModel> PronunciationDictionaries { get; set; } = default!;

        /// <summary>
        /// The next cursor to use for pagination.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("next_cursor")]
        public string? NextCursor { get; set; }

        /// <summary>
        /// Whether there are more pronunciation dictionaries to fetch.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("has_more", Required = global::Newtonsoft.Json.Required.Always)]
        public bool HasMore { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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