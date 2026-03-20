//HintName: G.IApi.CreateConvaiAgentTestingSummaries.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Get Agent Response Test Summaries By Ids<br/>
        /// Gets multiple agent response tests by their IDs. Returns a dictionary mapping test IDs to test summaries.
        /// </summary>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programmatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetTestsSummariesByIdsResponseModel> CreateConvaiAgentTestingSummariesAsync(

            global::G.ListTestsByIdsRequestModel request,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Agent Response Test Summaries By Ids<br/>
        /// Gets multiple agent response tests by their IDs. Returns a dictionary mapping test IDs to test summaries.
        /// </summary>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programmatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="testIds">
        /// List of test IDs to fetch. No duplicates allowed.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetTestsSummariesByIdsResponseModel> CreateConvaiAgentTestingSummariesAsync(
            global::System.Collections.Generic.IList<string> testIds,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}