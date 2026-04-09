//HintName: G.ILlamaExtractClient.RunJobOnFileApiV1ExtractionJobsFilePost.g.cs
#nullable enable

namespace G
{
    public partial interface ILlamaExtractClient
    {
        /// <summary>
        /// Run Job On File
        /// </summary>
        /// <param name="fromUi">
        /// Default Value: false
        /// </param>
        /// <param name="session"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ExtractJob> RunJobOnFileApiV1ExtractionJobsFilePostAsync(

            global::G.BodyRunJobOnFileApiV1ExtractionJobsFilePost request,
            bool? fromUi = default,
            string? session = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Run Job On File
        /// </summary>
        /// <param name="fromUi">
        /// Default Value: false
        /// </param>
        /// <param name="session"></param>
        /// <param name="extractionAgentId">
        /// The id of the extraction agent
        /// </param>
        /// <param name="file">
        /// The file to run the job on
        /// </param>
        /// <param name="filename">
        /// The file to run the job on
        /// </param>
        /// <param name="dataSchemaOverride">
        /// The data schema to override the extraction agent's data schema with as a JSON string
        /// </param>
        /// <param name="configOverride">
        /// The config to override the extraction agent's config with as a JSON string
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ExtractJob> RunJobOnFileApiV1ExtractionJobsFilePostAsync(
            global::System.Guid extractionAgentId,
            byte[] file,
            string filename,
            bool? fromUi = default,
            string? session = default,
            string? dataSchemaOverride = default,
            string? configOverride = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}