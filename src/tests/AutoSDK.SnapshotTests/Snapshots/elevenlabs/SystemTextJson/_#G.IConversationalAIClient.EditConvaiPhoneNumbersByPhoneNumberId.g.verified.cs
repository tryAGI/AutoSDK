//HintName: G.IConversationalAIClient.EditConvaiPhoneNumbersByPhoneNumberId.g.cs
#nullable enable

namespace G
{
    public partial interface IConversationalAIClient
    {
        /// <summary>
        /// Update Phone Number<br/>
        /// Update Phone Number details by ID
        /// </summary>
        /// <param name="phoneNumberId">
        /// The id of an agent. This is returned on agent creation.<br/>
        /// Example: TeaqRRdTcIfIu2i7BYfT
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.UpdatePhoneNumberV1ConvaiPhoneNumbersPhoneNumberIdPatchResponse> EditConvaiPhoneNumbersByPhoneNumberIdAsync(
            string phoneNumberId,
            global::G.UpdatePhoneNumberRequest request,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Update Phone Number<br/>
        /// Update Phone Number details by ID
        /// </summary>
        /// <param name="phoneNumberId">
        /// The id of an agent. This is returned on agent creation.<br/>
        /// Example: TeaqRRdTcIfIu2i7BYfT
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="agentId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.UpdatePhoneNumberV1ConvaiPhoneNumbersPhoneNumberIdPatchResponse> EditConvaiPhoneNumbersByPhoneNumberIdAsync(
            string phoneNumberId,
            string? xiApiKey = default,
            string? agentId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}