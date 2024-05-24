//HintName: G.UserClient.UserRegisterConnection.g.cs

#nullable enable

namespace G
{
    public partial class UserClient
    {
        /// <summary>
        /// RegisterConnection.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="userId"></param>
        /// <param name="connectionKey"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task UserRegisterConnectionAsync(
            string token,
            string userId,
            string connectionKey,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/api/v1/user/registerconnection?userId={userId}&connectionKey={connectionKey}", global::System.UriKind.RelativeOrAbsolute));

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();
        }
    }
}