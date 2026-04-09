//HintName: G.IApi.GetExecutionEngineVersionsWorkflowsExecutionEngineVersionsGet.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Returns available Execution Engine versions sorted from oldest to newest<br/>
        /// Returns available Execution Engine versions sorted from oldest to newest
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ExecutionEngineVersions> GetExecutionEngineVersionsWorkflowsExecutionEngineVersionsGetAsync(
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}