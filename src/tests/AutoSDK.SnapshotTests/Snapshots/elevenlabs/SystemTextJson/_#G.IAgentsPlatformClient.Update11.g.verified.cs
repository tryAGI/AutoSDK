//HintName: G.IAgentsPlatformClient.Update11.g.cs
#nullable enable

namespace G
{
    public partial interface IAgentsPlatformClient
    {
        /// <summary>
        /// Update Whatsapp Account<br/>
        /// Update a WhatsApp account
        /// </summary>
        /// <param name="phoneNumberId"></param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programmatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> Update11Async(
            string phoneNumberId,

            global::G.UpdateWhatsAppAccountRequest request,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Whatsapp Account<br/>
        /// Update a WhatsApp account
        /// </summary>
        /// <param name="phoneNumberId"></param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programmatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="assignedAgentId"></param>
        /// <param name="enableMessaging"></param>
        /// <param name="enableAudioMessageResponse"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> Update11Async(
            string phoneNumberId,
            string? xiApiKey = default,
            string? assignedAgentId = default,
            bool? enableMessaging = default,
            bool? enableAudioMessageResponse = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}