//HintName: G.ICheckClient.GetWorkspaceName.g.cs
#nullable enable

namespace G
{
    public partial interface ICheckClient
    {
        /// <summary>
        /// User's default workspace name<br/>
        /// User's default workspace name
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.WorkspaceNameHolder> GetWorkspaceNameAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}