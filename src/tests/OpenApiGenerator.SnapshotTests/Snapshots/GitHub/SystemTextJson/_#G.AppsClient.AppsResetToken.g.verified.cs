//HintName: G.AppsClient.AppsResetToken.g.cs

#nullable enable

namespace G
{
    public partial class AppsClient
    {
        partial void PrepareAppsResetTokenArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string clientId,
            global::G.AppsResetTokenRequest request);
        partial void PrepareAppsResetTokenRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string clientId,
            global::G.AppsResetTokenRequest request);
        partial void ProcessAppsResetTokenResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessAppsResetTokenResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Reset a token<br/>
        /// OAuth applications and GitHub applications with OAuth authorizations can use this API method to reset a valid OAuth token without end-user involvement. Applications must save the "token" property in the response because changes take effect immediately. You must use [Basic Authentication](https://docs.github.com/rest/overview/other-authentication-methods#basic-authentication) when accessing this endpoint, using the application's `client_id` and `client_secret` as the username and password. Invalid tokens will return `404 NOT FOUND`.
        /// </summary>
        /// <param name="clientId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.Authorization> AppsResetTokenAsync(
            string clientId,
            global::G.AppsResetTokenRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareAppsResetTokenArguments(
                httpClient: _httpClient,
                clientId: ref clientId,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: new global::System.Net.Http.HttpMethod("PATCH"),
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/applications/{clientId}/token", global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = global::System.Text.Json.JsonSerializer.Serialize(request, _jsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareAppsResetTokenRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                clientId: clientId,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessAppsResetTokenResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessAppsResetTokenResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize<global::G.Authorization?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Reset a token<br/>
        /// OAuth applications and GitHub applications with OAuth authorizations can use this API method to reset a valid OAuth token without end-user involvement. Applications must save the "token" property in the response because changes take effect immediately. You must use [Basic Authentication](https://docs.github.com/rest/overview/other-authentication-methods#basic-authentication) when accessing this endpoint, using the application's `client_id` and `client_secret` as the username and password. Invalid tokens will return `404 NOT FOUND`.
        /// </summary>
        /// <param name="clientId"></param>
        /// <param name="accessToken">
        /// The access_token of the OAuth or GitHub application.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.Authorization> AppsResetTokenAsync(
            string clientId,
            string accessToken,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.AppsResetTokenRequest
            {
                AccessToken = accessToken,
            };

            return await AppsResetTokenAsync(
                clientId: clientId,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}