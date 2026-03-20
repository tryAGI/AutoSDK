//HintName: G.IAccountClient.GetProjectAccessDetailsForUser2.g.cs
#nullable enable

namespace G
{
    public partial interface IAccountClient
    {
        /// <summary>
        /// Get Project Access Details<br/>
        /// Retrieves detailed information about a user's project access permissions.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.ProjectAccessDetails>> GetProjectAccessDetailsForUser2Async(
            global::System.Guid userId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}