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
        [global::Newtonsoft.Json.JsonProperty("pronunciation_dictionaries", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.GetPronunciationDictionaryMetadataResponseModel> PronunciationDictionaries { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("next_cursor", Required = global::Newtonsoft.Json.Required.Always)]
        public string NextCursor { get; set; } = default!;

        /// <summary>
        /// 
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
        /// <param name="pronunciationDictionaries"></param>
        /// <param name="nextCursor"></param>
        /// <param name="hasMore"></param>
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