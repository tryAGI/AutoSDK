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
        /// <param name="sort">
        /// Which field to sort by, one of 'created_at_unix' or 'name'.<br/>
        /// Default Value: creation_time_unix<br/>
        /// Example: creation_time_unix
        /// </param>
        /// <param name="sortDirection">
        /// Which direction to sort the voices in. 'ascending' or 'descending'.<br/>
        /// Default Value: DESCENDING<br/>
        /// Example: descending
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetPronunciationDictionariesMetadataResponseModel> GetPronunciationDictionariesAsync(
            string? cursor = default,
            int? pageSize = default,
            global::G.GetPronunciationDictionariesV1PronunciationDictionariesGetSort? sort = default,
            string? sortDirection = default,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}