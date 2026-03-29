//HintName: G.ITenantClient.CreateTenant.g.cs
#nullable enable

namespace G
{
    public partial interface ITenantClient
    {
        /// <summary>
        /// Create tenant<br/>
        /// Creates a new tenant.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateTenantResponse> CreateTenantAsync(

            global::G.CreateTenantPayload request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create tenant<br/>
        /// Creates a new tenant.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateTenantResponse> CreateTenantAsync(
            string name,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}