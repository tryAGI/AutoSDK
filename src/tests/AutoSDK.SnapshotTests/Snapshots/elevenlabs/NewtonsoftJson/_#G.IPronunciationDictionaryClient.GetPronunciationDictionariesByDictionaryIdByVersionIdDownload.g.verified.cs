//HintName: G.IPronunciationDictionaryClient.GetPronunciationDictionariesByDictionaryIdByVersionIdDownload.g.cs
#nullable enable

namespace G
{
    public partial interface IPronunciationDictionaryClient
    {
        /// <summary>
        /// Get A Pls File With A Pronunciation Dictionary Version Rules<br/>
        /// Get a PLS file with a pronunciation dictionary version rules
        /// </summary>
        /// <param name="dictionaryId">
        /// The id of the pronunciation dictionary<br/>
        /// Example: 21m00Tcm4TlvDq8ikWAM
        /// </param>
        /// <param name="versionId">
        /// The id of the version of the pronunciation dictionary<br/>
        /// Example: BdF0s0aZ3oFoKnDYdTox
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<byte[]> GetPronunciationDictionariesByDictionaryIdByVersionIdDownloadAsync(
            string dictionaryId,
            string versionId,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}