//HintName: G.UsersClient.GetUsers.g.cs
using System.Linq;

#nullable enable

namespace G
{
    public partial class UsersClient
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
        public async global::System.Threading.Tasks.Task<global::G.GetUsersResponse> GetUsersAsync(
            global::System.Collections.Generic.IList<string> id,
            global::System.Collections.Generic.IList<string> login,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/users?{string.Join("&", id.Select(static x => $"id={x}"))}&{string.Join("&", login.Select(static x => $"login={x}"))}", global::System.UriKind.RelativeOrAbsolute));

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            try
            {
                response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException ex)
            {
                throw new global::System.InvalidOperationException(__content, ex);
            }

            return
                global::System.Text.Json.JsonSerializer.Deserialize<global::G.GetUsersResponse?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}