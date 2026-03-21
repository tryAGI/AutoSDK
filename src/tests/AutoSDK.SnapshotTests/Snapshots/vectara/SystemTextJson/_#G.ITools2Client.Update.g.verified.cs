//HintName: G.ITools2Client.Update.g.cs
#nullable enable

namespace G
{
    public partial interface ITools2Client
    {
        /// <summary>
        /// Update tool<br/>
        /// Update an existing tool’s configuration, including its metadata, enabled status, or other properties. Updating a tool modifies how agents can invoke it during conversation.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="toolId">
        /// Example: tol_rag_search
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Tool> UpdateAsync(
            string toolId,

            global::G.UpdateToolRequest request,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}