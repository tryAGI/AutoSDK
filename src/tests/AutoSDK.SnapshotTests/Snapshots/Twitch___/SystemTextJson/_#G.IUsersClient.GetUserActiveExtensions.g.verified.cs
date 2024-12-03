//HintName: G.IUsersClient.GetUserActiveExtensions.g.cs
#nullable enable

namespace G
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// Gets the active extensions that the broadcaster has installed for each configuration.<br/>
        /// Gets the active extensions that the broadcaster has installed for each configuration.<br/>
        /// NOTE: To include extensions that you have under development, you must specify a user access token that includes the **user:read:broadcast** or **user:edit:broadcast** scope.<br/>
        /// __Authorization:__<br/>
        /// Requires an [app access token](https://dev.twitch.tv/docs/authentication#app-access-tokens) or [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens).
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetUserActiveExtensionsResponse> GetUserActiveExtensionsAsync(
            string? userId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}