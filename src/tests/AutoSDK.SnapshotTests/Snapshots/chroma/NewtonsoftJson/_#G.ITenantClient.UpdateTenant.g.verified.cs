//HintName: G.ITenantClient.UpdateTenant.g.cs
#nullable enable

namespace G
{
    public partial interface ITenantClient
    {
        /// <summary>
        /// Update tenant<br/>
        /// Updates an existing tenant by name.
        /// </summary>
        /// <param name="tenantName"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.UpdateTenantResponse> UpdateTenantAsync(
            string tenantName,

            global::G.UpdateTenantPayload request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update tenant<br/>
        /// Updates an existing tenant by name.
        /// </summary>
        /// <param name="tenantName"></param>
        /// <param name="resourceName"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.UpdateTenantResponse> UpdateTenantAsync(
            string tenantName,
            string resourceName,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}