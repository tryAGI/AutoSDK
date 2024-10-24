//HintName: G.IPronunciationDictionaryClient.GetPronunciationDictionaries.g.cs
#nullable enable

namespace G
{
    public partial interface IPronunciationDictionaryClient
    {
        /// <summary>
        /// Get Pronunciation Dictionaries<br/>
        /// Get a list of the pronunciation dictionaries you have access to and their metadata
        /// </summary>
        /// <param name="cursor">
        /// Used for fetching next page. Cursor is returned in the response.
        /// </param>
        /// <param name="pageSize">
        /// How many pronunciation dictionaries to return at maximum. Can not exceed 100, defaults to 30.<br/>
        /// Default Value: 30
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetPronunciationDictionariesMetadataResponseModel> GetPronunciationDictionariesAsync(
            string? cursor = default,
            int? pageSize = default,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}