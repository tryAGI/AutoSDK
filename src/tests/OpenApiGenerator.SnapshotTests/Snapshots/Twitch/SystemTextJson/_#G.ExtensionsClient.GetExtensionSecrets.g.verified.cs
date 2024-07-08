//HintName: G.ExtensionsClient.GetExtensionSecrets.g.cs

#nullable enable

namespace G
{
    public partial class ExtensionsClient
    {
        partial void PrepareGetExtensionSecretsArguments(
            global::System.Net.Http.HttpClient httpClient);
        partial void PrepareGetExtensionSecretsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage);
        partial void ProcessGetExtensionSecretsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGetExtensionSecretsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Gets an extension’s list of shared secrets.<br/>
        /// Gets an extension’s list of shared secrets.<br/>
        /// __Authorization:__<br/>
        /// Requires a signed JSON Web Token (JWT) created by an Extension Backend Service (EBS). For signing requirements, see [Signing the JWT](https://dev.twitch.tv/docs/extensions/building/#signing-the-jwt). The signed JWT must include the `role`, `user_id`, and `exp` fields (see [JWT Schema](https://dev.twitch.tv/docs/extensions/reference/#jwt-schema)). The `role` field must be set to _external_.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.GetExtensionSecretsResponse> GetExtensionSecretsAsync(
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareGetExtensionSecretsArguments(
                httpClient: _httpClient);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + "/extensions/jwt/secrets", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareGetExtensionSecretsRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessGetExtensionSecretsResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessGetExtensionSecretsResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize<global::G.GetExtensionSecretsResponse?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}