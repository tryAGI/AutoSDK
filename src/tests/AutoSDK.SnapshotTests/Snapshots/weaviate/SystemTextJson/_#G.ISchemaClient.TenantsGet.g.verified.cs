//HintName: G.ISchemaClient.TenantsGet.g.cs
#nullable enable

namespace G
{
    public partial interface ISchemaClient
    {
        /// <summary>
        /// Get the list of tenants.<br/>
        /// Get all tenants from a collection.
        /// </summary>
        /// <param name="className"></param>
        /// <param name="consistency">
        /// Default Value: true
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.Tenant>> TenantsGetAsync(
            string className,
            bool? consistency = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}