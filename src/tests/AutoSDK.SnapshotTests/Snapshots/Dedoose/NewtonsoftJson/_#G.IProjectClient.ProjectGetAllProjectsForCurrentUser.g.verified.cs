//HintName: G.IProjectClient.ProjectGetAllProjectsForCurrentUser.g.cs
#nullable enable

namespace G
{
    public partial interface IProjectClient
    {
        /// <summary>
        /// GetAllProjectsForCurrentUser.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.Project>> ProjectGetAllProjectsForCurrentUserAsync(
            string? token = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}