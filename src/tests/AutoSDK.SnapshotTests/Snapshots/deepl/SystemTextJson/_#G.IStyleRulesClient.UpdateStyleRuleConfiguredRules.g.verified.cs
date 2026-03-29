//HintName: G.IStyleRulesClient.UpdateStyleRuleConfiguredRules.g.cs
#nullable enable

namespace G
{
    public partial interface IStyleRulesClient
    {
        /// <summary>
        /// Update configured rules for a style rule list
        /// </summary>
        /// <param name="styleId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.StyleRuleList> UpdateStyleRuleConfiguredRulesAsync(
            string styleId,

            global::G.ConfiguredRules request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update configured rules for a style rule list
        /// </summary>
        /// <param name="styleId"></param>
        /// <param name="datesAndTimes"></param>
        /// <param name="formatting"></param>
        /// <param name="numbers"></param>
        /// <param name="punctuation"></param>
        /// <param name="spellingAndGrammar"></param>
        /// <param name="styleAndTone"></param>
        /// <param name="vocabulary"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.StyleRuleList> UpdateStyleRuleConfiguredRulesAsync(
            string styleId,
            global::G.ConfiguredRulesDatesAndTimes? datesAndTimes = default,
            global::G.ConfiguredRulesFormatting? formatting = default,
            global::G.ConfiguredRulesNumbers? numbers = default,
            global::G.ConfiguredRulesPunctuation? punctuation = default,
            global::G.ConfiguredRulesSpellingAndGrammar? spellingAndGrammar = default,
            global::G.ConfiguredRulesStyleAndTone? styleAndTone = default,
            global::G.ConfiguredRulesVocabulary? vocabulary = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}