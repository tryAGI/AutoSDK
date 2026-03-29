//HintName: G.IProjectsClient.Get2.g.cs
#nullable enable

namespace G
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Get project members<br/>
        /// Retrieve the members for a specific project. Optionally filter by user IDs (comma-separated).<br/>
        /// Does NOT include annotators. Deprecated; use paginated endpoint.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="userIds"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        [global::System.Obsolete("This method marked as deprecated.")]
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.LseUser>> Get2Async(
            int id,
            string? userIds = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}