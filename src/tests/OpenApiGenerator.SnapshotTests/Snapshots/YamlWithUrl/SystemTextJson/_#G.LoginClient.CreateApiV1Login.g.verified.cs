//HintName: G.LoginClient.CreateApiV1Login.g.cs

#nullable enable

namespace G
{
    public partial class LoginClient
    {
        /// <summary>
        /// Login to Dedoose API use encrypted password.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task CreateApiV1LoginAsync(
            LoginRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + "/api/v1/login", global::System.UriKind.RelativeOrAbsolute));
            httpRequest.Content = new global::System.Net.Http.StringContent(
                content: global::System.Text.Json.JsonSerializer.Serialize(request),
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();
        }

        /// <summary>
        /// Login to Dedoose API use encrypted password.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="rsaEncryptedPassword"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task CreateApiV1LoginAsync(
            string? username = default,
            string? rsaEncryptedPassword = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new LoginRequest
            {
                Username = username,
                RsaEncryptedPassword = rsaEncryptedPassword,
            };

            await CreateApiV1LoginAsync(
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}