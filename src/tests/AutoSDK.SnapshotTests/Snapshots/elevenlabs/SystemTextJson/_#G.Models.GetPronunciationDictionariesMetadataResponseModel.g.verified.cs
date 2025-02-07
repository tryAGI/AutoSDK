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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pronunciation_dictionaries")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.GetPronunciationDictionaryMetadataResponseModel> PronunciationDictionaries { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_cursor")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NextCursor { get; set; }

        /// <summary>
        /// 
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
        /// <param name="pronunciationDictionaries"></param>
        /// <param name="nextCursor"></param>
        /// <param name="hasMore"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetPronunciationDictionariesMetadataResponseModel(
            global::System.Collections.Generic.IList<global::G.GetPronunciationDictionaryMetadataResponseModel> pronunciationDictionaries,
            string nextCursor,
            bool hasMore)
        {
            this.PronunciationDictionaries = pronunciationDictionaries ?? throw new global::System.ArgumentNullException(nameof(pronunciationDictionaries));
            this.NextCursor = nextCursor ?? throw new global::System.ArgumentNullException(nameof(nextCursor));
            this.HasMore = hasMore;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetPronunciationDictionariesMetadataResponseModel" /> class.
        /// </summary>
        public GetPronunciationDictionariesMetadataResponseModel()
        {
        }
    }
}