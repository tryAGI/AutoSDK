//HintName: G.ISchemasClient.GetMxbaiJsonSchema.g.cs
#nullable enable

namespace G
{
    public partial interface ISchemasClient
    {
        /// <summary>
        /// Get mxbai json schema<br/>
        /// Get the mxbai json schema.<br/>
        /// Returns:<br/>
        ///     The mxbai json schema.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> GetMxbaiJsonSchemaAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}