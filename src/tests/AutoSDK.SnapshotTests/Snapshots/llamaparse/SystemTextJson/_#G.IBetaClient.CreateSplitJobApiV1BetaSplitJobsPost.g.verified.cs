//HintName: G.IBetaClient.CreateSplitJobApiV1BetaSplitJobsPost.g.cs
#nullable enable

namespace G
{
    public partial interface IBetaClient
    {
        /// <summary>
        /// Create Split Job<br/>
        /// Create a document split job.<br/>
        /// Experimental: This endpoint is not yet ready for production use and is subject to change at any time.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.SplitJobResponse> CreateSplitJobApiV1BetaSplitJobsPostAsync(

            global::G.SplitCreateRequest request,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Split Job<br/>
        /// Create a document split job.<br/>
        /// Experimental: This endpoint is not yet ready for production use and is subject to change at any time.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="documentInput">
        /// Document to be split.
        /// </param>
        /// <param name="configuration">
        /// Inline split configuration.
        /// </param>
        /// <param name="configurationId">
        /// Saved split configuration ID.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.SplitJobResponse> CreateSplitJobApiV1BetaSplitJobsPostAsync(
            global::G.SplitDocumentInput documentInput,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            global::G.SplitConfiguration? configuration = default,
            string? configurationId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}