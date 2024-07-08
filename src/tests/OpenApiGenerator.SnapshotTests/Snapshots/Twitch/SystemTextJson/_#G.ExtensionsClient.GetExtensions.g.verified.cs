//HintName: G.ExtensionsClient.GetExtensions.g.cs

#nullable enable

namespace G
{
    public partial class ExtensionsClient
    {
        partial void PrepareGetExtensionsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string extensionId,
            ref string extensionVersion);
        partial void PrepareGetExtensionsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string extensionId,
            string extensionVersion);
        partial void ProcessGetExtensionsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGetExtensionsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Gets information about an extension.<br/>
        /// Gets information about an extension.<br/>
        /// __Authorization:__<br/>
        /// Requires a signed JSON Web Token (JWT) created by an Extension Backend Service (EBS). For signing requirements, see [Signing the JWT](https://dev.twitch.tv/docs/extensions/building/#signing-the-jwt). The signed JWT must include the `role` field (see [JWT Schema](https://dev.twitch.tv/docs/extensions/reference/#jwt-schema)), and the `role` field must be set to _external_.
        /// </summary>
        /// <param name="extensionId"></param>
        /// <param name="extensionVersion"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.GetExtensionsResponse> GetExtensionsAsync(
            string extensionId,
            string extensionVersion,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareGetExtensionsArguments(
                httpClient: _httpClient,
                extensionId: ref extensionId,
                extensionVersion: ref extensionVersion);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/extensions?extension_id={extensionId}&extension_version={extensionVersion}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareGetExtensionsRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                extensionId: extensionId,
                extensionVersion: extensionVersion);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessGetExtensionsResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessGetExtensionsResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize<global::G.GetExtensionsResponse?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}