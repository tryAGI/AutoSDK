//HintName: G.IBetaClient.DeleteAgentDataByQueryApiV1BetaAgentDataDeletePost.g.cs
#nullable enable

namespace G
{
    public partial interface IBetaClient
    {
        /// <summary>
        /// Delete Agent Data By Query<br/>
        /// Bulk delete agent data by query (deployment_name, collection, optional filters).
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.DeleteResponse> DeleteAgentDataByQueryApiV1BetaAgentDataDeletePostAsync(

            global::G.DeleteRequest request,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete Agent Data By Query<br/>
        /// Bulk delete agent data by query (deployment_name, collection, optional filters).
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="deploymentName">
        /// The agent deployment's name to delete data for
        /// </param>
        /// <param name="collection">
        /// The logical agent data collection to delete from<br/>
        /// Default Value: default
        /// </param>
        /// <param name="filter">
        /// Optional filters to select which items to delete
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.DeleteResponse> DeleteAgentDataByQueryApiV1BetaAgentDataDeletePostAsync(
            string deploymentName,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            string? collection = default,
            global::System.Collections.Generic.Dictionary<string, global::G.FilterOperation>? filter = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}