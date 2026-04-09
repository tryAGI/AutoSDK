//HintName: G.INumbersClient.UpdateInboundNumber.g.cs
#nullable enable

namespace G
{
    public partial interface INumbersClient
    {
        /// <summary>
        /// Update Inbound Number<br/>
        /// Update the configuration for an inbound phone number.
        /// </summary>
        /// <param name="phoneNumber"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.StatusResponse> UpdateInboundNumberAsync(
            string phoneNumber,

            global::G.UpdateInboundNumberRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Inbound Number<br/>
        /// Update the configuration for an inbound phone number.
        /// </summary>
        /// <param name="phoneNumber"></param>
        /// <param name="prompt">
        /// Instructions and context for the agent during inbound calls
        /// </param>
        /// <param name="voice">
        /// Voice ID or preset name
        /// </param>
        /// <param name="firstSentence">
        /// Opening phrase for the agent
        /// </param>
        /// <param name="model"></param>
        /// <param name="language">
        /// Language code (default en-US)
        /// </param>
        /// <param name="timezone">
        /// Default Value: America/Los_Angeles
        /// </param>
        /// <param name="backgroundTrack"></param>
        /// <param name="blockInterruptions"></param>
        /// <param name="interruptionThreshold"></param>
        /// <param name="noiseCancellation"></param>
        /// <param name="transferPhoneNumber"></param>
        /// <param name="transferList"></param>
        /// <param name="fallbackNumber">
        /// Redirect number during maintenance
        /// </param>
        /// <param name="requestData"></param>
        /// <param name="dynamicData"></param>
        /// <param name="maxDuration">
        /// Default Value: 30
        /// </param>
        /// <param name="record"></param>
        /// <param name="webhook"></param>
        /// <param name="webhookEvents"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.StatusResponse> UpdateInboundNumberAsync(
            string phoneNumber,
            string prompt,
            string? voice = default,
            string? firstSentence = default,
            global::G.UpdateInboundNumberRequestModel? model = default,
            string? language = default,
            string? timezone = default,
            global::G.UpdateInboundNumberRequestBackgroundTrack? backgroundTrack = default,
            bool? blockInterruptions = default,
            int? interruptionThreshold = default,
            bool? noiseCancellation = default,
            string? transferPhoneNumber = default,
            global::System.Collections.Generic.Dictionary<string, string>? transferList = default,
            string? fallbackNumber = default,
            object? requestData = default,
            global::System.Collections.Generic.IList<object>? dynamicData = default,
            int? maxDuration = default,
            bool? record = default,
            string? webhook = default,
            global::System.Collections.Generic.IList<string>? webhookEvents = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}