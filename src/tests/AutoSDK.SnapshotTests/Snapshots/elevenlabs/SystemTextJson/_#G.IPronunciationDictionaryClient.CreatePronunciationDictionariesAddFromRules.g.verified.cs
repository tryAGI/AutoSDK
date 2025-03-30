//HintName: G.IPronunciationDictionaryClient.CreatePronunciationDictionariesAddFromRules.g.cs
#nullable enable

namespace G
{
    public partial interface IPronunciationDictionaryClient
    {
        /// <summary>
        /// Add A Pronunciation Dictionary<br/>
        /// Creates a new pronunciation dictionary from provided rules.
        /// </summary>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AddPronunciationDictionaryResponseModel> CreatePronunciationDictionariesAddFromRulesAsync(
            global::G.BodyAddAPronunciationDictionaryV1PronunciationDictionariesAddFromRulesPost request,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Add A Pronunciation Dictionary<br/>
        /// Creates a new pronunciation dictionary from provided rules.
        /// </summary>
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
        /// <param name="name">
        /// The name of the pronunciation dictionary, used for identification only.<br/>
        /// Example: My Dictionary
        /// </param>
        /// <param name="description">
        /// A description of the pronunciation dictionary, used for identification only.<br/>
        /// Example: Contains pronunciation's of our character names
        /// </param>
        /// <param name="workspaceAccess">
        /// Should be one of 'admin', 'editor' or 'viewer'. If not provided, defaults to no access.<br/>
        /// Example: viewer
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.AddPronunciationDictionaryResponseModel> CreatePronunciationDictionariesAddFromRulesAsync(
            global::System.Collections.Generic.IList<global::G.AnyOf<global::G.PronunciationDictionaryAliasRuleRequestModel, global::G.PronunciationDictionaryPhonemeRuleRequestModel>> rules,
            string name,
            string? xiApiKey = default,
            string? description = default,
            global::G.BodyAddAPronunciationDictionaryV1PronunciationDictionariesAddFromRulesPostWorkspaceAccess? workspaceAccess = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}