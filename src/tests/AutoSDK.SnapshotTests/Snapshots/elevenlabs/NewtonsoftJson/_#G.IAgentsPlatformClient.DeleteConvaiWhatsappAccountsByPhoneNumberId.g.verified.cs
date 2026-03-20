//HintName: G.IAgentsPlatformClient.DeleteConvaiWhatsappAccountsByPhoneNumberId.g.cs
#nullable enable

namespace G
{
    public partial interface IAgentsPlatformClient
    {

        /// <summary>
        /// Delete Whatsapp Account<br/>
        /// Delete a WhatsApp account
        /// </summary>
        /// <param name="phoneNumberId"></param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programmatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> DeleteConvaiWhatsappAccountsByPhoneNumberIdAsync(
            string phoneNumberId,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}