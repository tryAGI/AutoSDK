//HintName: G.IProjectClient.UpdateProject.g.cs
#nullable enable

namespace G
{
    public partial interface IProjectClient
    {
        /// <summary>
        /// UpdateProject<br/>
        /// UpdateProject
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Project> UpdateProjectAsync(
            global::G.UpdateProjectRequest2 request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// UpdateProject<br/>
        /// UpdateProject
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="updatedTitle"></param>
        /// <param name="updatedDescription"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.Project> UpdateProjectAsync(
            global::System.Guid projectId,
            string updatedTitle,
            string updatedDescription,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}