//HintName: G.ISettingsClient.SetTenantHandle.g.cs
#nullable enable

namespace G
{
    public partial interface ISettingsClient
    {
        /// <summary>
        /// Set Tenant Handle<br/>
        /// Set tenant handle.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AppHubCrudTenantsTenant> SetTenantHandleAsync(
            global::G.SetTenantHandleRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Set Tenant Handle<br/>
        /// Set tenant handle.
        /// </summary>
        /// <param name="tenantHandle"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.AppHubCrudTenantsTenant> SetTenantHandleAsync(
            string tenantHandle,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}