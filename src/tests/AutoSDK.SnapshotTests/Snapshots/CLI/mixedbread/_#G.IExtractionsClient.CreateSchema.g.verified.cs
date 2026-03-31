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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreatedJsonSchema> CreateSchemaAsync(

            global::G.JsonSchemaCreateParams request,
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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreatedJsonSchema> CreateSchemaAsync(
            string description,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}