//HintName: G.IScimClient.ScimGetSchemas.g.cs
#nullable enable

namespace G
{
    public partial interface IScimClient
    {
        /// <summary>
        /// Get SCIM Schemas (requires organization-scoped API key)
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.SchemasResponse> ScimGetSchemasAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}