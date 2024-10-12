//HintName: G.IProjectClient.ProjectRenameProject.g.cs
#nullable enable

namespace G
{
    public partial interface IProjectClient
    {
        /// <summary>
        /// RenameProject.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="projectId"></param>
        /// <param name="newTitle"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> ProjectRenameProjectAsync(
            string? token = default,
            global::System.Guid? projectId = default,
            string? newTitle = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}