//HintName: G.ILlamaExtractClient.ValidateExtractionSchemaApiV1ExtractionExtractionAgentsSchemaValidationPost.g.cs
#nullable enable

namespace G
{
    public partial interface ILlamaExtractClient
    {
        /// <summary>
        /// Validate Extraction Schema<br/>
        /// Validates an extraction agent's schema definition.<br/>
        /// Returns the normalized and validated schema if valid, otherwise raises an HTTP 400.
        /// </summary>
        /// <param name="session"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ExtractSchemaValidateResponse> ValidateExtractionSchemaApiV1ExtractionExtractionAgentsSchemaValidationPostAsync(

            global::G.ExtractSchemaValidateRequest request,
            string? session = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Validate Extraction Schema<br/>
        /// Validates an extraction agent's schema definition.<br/>
        /// Returns the normalized and validated schema if valid, otherwise raises an HTTP 400.
        /// </summary>
        /// <param name="session"></param>
        /// <param name="dataSchema"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ExtractSchemaValidateResponse> ValidateExtractionSchemaApiV1ExtractionExtractionAgentsSchemaValidationPostAsync(
            global::G.AnyOf<object, string> dataSchema,
            string? session = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}