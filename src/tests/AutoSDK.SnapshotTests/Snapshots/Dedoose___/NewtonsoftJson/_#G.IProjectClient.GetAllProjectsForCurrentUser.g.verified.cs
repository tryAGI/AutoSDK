//HintName: G.IProjectClient.GetAllProjectsForCurrentUser.g.cs
#nullable enable

namespace G
{
    public partial interface IProjectClient
    {
        /// <summary>
        /// GetAllProjectsForCurrentUser<br/>
        /// GetAllProjectsForCurrentUser
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.Project>> GetAllProjectsForCurrentUserAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}