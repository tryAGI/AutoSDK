//HintName: G.IAgentsPlatformClient.OutboundMessage.g.cs
#nullable enable

namespace G
{
    public partial interface IAgentsPlatformClient
    {
        /// <summary>
        /// Send An Outbound Message Via Whatsapp<br/>
        /// Send an outbound message via WhatsApp
        /// </summary>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programmatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.WhatsAppOutboundMessageResponse> OutboundMessageAsync(

            global::G.BodySendAnOutboundMessageViaWhatsAppV1ConvaiWhatsappOutboundMessagePost request,
            string? xiApiKey = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Send An Outbound Message Via Whatsapp<br/>
        /// Send an outbound message via WhatsApp
        /// </summary>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programmatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="whatsappPhoneNumberId"></param>
        /// <param name="whatsappUserId"></param>
        /// <param name="templateName"></param>
        /// <param name="templateLanguageCode"></param>
        /// <param name="templateParams"></param>
        /// <param name="agentId"></param>
        /// <param name="conversationInitiationClientData"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.WhatsAppOutboundMessageResponse> OutboundMessageAsync(
            string whatsappPhoneNumberId,
            string whatsappUserId,
            string templateName,
            string templateLanguageCode,
            global::System.Collections.Generic.IList<global::G.TemplateParamsItem> templateParams,
            string agentId,
            string? xiApiKey = default,
            global::G.ConversationInitiationClientDataRequestInput? conversationInitiationClientData = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}