//HintName: G.IProjectClient.GetProjectCopyJobProject.g.cs
#nullable enable

namespace G
{
    public partial interface IProjectClient
    {
        /// <summary>
        /// GetProjectCopyJobProject<br/>
        /// GetProjectCopyJobProject
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Project> GetProjectCopyJobProjectAsync(
            global::G.GetProjectCopyJobProjectRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// GetProjectCopyJobProject<br/>
        /// GetProjectCopyJobProject
        /// </summary>
        /// <param name="jobId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.Project> GetProjectCopyJobProjectAsync(
            string jobId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}