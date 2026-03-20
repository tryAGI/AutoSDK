//HintName: G.IAgentsPlatformClient.Create8.g.cs
#nullable enable

namespace G
{
    public partial interface IAgentsPlatformClient
    {
        /// <summary>
        /// Submit A Batch Call Request.<br/>
        /// Submit a batch call request to schedule calls for multiple recipients.
        /// </summary>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programmatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.BatchCallResponse> Create8Async(

            global::G.BodySubmitABatchCallRequestV1ConvaiBatchCallingSubmitPost request,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Submit A Batch Call Request.<br/>
        /// Submit a batch call request to schedule calls for multiple recipients.
        /// </summary>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programmatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="callName"></param>
        /// <param name="agentId"></param>
        /// <param name="recipients"></param>
        /// <param name="scheduledTimeUnix"></param>
        /// <param name="agentPhoneNumberId"></param>
        /// <param name="whatsappParams"></param>
        /// <param name="timezone"></param>
        /// <param name="telephonyCallConfig">
        /// Default Value: {"ringing_timeout_secs":60}
        /// </param>
        /// <param name="targetConcurrencyLimit">
        /// Maximum number of simultaneous calls for this batch. When set, dispatch is governed by this limit rather than workspace/agent capacity percentages.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.BatchCallResponse> Create8Async(
            string callName,
            string agentId,
            global::System.Collections.Generic.IList<global::G.OutboundCallRecipient> recipients,
            string? xiApiKey = default,
            int? scheduledTimeUnix = default,
            string? agentPhoneNumberId = default,
            global::G.BatchCallWhatsAppParams? whatsappParams = default,
            string? timezone = default,
            global::G.TelephonyCallConfig? telephonyCallConfig = default,
            int? targetConcurrencyLimit = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}