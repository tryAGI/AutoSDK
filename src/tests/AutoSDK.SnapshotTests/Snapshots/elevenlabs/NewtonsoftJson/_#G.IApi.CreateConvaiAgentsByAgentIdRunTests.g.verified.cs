//HintName: G.IApi.CreateConvaiAgentsByAgentIdRunTests.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {

        /// <summary>
        /// Run Tests On The Agent<br/>
        /// Run selected tests on the agent with provided configuration. If the agent configuration is provided, it will be used to override default agent configuration.
        /// </summary>
        /// <param name="agentId">
        /// The id of an agent. This is returned on agent creation.
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programmatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>

        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetTestSuiteInvocationResponseModel> CreateConvaiAgentsByAgentIdRunTestsAsync(
            string agentId,

            global::G.RunAgentTestsRequestModel request,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Run Tests On The Agent<br/>
        /// Run selected tests on the agent with provided configuration. If the agent configuration is provided, it will be used to override default agent configuration.
        /// </summary>
        /// <param name="agentId">
        /// The id of an agent. This is returned on agent creation.
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programmatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="tests">
        /// List of tests to run on the agent
        /// </param>
        /// <param name="agentConfigOverride">
        /// Configuration overrides to use for testing. If not provided, the agent's default configuration will be used.
        /// </param>
        /// <param name="branchId">
        /// ID of the branch to run the tests on. If not provided, the tests will be run on the agent default configuration.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetTestSuiteInvocationResponseModel> CreateConvaiAgentsByAgentIdRunTestsAsync(
            string agentId,
            global::System.Collections.Generic.IList<global::G.SingleTestRunRequestModel> tests,
            string? xiApiKey = default,
            global::G.AdhocAgentConfigOverrideForTestRequestModel? agentConfigOverride = default,
            string? branchId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}