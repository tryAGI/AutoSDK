//HintName: G.ILlamaExtractClient.GenerateExtractionSchemaApiV1ExtractionExtractionAgentsSchemaGeneratePost.g.cs
#nullable enable

namespace G
{
    public partial interface ILlamaExtractClient
    {
        /// <summary>
        /// Generate Extraction Schema<br/>
        /// Generates or refines an extraction agent's schema definition from a file, natural language prompt,<br/>
        /// or existing schema.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ExtractSchemaGenerateResponse> GenerateExtractionSchemaApiV1ExtractionExtractionAgentsSchemaGeneratePostAsync(

            global::G.ExtractSchemaGenerateRequest request,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate Extraction Schema<br/>
        /// Generates or refines an extraction agent's schema definition from a file, natural language prompt,<br/>
        /// or existing schema.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="prompt">
        /// Natural language description of the data structure to extract
        /// </param>
        /// <param name="fileId">
        /// Optional file ID to analyze for schema generation
        /// </param>
        /// <param name="dataSchema">
        /// Optional schema to validate, refine, or extend during generation
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ExtractSchemaGenerateResponse> GenerateExtractionSchemaApiV1ExtractionExtractionAgentsSchemaGeneratePostAsync(
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            string? prompt = default,
            global::System.Guid? fileId = default,
            global::G.AnyOf<object, string, object>? dataSchema = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}