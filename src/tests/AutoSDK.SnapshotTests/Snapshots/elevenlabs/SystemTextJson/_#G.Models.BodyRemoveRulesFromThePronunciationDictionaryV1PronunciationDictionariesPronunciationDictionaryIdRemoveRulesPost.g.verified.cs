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
        [global::System.Text.Json.Serialization.JsonPropertyName("rule_strings")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> RuleStrings { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyRemoveRulesFromThePronunciationDictionaryV1PronunciationDictionariesPronunciationDictionaryIdRemoveRulesPost" /> class.
        /// </summary>
        /// <param name="ruleStrings">
        /// List of strings to remove from the pronunciation dictionary.<br/>
        /// Example: ['a', 'b']
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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