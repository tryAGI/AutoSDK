//HintName: G.LoginClient.UnsafeLogin.g.cs

#nullable enable

namespace G
{
    public partial class LoginClient
    {
        partial void PrepareUnsafeLoginArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::G.UnsafeLoginRequest request);
        partial void PrepareUnsafeLoginRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::G.UnsafeLoginRequest request);
        partial void ProcessUnsafeLoginResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessUnsafeLoginResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Login to Dedoose API use raw password.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<string> UnsafeLoginAsync(
            global::G.UnsafeLoginRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareUnsafeLoginArguments(
                httpClient: _httpClient,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + "/api/v1/unsafelogin", global::System.UriKind.RelativeOrAbsolute));
            var __json = global::System.Text.Json.JsonSerializer.Serialize(request, _jsonSerializerOptions);
            httpRequest.Content = new global::System.Net.Http.StringContent(
                content: __json,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareUnsafeLoginRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessUnsafeLoginResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessUnsafeLoginResponseContent(
                httpClient: _httpClient,
                httpResponseMessage: response,
                content: ref __content);

            try
            {
                response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException ex)
            {
                throw new global::System.InvalidOperationException(__content, ex);
            }

            return
                global::System.Text.Json.JsonSerializer.Deserialize<string?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Login to Dedoose API use raw password.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<string> UnsafeLoginAsync(
            string? username = default,
            string? password = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.UnsafeLoginRequest
            {
                Username = username,
                Password = password,
            };

            return await UnsafeLoginAsync(
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}