//HintName: G.IProjectClient.ProjectUpdateProject.g.cs
#nullable enable

namespace G
{
    public partial interface IProjectClient
    {
        /// <summary>
        /// UpdateProject.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="projectId"></param>
        /// <param name="updatedTitle"></param>
        /// <param name="updatedDescription"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.Project> ProjectUpdateProjectAsync(
            string? token = default,
            global::System.Guid projectId = default,
            string? updatedTitle = default,
            string? updatedDescription = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}