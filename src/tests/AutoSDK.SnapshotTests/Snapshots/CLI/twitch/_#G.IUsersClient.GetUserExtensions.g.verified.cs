//HintName: G.IUsersClient.GetUserExtensions.g.cs
#nullable enable

namespace G
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// Gets a list of all extensions (both active and inactive) that the broadcaster has installed.<br/>
        /// Gets a list of all extensions (both active and inactive) that the broadcaster has installed. The user ID in the access token identifies the broadcaster.<br/>
        /// __Authorization:__<br/>
        /// Requires a [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens) that includes the **user:read:broadcast** or **user:edit:broadcast** scope. To include inactive extensions, you must include the **user:edit:broadcast** scope.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetUserExtensionsResponse> GetUserExtensionsAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}