//HintName: G.IExtensionsClient.SetExtensionConfigurationSegment.g.cs
#nullable enable

namespace G
{
    public partial interface IExtensionsClient
    {
        /// <summary>
        /// Updates a configuration segment.<br/>
        /// Updates a configuration segment. The segment is limited to 5 KB. Extensions that are active on a channel do not receive the updated configuration.<br/>
        /// **Rate Limits**: You may update the configuration a maximum of 20 times per minute.<br/>
        /// __Authorization:__<br/>
        /// Requires a signed JSON Web Token (JWT) created by an Extension Backend Service (EBS). For signing requirements, see [Signing the JWT](https://dev.twitch.tv/docs/extensions/building/#signing-the-jwt). The signed JWT must include the `role`, `user_id`, and `exp` fields (see [JWT Schema](https://dev.twitch.tv/docs/extensions/reference/#jwt-schema)). The `role` field must be set to _external_.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task SetExtensionConfigurationSegmentAsync(
            global::G.SetExtensionConfigurationSegmentBody request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates a configuration segment.<br/>
        /// Updates a configuration segment. The segment is limited to 5 KB. Extensions that are active on a channel do not receive the updated configuration.<br/>
        /// **Rate Limits**: You may update the configuration a maximum of 20 times per minute.<br/>
        /// __Authorization:__<br/>
        /// Requires a signed JSON Web Token (JWT) created by an Extension Backend Service (EBS). For signing requirements, see [Signing the JWT](https://dev.twitch.tv/docs/extensions/building/#signing-the-jwt). The signed JWT must include the `role`, `user_id`, and `exp` fields (see [JWT Schema](https://dev.twitch.tv/docs/extensions/reference/#jwt-schema)). The `role` field must be set to _external_.
        /// </summary>
        /// <param name="extensionId">
        /// The ID of the extension to update.
        /// </param>
        /// <param name="segment">
        /// The configuration segment to update. Possible case-sensitive values are:  <br/>
        ///   <br/>
        /// * broadcaster<br/>
        /// * developer<br/>
        /// * global
        /// </param>
        /// <param name="broadcasterId">
        /// The ID of the broadcaster that installed the extension. Include this field only if the `segment` is set to developer or broadcaster.
        /// </param>
        /// <param name="content">
        /// The contents of the segment. This string may be a plain-text string or a string-encoded JSON object.
        /// </param>
        /// <param name="version">
        /// The version number that identifies this definition of the segment’s data. If not specified, the latest definition is updated.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task SetExtensionConfigurationSegmentAsync(
            string extensionId,
            global::G.SetExtensionConfigurationSegmentBodySegment segment,
            string? broadcasterId = default,
            string? content = default,
            string? version = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}