//HintName: G.ILlamaExtractClient.RunJobApiV1ExtractionJobsPost.g.cs
#nullable enable

namespace G
{
    public partial interface ILlamaExtractClient
    {
        /// <summary>
        /// Run Job
        /// </summary>
        /// <param name="fromUi">
        /// Default Value: false
        /// </param>
        /// <param name="session"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ExtractJob> RunJobApiV1ExtractionJobsPostAsync(

            global::G.ExtractJobCreate request,
            bool? fromUi = default,
            string? session = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Run Job
        /// </summary>
        /// <param name="fromUi">
        /// Default Value: false
        /// </param>
        /// <param name="session"></param>
        /// <param name="priority">
        /// The priority for the request. This field may be ignored or overwritten depending on the organization tier.
        /// </param>
        /// <param name="webhookConfigurations">
        /// Outbound webhook endpoints to notify on job status changes
        /// </param>
        /// <param name="extractionAgentId">
        /// The id of the extraction agent
        /// </param>
        /// <param name="fileId">
        /// The id of the file
        /// </param>
        /// <param name="dataSchemaOverride">
        /// The data schema to override the extraction agent's data schema with
        /// </param>
        /// <param name="configOverride">
        /// The config to override the extraction agent's config with
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ExtractJob> RunJobApiV1ExtractionJobsPostAsync(
            global::System.Guid extractionAgentId,
            global::System.Guid fileId,
            bool? fromUi = default,
            string? session = default,
            global::G.ExtractJobCreatePriority2? priority = default,
            global::System.Collections.Generic.IList<global::G.WebhookConfiguration>? webhookConfigurations = default,
            global::G.AnyOf<object, string, object>? dataSchemaOverride = default,
            global::G.ExtractConfig? configOverride = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}