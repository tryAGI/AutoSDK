//HintName: G.ISpeechHistoryClient.GetGeneratedItemsV1HistoryGet.g.cs
#nullable enable

namespace G
{
    public partial interface ISpeechHistoryClient
    {
        /// <summary>
        /// Get Generated Items<br/>
        /// Returns metadata about all your generated audio.
        /// </summary>
        /// <param name="pageSize">
        /// How many history items to return at maximum. Can not exceed 1000, defaults to 100.<br/>
        /// Default Value: 100
        /// </param>
        /// <param name="startAfterHistoryItemId">
        /// After which ID to start fetching, use this parameter to paginate across a large collection of history items. In case this parameter is not provided history items will be fetched starting from the most recently created one ordered descending by their creation date.
        /// </param>
        /// <param name="voiceId">
        /// Voice ID to be filtered for, you can use GET https://api.elevenlabs.io/v1/voices to receive a list of voices and their IDs.
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetSpeechHistoryResponseModel> GetGeneratedItemsV1HistoryGetAsync(
            int? pageSize = 100,
            string? startAfterHistoryItemId = default,
            string? voiceId = default,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}