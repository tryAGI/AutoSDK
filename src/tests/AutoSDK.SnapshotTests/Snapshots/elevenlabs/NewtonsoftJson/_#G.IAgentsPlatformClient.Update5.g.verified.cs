//HintName: G.IAgentsPlatformClient.Update5.g.cs
#nullable enable

namespace G
{
    public partial interface IAgentsPlatformClient
    {
        /// <summary>
        /// Update Convai Settings<br/>
        /// Update Convai settings for the workspace
        /// </summary>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programmatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetConvAISettingsResponseModel> Update5Async(

            global::G.PatchConvAISettingsRequest request,
            string? xiApiKey = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Convai Settings<br/>
        /// Update Convai settings for the workspace
        /// </summary>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programmatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="conversationInitiationClientDataWebhook"></param>
        /// <param name="webhooks"></param>
        /// <param name="canUseMcpServers">
        /// Whether the workspace can use MCP servers<br/>
        /// Default Value: false
        /// </param>
        /// <param name="ragRetentionPeriodDays">
        /// Default Value: 10
        /// </param>
        /// <param name="defaultLivekitStack">
        /// Default Value: standard
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetConvAISettingsResponseModel> Update5Async(
            string? xiApiKey = default,
            global::G.ConversationInitiationClientDataWebhook? conversationInitiationClientDataWebhook = default,
            global::G.ConvAIWebhooks? webhooks = default,
            bool? canUseMcpServers = default,
            int? ragRetentionPeriodDays = default,
            global::G.LivekitStackType? defaultLivekitStack = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}