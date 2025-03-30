//HintName: G.Models.BodyRemoveRulesFromThePronunciationDictionaryV1PronunciationDictionariesPronunciationDictionaryIdRemoveRulesPost.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyRemoveRulesFromThePronunciationDictionaryV1PronunciationDictionariesPronunciationDictionaryIdRemoveRulesPost
    {
        /// <summary>
        /// List of strings to remove from the pronunciation dictionary.<br/>
        /// Example: ['a', 'b']
        /// </summary>
        /// <example>['a', 'b']</example>
        [global::Newtonsoft.Json.JsonProperty("rule_strings", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> RuleStrings { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyRemoveRulesFromThePronunciationDictionaryV1PronunciationDictionariesPronunciationDictionaryIdRemoveRulesPost" /> class.
        /// </summary>
        /// <param name="ruleStrings">
        /// List of strings to remove from the pronunciation dictionary.<br/>
        /// Example: ['a', 'b']
        /// </param>
        public BodyRemoveRulesFromThePronunciationDictionaryV1PronunciationDictionariesPronunciationDictionaryIdRemoveRulesPost(
            global::System.Collections.Generic.IList<string> ruleStrings)
        {
            this.RuleStrings = ruleStrings ?? throw new global::System.ArgumentNullException(nameof(ruleStrings));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyRemoveRulesFromThePronunciationDictionaryV1PronunciationDictionariesPronunciationDictionaryIdRemoveRulesPost" /> class.
        /// </summary>
        public BodyRemoveRulesFromThePronunciationDictionaryV1PronunciationDictionariesPronunciationDictionaryIdRemoveRulesPost()
        {
        }
    }
}