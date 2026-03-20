//HintName: G.IHistoryClient.List.g.cs
#nullable enable

namespace G
{
    public partial interface IHistoryClient
    {
        /// <summary>
        /// List Generated Items<br/>
        /// Returns a list of your generated audio.
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
        /// <param name="modelId">
        /// Model ID to filter history items by.
        /// </param>
        /// <param name="dateBeforeUnix">
        /// Unix timestamp to filter history items before this date (exclusive).
        /// </param>
        /// <param name="dateAfterUnix">
        /// Unix timestamp to filter history items after this date (inclusive).
        /// </param>
        /// <param name="sortDirection">
        /// Sort direction for the results.<br/>
        /// Default Value: desc
        /// </param>
        /// <param name="search">
        /// search term used for filtering
        /// </param>
        /// <param name="source">
        /// Source of the generated history item
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programmatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetSpeechHistoryResponseModel> ListAsync(
            int? pageSize = default,
            string? startAfterHistoryItemId = default,
            string? voiceId = default,
            string? modelId = default,
            int? dateBeforeUnix = default,
            int? dateAfterUnix = default,
            global::G.GetSpeechHistorySortDirection2? sortDirection = default,
            string? search = default,
            global::G.GetSpeechHistorySource2? source = default,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}