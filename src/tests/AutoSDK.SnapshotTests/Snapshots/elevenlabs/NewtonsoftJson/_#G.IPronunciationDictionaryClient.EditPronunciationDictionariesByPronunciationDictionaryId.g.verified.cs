//HintName: G.IPronunciationDictionaryClient.EditPronunciationDictionariesByPronunciationDictionaryId.g.cs
#nullable enable

namespace G
{
    public partial interface IPronunciationDictionaryClient
    {
        /// <summary>
        /// Update Pronunciation Dictionary<br/>
        /// Partially update the pronunciation dictionary without changing the version
        /// </summary>
        /// <param name="pronunciationDictionaryId">
        /// The id of the pronunciation dictionary
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programmatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetPronunciationDictionaryMetadataResponseModel> EditPronunciationDictionariesByPronunciationDictionaryIdAsync(
            string pronunciationDictionaryId,

            global::G.BodyUpdatePronunciationDictionaryV1PronunciationDictionariesPronunciationDictionaryIdPatch request,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Update Pronunciation Dictionary<br/>
        /// Partially update the pronunciation dictionary without changing the version
        /// </summary>
        /// <param name="pronunciationDictionaryId">
        /// The id of the pronunciation dictionary
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programmatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="archived">
        /// Whether to archive the pronunciation dictionary.
        /// </param>
        /// <param name="name">
        /// The name of the pronunciation dictionary, used for identification only.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetPronunciationDictionaryMetadataResponseModel> EditPronunciationDictionariesByPronunciationDictionaryIdAsync(
            string pronunciationDictionaryId,
            string? xiApiKey = default,
            bool? archived = default,
            string? name = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}