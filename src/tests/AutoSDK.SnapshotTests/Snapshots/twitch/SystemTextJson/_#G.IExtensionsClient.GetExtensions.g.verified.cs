//HintName: G.IExtensionsClient.GetExtensions.g.cs
#nullable enable

namespace G
{
    public partial interface IExtensionsClient
    {
        /// <summary>
        /// Gets information about an extension.<br/>
        /// Gets information about an extension.<br/>
        /// __Authorization:__<br/>
        /// Requires a signed JSON Web Token (JWT) created by an Extension Backend Service (EBS). For signing requirements, see [Signing the JWT](https://dev.twitch.tv/docs/extensions/building/#signing-the-jwt). The signed JWT must include the `role` field (see [JWT Schema](https://dev.twitch.tv/docs/extensions/reference/#jwt-schema)), and the `role` field must be set to _external_.
        /// </summary>
        /// <param name="extensionId"></param>
        /// <param name="extensionVersion"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetExtensionsResponse> GetExtensionsAsync(
            string extensionId,
            string? extensionVersion = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}