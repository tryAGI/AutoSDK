//HintName: G.IExtractionsClient.EnhanceSchema.g.cs
#nullable enable

namespace G
{
    public partial interface IExtractionsClient
    {
        /// <summary>
        /// Enhance a schema<br/>
        /// Enhance a schema by enriching the descriptions to aid extraction.<br/>
        /// Args:<br/>
        ///     params: The parameters for enhancing a schema.<br/>
        /// Returns:<br/>
        ///     The enhanced schema.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.EnhancedJsonSchema> EnhanceSchemaAsync(

            global::G.JsonSchemaEnhanceParams request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Enhance a schema<br/>
        /// Enhance a schema by enriching the descriptions to aid extraction.<br/>
        /// Args:<br/>
        ///     params: The parameters for enhancing a schema.<br/>
        /// Returns:<br/>
        ///     The enhanced schema.
        /// </summary>
        /// <param name="jsonSchema">
        /// The JSON schema to enhance
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.EnhancedJsonSchema> EnhanceSchemaAsync(
            object jsonSchema,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}