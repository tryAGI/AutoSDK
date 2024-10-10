//HintName: G.IPronunciationDictionaryClient.RemoveRulesFromThePronunciationDictionaryV1PronunciationDictionariesPronunciationDictionaryIdRemoveRulesPost.g.cs
#nullable enable

namespace G
{
    public partial interface IPronunciationDictionaryClient
    {
        /// <summary>
        /// Remove Rules From The Pronunciation Dictionary<br/>
        /// Remove rules from the pronunciation dictionary
        /// </summary>
        /// <param name="pronunciationDictionaryId">
        /// The id of the pronunciation dictionary
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.RemovePronunciationDictionaryRulesResponseModel> RemoveRulesFromThePronunciationDictionaryV1PronunciationDictionariesPronunciationDictionaryIdRemoveRulesPostAsync(
            string pronunciationDictionaryId,
            global::G.BodyRemoveRulesFromThePronunciationDictionaryV1PronunciationDictionariesPronunciationDictionaryIdRemoveRulesPost request,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Remove Rules From The Pronunciation Dictionary<br/>
        /// Remove rules from the pronunciation dictionary
        /// </summary>
        /// <param name="pronunciationDictionaryId">
        /// The id of the pronunciation dictionary
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="ruleStrings">
        /// List of strings to remove from the pronunciation dictionary.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.RemovePronunciationDictionaryRulesResponseModel> RemoveRulesFromThePronunciationDictionaryV1PronunciationDictionariesPronunciationDictionaryIdRemoveRulesPostAsync(
            string pronunciationDictionaryId,
            global::System.Collections.Generic.IList<string> ruleStrings,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}