//HintName: G.IVoicesClient.GetV2Voices.g.cs
#nullable enable

namespace G
{
    public partial interface IVoicesClient
    {
        /// <summary>
        /// Get Voices V2<br/>
        /// Gets a list of all available voices for a user with search, filtering and pagination.
        /// </summary>
        /// <param name="nextPageToken">
        /// The next page token to use for pagination. Returned from the previous request.
        /// </param>
        /// <param name="pageSize">
        /// How many voices to return at maximum. Can not exceed 100, defaults to 10. Page 0 may include more voices due to default voices being included.<br/>
        /// Default Value: 10
        /// </param>
        /// <param name="search">
        /// Search term to filter voices by. Searches in name, description, labels, category.
        /// </param>
        /// <param name="sort">
        /// Which field to sort by, one of 'created_at_unix' or 'name'. 'created_at_unix' may not be available for older voices.
        /// </param>
        /// <param name="sortDirection">
        /// Which direction to sort the voices in. 'asc' or 'desc'.
        /// </param>
        /// <param name="voiceType">
        /// Type of the voice to filter by. One of 'personal', 'community', 'default', 'workspace', 'non-default'. 'non-default' is equal to all but 'default'.
        /// </param>
        /// <param name="category">
        /// Category of the voice to filter by. One of 'premade', 'cloned', 'generated', 'professional'
        /// </param>
        /// <param name="fineTuningState">
        /// State of the voice's fine tuning to filter by. Applicable only to professional voices clones. One of 'draft', 'not_verified', 'not_started', 'queued', 'fine_tuning', 'fine_tuned', 'failed', 'delayed'
        /// </param>
        /// <param name="collectionId">
        /// Collection ID to filter voices by.
        /// </param>
        /// <param name="includeTotalCount">
        /// Whether to include the total count of voices found in the response. Incurs a performance cost.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetVoicesV2ResponseModel> GetV2VoicesAsync(
            string? nextPageToken = default,
            int? pageSize = default,
            string? search = default,
            string? sort = default,
            string? sortDirection = default,
            string? voiceType = default,
            string? category = default,
            string? fineTuningState = default,
            string? collectionId = default,
            bool? includeTotalCount = default,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}