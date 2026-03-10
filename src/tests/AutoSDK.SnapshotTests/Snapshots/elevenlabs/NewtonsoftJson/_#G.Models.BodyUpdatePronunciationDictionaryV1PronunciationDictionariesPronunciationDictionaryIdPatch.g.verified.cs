//HintName: G.Models.BodyUpdatePronunciationDictionaryV1PronunciationDictionariesPronunciationDictionaryIdPatch.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyUpdatePronunciationDictionaryV1PronunciationDictionariesPronunciationDictionaryIdPatch
    {
        /// <summary>
        /// Whether to archive the pronunciation dictionary.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("archived")]
        public bool? Archived { get; set; }

        /// <summary>
        /// The name of the pronunciation dictionary, used for identification only.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyUpdatePronunciationDictionaryV1PronunciationDictionariesPronunciationDictionaryIdPatch" /> class.
        /// </summary>
        /// <param name="archived">
        /// Whether to archive the pronunciation dictionary.
        /// </param>
        /// <param name="name">
        /// The name of the pronunciation dictionary, used for identification only.
        /// </param>
        public BodyUpdatePronunciationDictionaryV1PronunciationDictionariesPronunciationDictionaryIdPatch(
            bool? archived,
            string? name)
        {
            this.Archived = archived;
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyUpdatePronunciationDictionaryV1PronunciationDictionariesPronunciationDictionaryIdPatch" /> class.
        /// </summary>
        public BodyUpdatePronunciationDictionaryV1PronunciationDictionariesPronunciationDictionaryIdPatch()
        {
        }
    }
}