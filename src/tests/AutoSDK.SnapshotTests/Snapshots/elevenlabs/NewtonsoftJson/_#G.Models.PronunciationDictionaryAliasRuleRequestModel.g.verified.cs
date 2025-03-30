//HintName: G.Models.PronunciationDictionaryAliasRuleRequestModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PronunciationDictionaryAliasRuleRequestModel
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
        public global::G.PronunciationDictionaryAliasRuleRequestModelType Type { get; set; }

        /// <summary>
        /// The alias for the string to be replaced.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("alias", Required = global::Newtonsoft.Json.Required.Always)]
        public string Alias { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PronunciationDictionaryAliasRuleRequestModel" /> class.
        /// </summary>
        /// <param name="stringToReplace">
        /// The string to replace. Must be a non-empty string.
        /// </param>
        /// <param name="type">
        /// The type of the rule.
        /// </param>
        /// <param name="alias">
        /// The alias for the string to be replaced.
        /// </param>
        public PronunciationDictionaryAliasRuleRequestModel(
            string stringToReplace,
            string alias,
            global::G.PronunciationDictionaryAliasRuleRequestModelType type)
        {
            this.StringToReplace = stringToReplace ?? throw new global::System.ArgumentNullException(nameof(stringToReplace));
            this.Alias = alias ?? throw new global::System.ArgumentNullException(nameof(alias));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PronunciationDictionaryAliasRuleRequestModel" /> class.
        /// </summary>
        public PronunciationDictionaryAliasRuleRequestModel()
        {
        }
    }
}