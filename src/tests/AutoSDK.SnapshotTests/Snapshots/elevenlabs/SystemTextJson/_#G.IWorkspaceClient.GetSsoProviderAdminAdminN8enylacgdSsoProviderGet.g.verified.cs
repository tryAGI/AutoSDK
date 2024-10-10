//HintName: G.IWorkspaceClient.GetSsoProviderAdminAdminN8enylacgdSsoProviderGet.g.cs
#nullable enable

namespace G
{
    public partial interface IWorkspaceClient
    {
        /// <summary>
        /// Get Sso Provider Admin
        /// </summary>
        /// <param name="workspaceId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.SsoProviderResponseModel> GetSsoProviderAdminAdminN8enylacgdSsoProviderGetAsync(
            string workspaceId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}