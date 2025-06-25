﻿//HintName: G.IVoicesClient.CreateVoicesAddByPublicUserIdByVoiceId.g.cs
#nullable enable

namespace G
{
    public partial interface IVoicesClient
    {
        /// <summary>
        /// Add Shared Voice<br/>
        /// Add a shared voice to your collection of voices.
        /// </summary>
        /// <param name="publicUserId">
        /// Public user ID used to publicly identify ElevenLabs users.<br/>
        /// Example: 63e06b7e7cafdc46be4d2e0b3f045940231ae058d508589653d74d1265a574ca
        /// </param>
        /// <param name="voiceId">
        /// Voice ID to be used, you can use https://api.elevenlabs.io/v1/voices to list all the available voices.<br/>
        /// Example: 21m00Tcm4TlvDq8ikWAM
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AddVoiceResponseModel> CreateVoicesAddByPublicUserIdByVoiceIdAsync(
            string publicUserId,
            string voiceId,
            global::G.BodyAddSharedVoiceV1VoicesAddPublicUserIdVoiceIdPost request,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Add Shared Voice<br/>
        /// Add a shared voice to your collection of voices.
        /// </summary>
        /// <param name="publicUserId">
        /// Public user ID used to publicly identify ElevenLabs users.<br/>
        /// Example: 63e06b7e7cafdc46be4d2e0b3f045940231ae058d508589653d74d1265a574ca
        /// </param>
        /// <param name="voiceId">
        /// Voice ID to be used, you can use https://api.elevenlabs.io/v1/voices to list all the available voices.<br/>
        /// Example: 21m00Tcm4TlvDq8ikWAM
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="newName">
        /// The name that identifies this voice. This will be displayed in the dropdown of the website.<br/>
        /// Example: John Smith
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.AddVoiceResponseModel> CreateVoicesAddByPublicUserIdByVoiceIdAsync(
            string publicUserId,
            string voiceId,
            string newName,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}