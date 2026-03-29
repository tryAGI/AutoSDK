//HintName: G.Models.SpeechmaticsCustomVocabularyItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SpeechmaticsCustomVocabularyItem
    {
        /// <summary>
        /// The word or phrase to add to the custom vocabulary.<br/>
        /// Example: Speechmatics
        /// </summary>
        /// <example>Speechmatics</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Content { get; set; }

        /// <summary>
        /// Alternative phonetic representations of how the word might sound. This helps recognition when the word might be pronounced differently.<br/>
        /// Example: [speech mattix]
        /// </summary>
        /// <example>[speech mattix]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("soundsLike")]
        public global::System.Collections.Generic.IList<string>? SoundsLike { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeechmaticsCustomVocabularyItem" /> class.
        /// </summary>
        /// <param name="content">
        /// The word or phrase to add to the custom vocabulary.<br/>
        /// Example: Speechmatics
        /// </param>
        /// <param name="soundsLike">
        /// Alternative phonetic representations of how the word might sound. This helps recognition when the word might be pronounced differently.<br/>
        /// Example: [speech mattix]
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SpeechmaticsCustomVocabularyItem(
            string content,
            global::System.Collections.Generic.IList<string>? soundsLike)
        {
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.SoundsLike = soundsLike;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeechmaticsCustomVocabularyItem" /> class.
        /// </summary>
        public SpeechmaticsCustomVocabularyItem()
        {
        }
    }
}