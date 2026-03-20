//HintName: G.IApi.PutConvaiAgentTestingByTestId.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Update Agent Response Test<br/>
        /// Updates an agent response test by ID.
        /// </summary>
        /// <param name="testId">
        /// The id of a chat response test. This is returned on test creation.
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programmatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.UpdateAgentResponseTestRouteResponse> PutConvaiAgentTestingByTestIdAsync(
            string testId,

            global::G.AnyOf<global::G.UpdateResponseUnitTestRequest, global::G.UpdateToolCallUnitTestRequest, global::G.UpdateSimulationTestRequest> request,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Agent Response Test<br/>
        /// Updates an agent response test by ID.
        /// </summary>
        /// <param name="testId">
        /// The id of a chat response test. This is returned on test creation.
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programmatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.UpdateAgentResponseTestRouteResponse> PutConvaiAgentTestingByTestIdAsync(
            string testId,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}