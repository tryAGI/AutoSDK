//HintName: G.IApi.Resubmit.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Resubmit Tests<br/>
        /// Resubmits specific test runs from a test invocation.
        /// </summary>
        /// <param name="testInvocationId">
        /// The id of a test invocation. This is returned when tests are run.
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programmatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> ResubmitAsync(
            string testInvocationId,

            global::G.ResubmitTestsRequestModel request,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Resubmit Tests<br/>
        /// Resubmits specific test runs from a test invocation.
        /// </summary>
        /// <param name="testInvocationId">
        /// The id of a test invocation. This is returned when tests are run.
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programmatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="testRunIds">
        /// List of test run IDs to resubmit
        /// </param>
        /// <param name="agentConfigOverride">
        /// Configuration overrides to use for testing. If not provided, the agent's default configuration will be used.
        /// </param>
        /// <param name="agentId">
        /// Agent ID to resubmit tests for
        /// </param>
        /// <param name="branchId">
        /// ID of the branch to run the tests on. If not provided, the tests will be run on the agent default configuration.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> ResubmitAsync(
            string testInvocationId,
            global::System.Collections.Generic.IList<string> testRunIds,
            string agentId,
            string? xiApiKey = default,
            global::G.AdhocAgentConfigOverrideForTestRequestModel? agentConfigOverride = default,
            string? branchId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}