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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> GetMxbaiJsonSchemaAsync(
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}