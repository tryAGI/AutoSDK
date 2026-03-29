//HintName: G.IProjectsClient.UpdateProject.g.cs
#nullable enable

namespace G
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Update project by id<br/>
        /// Update project by id
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task UpdateProjectAsync(
            global::System.Guid id,

            global::G.ProjectUpdate request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update project by id<br/>
        /// Update project by id
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="visibility"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task UpdateProjectAsync(
            global::System.Guid id,
            string? name = default,
            string? description = default,
            global::G.ProjectUpdateVisibility? visibility = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}