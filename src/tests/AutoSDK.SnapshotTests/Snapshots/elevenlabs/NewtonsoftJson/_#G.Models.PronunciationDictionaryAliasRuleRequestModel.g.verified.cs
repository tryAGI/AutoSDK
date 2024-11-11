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
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.PronunciationDictionaryAliasRuleRequestModelType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("string_to_replace", Required = global::Newtonsoft.Json.Required.Always)]
        public string StringToReplace { get; set; } = default!;

        /// <summary>
        /// 
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
        /// <param name="type"></param>
        /// <param name="stringToReplace"></param>
        /// <param name="alias"></param>
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