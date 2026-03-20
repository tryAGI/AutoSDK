//HintName: G.ITools2Client.Delete.g.cs
#nullable enable

namespace G
{
    public partial interface ITools2Client
    {
        /// <summary>
        /// Delete tool<br/>
        /// Permanently delete a tool and its configuration. This action cannot be undone. Agents attempting to use a deleted tool will fail, so ensure that agent configurations are updated before removing a tool.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="toolId">
        /// Example: tol_rag_search
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteAsync(
            string toolId,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}