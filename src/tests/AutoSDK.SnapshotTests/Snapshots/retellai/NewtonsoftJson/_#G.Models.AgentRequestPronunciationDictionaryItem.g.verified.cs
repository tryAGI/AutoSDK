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
        [global::Newtonsoft.Json.JsonProperty("word", Required = global::Newtonsoft.Json.Required.Always)]
        public string Word { get; set; } = default!;

        /// <summary>
        /// The phonetic alphabet to be used for pronunciation.<br/>
        /// Example: ipa
        /// </summary>
        /// <example>ipa</example>
        [global::Newtonsoft.Json.JsonProperty("alphabet", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.AgentRequestPronunciationDictionaryItemAlphabetJsonConverter))]
        public global::G.AgentRequestPronunciationDictionaryItemAlphabet Alphabet { get; set; } = default!;

        /// <summary>
        /// Pronunciation of the word in the format of a IPA / CMU pronunciation.<br/>
        /// Example: ˈæktʃuəli
        /// </summary>
        /// <example>ˈæktʃuəli</example>
        [global::Newtonsoft.Json.JsonProperty("phoneme", Required = global::Newtonsoft.Json.Required.Always)]
        public string Phoneme { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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