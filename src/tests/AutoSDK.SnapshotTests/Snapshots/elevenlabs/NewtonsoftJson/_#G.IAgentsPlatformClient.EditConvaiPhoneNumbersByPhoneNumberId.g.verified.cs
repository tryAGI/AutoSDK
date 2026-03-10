//HintName: G.IAgentsPlatformClient.EditConvaiPhoneNumbersByPhoneNumberId.g.cs
#nullable enable

namespace G
{
    public partial interface IAgentsPlatformClient
    {
        /// <summary>
        /// Update Phone Number<br/>
        /// Update assigned agent of a phone number
        /// </summary>
        /// <param name="phoneNumberId">
        /// The id of an agent. This is returned on agent creation.
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programmatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.UpdatePhoneNumberRouteResponse> EditConvaiPhoneNumbersByPhoneNumberIdAsync(
            string phoneNumberId,

            global::G.UpdatePhoneNumberRequest request,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Update Phone Number<br/>
        /// Update assigned agent of a phone number
        /// </summary>
        /// <param name="phoneNumberId">
        /// The id of an agent. This is returned on agent creation.
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programmatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="agentId"></param>
        /// <param name="label"></param>
        /// <param name="inboundTrunkConfig"></param>
        /// <param name="outboundTrunkConfig"></param>
        /// <param name="livekitStack"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.UpdatePhoneNumberRouteResponse> EditConvaiPhoneNumbersByPhoneNumberIdAsync(
            string phoneNumberId,
            string? xiApiKey = default,
            string? agentId = default,
            string? label = default,
            global::G.InboundSIPTrunkConfigRequestModel? inboundTrunkConfig = default,
            global::G.OutboundSIPTrunkConfigRequestModel? outboundTrunkConfig = default,
            global::G.LivekitStackType? livekitStack = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}