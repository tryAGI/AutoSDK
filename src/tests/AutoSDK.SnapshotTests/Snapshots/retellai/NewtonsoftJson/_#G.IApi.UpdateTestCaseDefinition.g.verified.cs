//HintName: G.IApi.UpdateTestCaseDefinition.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Update a test case definition
        /// </summary>
        /// <param name="testCaseDefinitionId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.TestCaseDefinition> UpdateTestCaseDefinitionAsync(
            string testCaseDefinitionId,

            global::G.TestCaseDefinitionInput request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a test case definition
        /// </summary>
        /// <param name="testCaseDefinitionId"></param>
        /// <param name="name">
        /// Name of the test case definition
        /// </param>
        /// <param name="responseEngine">
        /// Response engine for test cases. Custom LLM is not supported.
        /// </param>
        /// <param name="userPrompt">
        /// User prompt to simulate in the test case
        /// </param>
        /// <param name="metrics">
        /// Array of metric names to evaluate
        /// </param>
        /// <param name="dynamicVariables">
        /// Dynamic variables to inject into the response engine
        /// </param>
        /// <param name="toolMocks">
        /// Mock tool calls for testing
        /// </param>
        /// <param name="llmModel">
        /// Available LLM models for agents.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.TestCaseDefinition> UpdateTestCaseDefinitionAsync(
            string testCaseDefinitionId,
            string? name = default,
            global::G.RetellResponseEngine? responseEngine = default,
            string? userPrompt = default,
            global::System.Collections.Generic.IList<string>? metrics = default,
            global::System.Collections.Generic.Dictionary<string, string>? dynamicVariables = default,
            global::System.Collections.Generic.IList<global::G.ToolMock>? toolMocks = default,
            global::G.LLMModel? llmModel = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}