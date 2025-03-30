//HintName: G.Models.PronunciationDictionaryPhonemeRuleRequestModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PronunciationDictionaryPhonemeRuleRequestModel
    {
        /// <summary>
        /// The string to replace. Must be a non-empty string.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("string_to_replace", Required = global::Newtonsoft.Json.Required.Always)]
        public string StringToReplace { get; set; } = default!;

        /// <summary>
        /// The type of the rule.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.PronunciationDictionaryPhonemeRuleRequestModelType Type { get; set; }

        /// <summary>
        /// The phoneme rule.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("phoneme", Required = global::Newtonsoft.Json.Required.Always)]
        public string Phoneme { get; set; } = default!;

        /// <summary>
        /// The alphabet to use with the phoneme rule.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("alphabet", Required = global::Newtonsoft.Json.Required.Always)]
        public string Alphabet { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PronunciationDictionaryPhonemeRuleRequestModel" /> class.
        /// </summary>
        /// <param name="stringToReplace">
        /// The string to replace. Must be a non-empty string.
        /// </param>
        /// <param name="type">
        /// The type of the rule.
        /// </param>
        /// <param name="phoneme">
        /// The phoneme rule.
        /// </param>
        /// <param name="alphabet">
        /// The alphabet to use with the phoneme rule.
        /// </param>
        public PronunciationDictionaryPhonemeRuleRequestModel(
            string stringToReplace,
            string phoneme,
            string alphabet,
            global::G.PronunciationDictionaryPhonemeRuleRequestModelType type)
        {
            this.StringToReplace = stringToReplace ?? throw new global::System.ArgumentNullException(nameof(stringToReplace));
            this.Phoneme = phoneme ?? throw new global::System.ArgumentNullException(nameof(phoneme));
            this.Alphabet = alphabet ?? throw new global::System.ArgumentNullException(nameof(alphabet));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PronunciationDictionaryPhonemeRuleRequestModel" /> class.
        /// </summary>
        public PronunciationDictionaryPhonemeRuleRequestModel()
        {
        }
    }
}