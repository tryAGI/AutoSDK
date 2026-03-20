//HintName: G.ISchemasClient.GetSchemas.g.cs
#nullable enable

namespace G
{
    public partial interface ISchemasClient
    {

        /// <summary>
        /// Get schemas
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.SchemaDefinition> GetSchemasAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}