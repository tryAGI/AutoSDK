//HintName: G.IUsersClient.GetUsers.g.cs
#nullable enable

namespace G
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// Gets information about one or more users.<br/>
        /// Gets information about one or more users.  <br/>
        ///   <br/>
        /// You may look up users using their user ID, login name, or both but the sum total of the number of users you may look up is 100\. For example, you may specify 50 IDs and 50 names or 100 IDs or names, but you cannot specify 100 IDs and 100 names.  <br/>
        ///   <br/>
        /// If you don’t specify IDs or login names, the request returns information about the user in the access token if you specify a user access token.  <br/>
        ///   <br/>
        /// To include the user’s verified email address in the response, you must use a user access token that includes the **user:read:email** scope.<br/>
        /// __Authorization:__<br/>
        /// Requires an [app access token](https://dev.twitch.tv/docs/authentication#app-access-tokens) or [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens).
        /// </summary>
        /// <param name="id"></param>
        /// <param name="login"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetUsersResponse> GetUsersAsync(
            global::System.Collections.Generic.IList<string>? id = default,
            global::System.Collections.Generic.IList<string>? login = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}