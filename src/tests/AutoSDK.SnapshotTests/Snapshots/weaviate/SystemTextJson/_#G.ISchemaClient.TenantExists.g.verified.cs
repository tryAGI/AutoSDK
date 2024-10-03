//HintName: G.ISchemaClient.TenantExists.g.cs
#nullable enable

namespace G
{
    public partial interface ISchemaClient
    {
        /// <summary>
        /// Check whether a tenant exists<br/>
        /// Check if a tenant exists for a specific class
        /// </summary>
        /// <param name="className"></param>
        /// <param name="tenantName"></param>
        /// <param name="consistency">
        /// Default Value: true
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ErrorResponse> TenantExistsAsync(
            string className,
            string tenantName,
            bool? consistency = true,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}