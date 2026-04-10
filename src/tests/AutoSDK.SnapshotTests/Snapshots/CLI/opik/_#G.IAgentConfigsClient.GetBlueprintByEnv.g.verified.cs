//HintName: G.IAgentConfigsClient.GetBlueprintByEnv.g.cs
#nullable enable

namespace G
{
    public partial interface IAgentConfigsClient
    {
        /// <summary>
        /// Retrieve blueprint by environment<br/>
        /// Retrieves the blueprint associated with a specific environment
        /// </summary>
        /// <param name="envName"></param>
        /// <param name="projectId"></param>
        /// <param name="maskId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AgentBlueprintPublic> GetBlueprintByEnvAsync(
            string envName,
            global::System.Guid projectId,
            global::System.Guid? maskId = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}