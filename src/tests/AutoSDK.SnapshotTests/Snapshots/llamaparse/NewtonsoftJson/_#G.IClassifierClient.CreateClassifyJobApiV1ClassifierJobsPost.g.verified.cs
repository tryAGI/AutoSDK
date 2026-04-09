//HintName: G.IClassifierClient.CreateClassifyJobApiV1ClassifierJobsPost.g.cs
#nullable enable

namespace G
{
    public partial interface IClassifierClient
    {
        /// <summary>
        /// Create Classify Job<br/>
        /// Create a classify job.<br/>
        /// Experimental: This endpoint is not yet ready for production use and is subject to change at any time.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ClassifyJob> CreateClassifyJobApiV1ClassifierJobsPostAsync(

            global::G.ClassifyJobCreate request,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Classify Job<br/>
        /// Create a classify job.<br/>
        /// Experimental: This endpoint is not yet ready for production use and is subject to change at any time.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="rules">
        /// The rules to classify the files
        /// </param>
        /// <param name="mode">
        /// The classification mode to use<br/>
        /// Default Value: FAST
        /// </param>
        /// <param name="fileIds">
        /// The IDs of the files to classify
        /// </param>
        /// <param name="parsingConfiguration">
        /// The configuration for the parsing job<br/>
        /// Default Value: {"lang":"en","max_pages":5}
        /// </param>
        /// <param name="webhookConfigurations">
        /// List of webhook configurations for notifications
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ClassifyJob> CreateClassifyJobApiV1ClassifierJobsPostAsync(
            global::System.Collections.Generic.IList<global::G.ClassifierRule> rules,
            global::System.Collections.Generic.IList<global::System.Guid> fileIds,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            global::G.ClassifyMode? mode = default,
            global::G.ClassifyParsingConfiguration? parsingConfiguration = default,
            global::System.Collections.Generic.IList<global::G.LlamaParseWebhookConfiguration>? webhookConfigurations = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}