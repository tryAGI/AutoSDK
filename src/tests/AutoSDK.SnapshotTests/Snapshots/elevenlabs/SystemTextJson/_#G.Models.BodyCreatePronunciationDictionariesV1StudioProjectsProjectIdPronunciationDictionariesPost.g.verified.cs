//HintName: G.Models.BodyCreatePronunciationDictionariesV1StudioProjectsProjectIdPronunciationDictionariesPost.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyCreatePronunciationDictionariesV1StudioProjectsProjectIdPronunciationDictionariesPost
    {
        /// <summary>
        /// A list of pronunciation dictionary locators (pronunciation_dictionary_id, version_id) encoded as a list of JSON strings for pronunciation dictionaries to be applied to the text. A list of json encoded strings is required as adding projects may occur through formData as opposed to jsonBody. To specify multiple dictionaries use multiple --form lines in your curl, such as --form 'pronunciation_dictionary_locators="{\"pronunciation_dictionary_id\":\"Vmd4Zor6fplcA7WrINey\",\"version_id\":\"hRPaxjlTdR7wFMhV4w0b\"}"' --form 'pronunciation_dictionary_locators="{\"pronunciation_dictionary_id\":\"JzWtcGQMJ6bnlWwyMo7e\",\"version_id\":\"lbmwxiLu4q6txYxgdZqn\"}"'. Note that multiple dictionaries are not currently supported by our UI which will only show the first.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pronunciation_dictionary_locators")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.PronunciationDictionaryVersionLocatorDBModel> PronunciationDictionaryLocators { get; set; }

        /// <summary>
        /// This will automatically mark text in this project for reconversion when the new dictionary applies or the old one no longer does.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("invalidate_affected_text")]
        public bool? InvalidateAffectedText { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyCreatePronunciationDictionariesV1StudioProjectsProjectIdPronunciationDictionariesPost" /> class.
        /// </summary>
        /// <param name="pronunciationDictionaryLocators">
        /// A list of pronunciation dictionary locators (pronunciation_dictionary_id, version_id) encoded as a list of JSON strings for pronunciation dictionaries to be applied to the text. A list of json encoded strings is required as adding projects may occur through formData as opposed to jsonBody. To specify multiple dictionaries use multiple --form lines in your curl, such as --form 'pronunciation_dictionary_locators="{\"pronunciation_dictionary_id\":\"Vmd4Zor6fplcA7WrINey\",\"version_id\":\"hRPaxjlTdR7wFMhV4w0b\"}"' --form 'pronunciation_dictionary_locators="{\"pronunciation_dictionary_id\":\"JzWtcGQMJ6bnlWwyMo7e\",\"version_id\":\"lbmwxiLu4q6txYxgdZqn\"}"'. Note that multiple dictionaries are not currently supported by our UI which will only show the first.
        /// </param>
        /// <param name="invalidateAffectedText">
        /// This will automatically mark text in this project for reconversion when the new dictionary applies or the old one no longer does.<br/>
        /// Default Value: true
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BodyCreatePronunciationDictionariesV1StudioProjectsProjectIdPronunciationDictionariesPost(
            global::System.Collections.Generic.IList<global::G.PronunciationDictionaryVersionLocatorDBModel> pronunciationDictionaryLocators,
            bool? invalidateAffectedText)
        {
            this.PronunciationDictionaryLocators = pronunciationDictionaryLocators ?? throw new global::System.ArgumentNullException(nameof(pronunciationDictionaryLocators));
            this.InvalidateAffectedText = invalidateAffectedText;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyCreatePronunciationDictionariesV1StudioProjectsProjectIdPronunciationDictionariesPost" /> class.
        /// </summary>
        public BodyCreatePronunciationDictionariesV1StudioProjectsProjectIdPronunciationDictionariesPost()
        {
        }
    }
}