//HintName: G.IMetadataClient.MetadataSendFeedback.g.cs
#nullable enable

namespace G
{
    public partial interface IMetadataClient
    {
        /// <summary>
        /// Send user feedback<br/>
        /// Send feedback from users to improve our services.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.MetadataSendFeedbackResponse> MetadataSendFeedbackAsync(

            global::G.MetadataSendFeedbackRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Send user feedback<br/>
        /// Send feedback from users to improve our services.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="feature">
        /// Default Value: letta-code
        /// </param>
        /// <param name="agentId"></param>
        /// <param name="sessionId"></param>
        /// <param name="version"></param>
        /// <param name="platform"></param>
        /// <param name="settings"></param>
        /// <param name="localTime"></param>
        /// <param name="deviceType"></param>
        /// <param name="cwd"></param>
        /// <param name="totalApiMs"></param>
        /// <param name="totalWallMs"></param>
        /// <param name="stepCount"></param>
        /// <param name="promptTokens"></param>
        /// <param name="completionTokens"></param>
        /// <param name="totalTokens"></param>
        /// <param name="cachedInputTokens"></param>
        /// <param name="cacheWriteTokens"></param>
        /// <param name="reasoningTokens"></param>
        /// <param name="contextTokens"></param>
        /// <param name="agentName"></param>
        /// <param name="agentDescription"></param>
        /// <param name="model"></param>
        /// <param name="billingTier"></param>
        /// <param name="recentChunks"></param>
        /// <param name="debugLogTail"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.MetadataSendFeedbackResponse> MetadataSendFeedbackAsync(
            string message,
            global::G.MetadataSendFeedbackRequestFeature? feature = default,
            string? agentId = default,
            string? sessionId = default,
            string? version = default,
            string? platform = default,
            string? settings = default,
            string? localTime = default,
            string? deviceType = default,
            string? cwd = default,
            double? totalApiMs = default,
            double? totalWallMs = default,
            double? stepCount = default,
            double? promptTokens = default,
            double? completionTokens = default,
            double? totalTokens = default,
            double? cachedInputTokens = default,
            double? cacheWriteTokens = default,
            double? reasoningTokens = default,
            double? contextTokens = default,
            string? agentName = default,
            string? agentDescription = default,
            string? model = default,
            string? billingTier = default,
            global::System.Collections.Generic.IList<object>? recentChunks = default,
            string? debugLogTail = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}