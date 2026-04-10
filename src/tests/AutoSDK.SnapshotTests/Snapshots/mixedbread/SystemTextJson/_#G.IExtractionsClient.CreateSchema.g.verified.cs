//HintName: G.IExtractionsClient.CreateSchema.g.cs
#nullable enable

namespace G
{
    public partial interface IExtractionsClient
    {
        /// <summary>
        /// Create a schema<br/>
        /// Create a schema with the provided parameters.<br/>
        /// Args:<br/>
        ///     params: The parameters for creating a schema.<br/>
        /// Returns:<br/>
        ///     The created schema.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreatedJsonSchema> CreateSchemaAsync(

            global::G.JsonSchemaCreateParams request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a schema<br/>
        /// Create a schema with the provided parameters.<br/>
        /// Args:<br/>
        ///     params: The parameters for creating a schema.<br/>
        /// Returns:<br/>
        ///     The created schema.
        /// </summary>
        /// <param name="description">
        /// Description of the data to extract
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreatedJsonSchema> CreateSchemaAsync(
            string description,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}