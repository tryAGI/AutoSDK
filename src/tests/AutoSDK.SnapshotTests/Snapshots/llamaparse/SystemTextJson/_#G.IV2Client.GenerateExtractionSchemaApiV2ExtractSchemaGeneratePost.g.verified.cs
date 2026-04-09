//HintName: G.IV2Client.GenerateExtractionSchemaApiV2ExtractSchemaGeneratePost.g.cs
#nullable enable

namespace G
{
    public partial interface IV2Client
    {
        /// <summary>
        /// Generate Extraction Schema<br/>
        /// Generate a JSON schema and return a product configuration request.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ConfigurationCreateRequest> GenerateExtractionSchemaApiV2ExtractSchemaGeneratePostAsync(

            global::G.ExtractV2SchemaGenerateRequest request,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate Extraction Schema<br/>
        /// Generate a JSON schema and return a product configuration request.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="name">
        /// Name for the generated configuration (auto-generated if omitted)
        /// </param>
        /// <param name="prompt">
        /// Natural language description of the data structure to extract
        /// </param>
        /// <param name="fileId">
        /// Optional file ID to analyze for schema generation
        /// </param>
        /// <param name="dataSchema">
        /// Optional schema to validate, refine, or extend
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ConfigurationCreateRequest> GenerateExtractionSchemaApiV2ExtractSchemaGeneratePostAsync(
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            string? name = default,
            string? prompt = default,
            string? fileId = default,
            object? dataSchema = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}