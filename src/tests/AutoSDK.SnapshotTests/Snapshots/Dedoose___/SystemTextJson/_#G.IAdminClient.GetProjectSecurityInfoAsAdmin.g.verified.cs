//HintName: G.IAdminClient.GetProjectSecurityInfoAsAdmin.g.cs
#nullable enable

namespace G
{
    public partial interface IAdminClient
    {
        /// <summary>
        /// GetProjectSecurityInfo<br/>
        /// GetProjectSecurityInfo
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> GetProjectSecurityInfoAsAdminAsync(
            global::G.GetProjectSecurityInfoRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// GetProjectSecurityInfo<br/>
        /// GetProjectSecurityInfo
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> GetProjectSecurityInfoAsAdminAsync(
            global::System.Guid projectId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}