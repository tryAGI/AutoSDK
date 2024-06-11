//HintName: G.UsersClient.GetUsers.g.cs
using System.Linq;

#nullable enable

namespace G
{
    public partial class UsersClient
    {
        /// <summary>
        /// Gets information about one or more users.
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
            response.EnsureSuccessStatusCode();

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            return
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.GetUsersResponse?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}