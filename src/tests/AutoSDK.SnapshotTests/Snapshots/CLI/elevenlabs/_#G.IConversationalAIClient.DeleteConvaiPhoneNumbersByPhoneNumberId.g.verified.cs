﻿//HintName: G.IConversationalAIClient.DeleteConvaiPhoneNumbersByPhoneNumberId.g.cs
#nullable enable

namespace G
{
    public partial interface IConversationalAIClient
    {
        /// <summary>
        /// Delete Phone Number<br/>
        /// Delete Phone Number by ID
        /// </summary>
        /// <param name="phoneNumberId">
        /// The id of an agent. This is returned on agent creation.<br/>
        /// Example: TeaqRRdTcIfIu2i7BYfT
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> DeleteConvaiPhoneNumbersByPhoneNumberIdAsync(
            string phoneNumberId,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}