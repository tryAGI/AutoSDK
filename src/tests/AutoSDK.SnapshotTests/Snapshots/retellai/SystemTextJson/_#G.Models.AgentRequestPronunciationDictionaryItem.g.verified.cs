//HintName: G.Models.AgentRequestPronunciationDictionaryItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentRequestPronunciationDictionaryItem
    {
        /// <summary>
        /// The string of word / phrase to be annotated with pronunciation.<br/>
        /// Example: actually
        /// </summary>
        /// <example>actually</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("word")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Word { get; set; }

        /// <summary>
        /// The phonetic alphabet to be used for pronunciation.<br/>
        /// Example: ipa
        /// </summary>
        /// <example>ipa</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("alphabet")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AgentRequestPronunciationDictionaryItemAlphabetJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.AgentRequestPronunciationDictionaryItemAlphabet Alphabet { get; set; }

        /// <summary>
        /// Pronunciation of the word in the format of a IPA / CMU pronunciation.<br/>
        /// Example: ˈæktʃuəli
        /// </summary>
        /// <example>ˈæktʃuəli</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("phoneme")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Phoneme { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentRequestPronunciationDictionaryItem" /> class.
        /// </summary>
        /// <param name="word">
        /// The string of word / phrase to be annotated with pronunciation.<br/>
        /// Example: actually
        /// </param>
        /// <param name="alphabet">
        /// The phonetic alphabet to be used for pronunciation.<br/>
        /// Example: ipa
        /// </param>
        /// <param name="phoneme">
        /// Pronunciation of the word in the format of a IPA / CMU pronunciation.<br/>
        /// Example: ˈæktʃuəli
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentRequestPronunciationDictionaryItem(
            string word,
            global::G.AgentRequestPronunciationDictionaryItemAlphabet alphabet,
            string phoneme)
        {
            this.Word = word ?? throw new global::System.ArgumentNullException(nameof(word));
            this.Alphabet = alphabet;
            this.Phoneme = phoneme ?? throw new global::System.ArgumentNullException(nameof(phoneme));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentRequestPronunciationDictionaryItem" /> class.
        /// </summary>
        public AgentRequestPronunciationDictionaryItem()
        {
        }
    }
}