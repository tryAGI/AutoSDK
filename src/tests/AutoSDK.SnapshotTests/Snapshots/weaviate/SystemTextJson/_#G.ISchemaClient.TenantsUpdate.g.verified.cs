//HintName: G.ISchemaClient.TenantsUpdate.g.cs
#nullable enable

namespace G
{
    public partial interface ISchemaClient
    {
        /// <summary>
        /// Update a tenant.<br/>
        /// Update a tenant for a collection
        /// </summary>
        /// <param name="className"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.Tenant>> TenantsUpdateAsync(
            string className,
            global::System.Collections.Generic.IList<global::G.Tenant> request,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}