//HintName: G.ISchemaClient.TenantsDelete.g.cs
#nullable enable

namespace G
{
    public partial interface ISchemaClient
    {
        /// <summary>
        /// Delete tenant(s).<br/>
        /// Delete tenants from a collection
        /// </summary>
        /// <param name="className"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task TenantsDeleteAsync(
            string className,
            global::System.Collections.Generic.IList<string> request,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}