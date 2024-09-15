//HintName: G.IExtensionsClient.GetExtensionConfigurationSegment.g.cs
#nullable enable

namespace G
{
    public partial interface IExtensionsClient
    {
        /// <summary>
        /// Gets the specified configuration segment from the specified extension.<br/>
        /// Gets the specified configuration segment from the specified extension.<br/>
        /// **Rate Limits**: You may retrieve each segment a maximum of 20 times per minute.<br/>
        /// __Authorization:__<br/>
        /// Requires a signed JSON Web Token (JWT) created by an Extension Backend Service (EBS). For signing requirements, see [Signing the JWT](https://dev.twitch.tv/docs/extensions/building/#signing-the-jwt). The signed JWT must include the `role`, `user_id`, and `exp` fields (see [JWT Schema](https://dev.twitch.tv/docs/extensions/reference/#jwt-schema)). The `role` field must be set to _external_.
        /// </summary>
        /// <param name="broadcasterId"></param>
        /// <param name="extensionId"></param>
        /// <param name="segment"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetExtensionConfigurationSegmentResponse> GetExtensionConfigurationSegmentAsync(
            string extensionId,
            global::G.GetExtensionConfigurationSegmentSegment segment,
            string? broadcasterId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}