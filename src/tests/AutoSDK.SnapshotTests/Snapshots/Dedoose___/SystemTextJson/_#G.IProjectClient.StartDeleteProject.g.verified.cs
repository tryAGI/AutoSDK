//HintName: G.IProjectClient.StartDeleteProject.g.cs
#nullable enable

namespace G
{
    public partial interface IProjectClient
    {
        /// <summary>
        /// StartDeleteProject<br/>
        /// StartDeleteProject
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> StartDeleteProjectAsync(
            global::G.StartDeleteProjectRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// StartDeleteProject<br/>
        /// StartDeleteProject
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="userId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> StartDeleteProjectAsync(
            global::System.Guid projectId,
            global::System.Guid userId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}