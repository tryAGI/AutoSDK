//HintName: G.IConversationalAIClient.CreateConvaiPhoneNumbersCreate.g.cs
#nullable enable

namespace G
{
    public partial interface IConversationalAIClient
    {
        /// <summary>
        /// Import Phone Number<br/>
        /// Import Phone Number from provider configuration (Twilio or SIP trunk)
        /// </summary>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreatePhoneNumberResponseModel> CreateConvaiPhoneNumbersCreateAsync(
            global::G.AnyOf<global::G.CreateTwilioPhoneNumberRequest, global::G.CreateSIPTrunkPhoneNumberRequest> request,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Import Phone Number<br/>
        /// Import Phone Number from provider configuration (Twilio or SIP trunk)
        /// </summary>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreatePhoneNumberResponseModel> CreateConvaiPhoneNumbersCreateAsync(
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}