//HintName: G.ISpeechHistoryClient.GetHistoryByHistoryItemId.g.cs
#nullable enable

namespace G
{
    public partial interface ISpeechHistoryClient
    {
        /// <summary>
        /// Get History Item<br/>
        /// Retrieves a history item.
        /// </summary>
        /// <param name="historyItemId">
        /// History item ID to be used, you can use GET https://api.elevenlabs.io/v1/history to receive a list of history items and their IDs.<br/>
        /// Example: VW7YKqPnjY4h39yTbx2L
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.SpeechHistoryItemResponseModel> GetHistoryByHistoryItemIdAsync(
            string historyItemId,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}