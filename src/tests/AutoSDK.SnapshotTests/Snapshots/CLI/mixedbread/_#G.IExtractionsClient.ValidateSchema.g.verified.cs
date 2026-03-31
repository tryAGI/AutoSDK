//HintName: G.IExtractionsClient.ValidateSchema.g.cs
#nullable enable

namespace G
{
    public partial interface IExtractionsClient
    {
        /// <summary>
        /// Validate a schema<br/>
        /// Validate a schema.<br/>
        /// Args:<br/>
        ///     params: The parameters for validating a schema.<br/>
        /// Returns:<br/>
        ///     The validation result.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ValidatedJsonSchema> ValidateSchemaAsync(

            global::G.JsonSchemaValidateParams request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Validate a schema<br/>
        /// Validate a schema.<br/>
        /// Args:<br/>
        ///     params: The parameters for validating a schema.<br/>
        /// Returns:<br/>
        ///     The validation result.
        /// </summary>
        /// <param name="jsonSchema">
        /// The JSON schema to validate
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ValidatedJsonSchema> ValidateSchemaAsync(
            object jsonSchema,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}