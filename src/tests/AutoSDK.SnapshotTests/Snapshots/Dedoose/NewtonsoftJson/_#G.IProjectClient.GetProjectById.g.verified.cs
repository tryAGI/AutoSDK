//HintName: G.IProjectClient.GetProjectById.g.cs
#nullable enable

namespace G
{
    public partial interface IProjectClient
    {
        /// <summary>
        /// GetProjectById<br/>
        /// GetProjectById
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Project> GetProjectByIdAsync(
            global::G.GetProjectByIdRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// GetProjectById<br/>
        /// GetProjectById
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.Project> GetProjectByIdAsync(
            global::System.Guid projectId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}