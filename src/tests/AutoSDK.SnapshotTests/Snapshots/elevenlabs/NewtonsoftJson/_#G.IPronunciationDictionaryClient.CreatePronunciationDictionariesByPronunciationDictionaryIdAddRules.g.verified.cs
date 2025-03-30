//HintName: G.IPronunciationDictionaryClient.CreatePronunciationDictionariesByPronunciationDictionaryIdAddRules.g.cs
#nullable enable

namespace G
{
    public partial interface IPronunciationDictionaryClient
    {
        /// <summary>
        /// Add Rules To The Pronunciation Dictionary<br/>
        /// Add rules to the pronunciation dictionary
        /// </summary>
        /// <param name="pronunciationDictionaryId">
        /// The id of the pronunciation dictionary<br/>
        /// Example: 21m00Tcm4TlvDq8ikWAM
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AddPronunciationDictionaryRulesResponseModel> CreatePronunciationDictionariesByPronunciationDictionaryIdAddRulesAsync(
            string pronunciationDictionaryId,
            global::G.BodyAddRulesToThePronunciationDictionaryV1PronunciationDictionariesPronunciationDictionaryIdAddRulesPost request,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Add Rules To The Pronunciation Dictionary<br/>
        /// Add rules to the pronunciation dictionary
        /// </summary>
        /// <param name="pronunciationDictionaryId">
        /// The id of the pronunciation dictionary<br/>
        /// Example: 21m00Tcm4TlvDq8ikWAM
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="rules">
        /// List of pronunciation rules. Rule can be either:<br/>
        ///     an alias rule: {'string_to_replace': 'a', 'type': 'alias', 'alias': 'b', }<br/>
        ///     or a phoneme rule: {'string_to_replace': 'a', 'type': 'phoneme', 'phoneme': 'b', 'alphabet': 'ipa' }<br/>
        /// Example: <br/>
        ///     [<br/>
        ///         {'string_to_replace': 'a', 'type': 'alias', 'alias': 'b' },<br/>
        ///         {'string_to_replace': 'c', 'type': 'phoneme', 'phoneme': 'd', 'alphabet': 'ipa' }<br/>
        ///     ]
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.AddPronunciationDictionaryRulesResponseModel> CreatePronunciationDictionariesByPronunciationDictionaryIdAddRulesAsync(
            string pronunciationDictionaryId,
            global::System.Collections.Generic.IList<global::G.AnyOf<global::G.PronunciationDictionaryAliasRuleRequestModel, global::G.PronunciationDictionaryPhonemeRuleRequestModel>> rules,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}