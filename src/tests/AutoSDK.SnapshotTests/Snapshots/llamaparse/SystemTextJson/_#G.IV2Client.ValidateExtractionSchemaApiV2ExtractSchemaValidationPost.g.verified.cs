//HintName: G.IV2Client.ValidateExtractionSchemaApiV2ExtractSchemaValidationPost.g.cs
#nullable enable

namespace G
{
    public partial interface IV2Client
    {
        /// <summary>
        /// Validate Extraction Schema<br/>
        /// Validate a JSON schema for extraction.
        /// </summary>
        /// <param name="session"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ExtractV2SchemaValidateResponse> ValidateExtractionSchemaApiV2ExtractSchemaValidationPostAsync(

            global::G.ExtractV2SchemaValidateRequest request,
            string? session = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Validate Extraction Schema<br/>
        /// Validate a JSON schema for extraction.
        /// </summary>
        /// <param name="session"></param>
        /// <param name="dataSchema">
        /// JSON Schema to validate for use with extract jobs
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ExtractV2SchemaValidateResponse> ValidateExtractionSchemaApiV2ExtractSchemaValidationPostAsync(
            object dataSchema,
            string? session = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}