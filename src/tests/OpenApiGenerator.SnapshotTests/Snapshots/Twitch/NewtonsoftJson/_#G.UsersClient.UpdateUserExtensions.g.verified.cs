//HintName: G.UsersClient.UpdateUserExtensions.g.cs

#nullable enable

namespace G
{
    public partial class UsersClient
    {
        partial void PrepareUpdateUserExtensionsArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::G.UpdateUserExtensionsBody request);
        partial void PrepareUpdateUserExtensionsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::G.UpdateUserExtensionsBody request);
        partial void ProcessUpdateUserExtensionsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessUpdateUserExtensionsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Updates an installed extension’s information.<br/>
        /// Updates an installed extension’s information. You can update the extension’s activation state, ID, and version number. The user ID in the access token identifies the broadcaster whose extensions you’re updating.<br/>
        /// NOTE: If you try to activate an extension under multiple extension types, the last write wins (and there is no guarantee of write order).<br/>
        /// __Authorization:__<br/>
        /// Requires a [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens) that includes the **user:edit:broadcast** scope.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.UpdateUserExtensionsResponse> UpdateUserExtensionsAsync(
            global::G.UpdateUserExtensionsBody request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareUpdateUserExtensionsArguments(
                httpClient: _httpClient,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Put,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + "/users/extensions", global::System.UriKind.RelativeOrAbsolute));
            var __json = global::Newtonsoft.Json.JsonConvert.SerializeObject(request, _jsonSerializerOptions);
            httpRequest.Content = new global::System.Net.Http.StringContent(
                content: __json,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareUpdateUserExtensionsRequest(
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
            ProcessUpdateUserExtensionsResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessUpdateUserExtensionsResponseContent(
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
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.UpdateUserExtensionsResponse?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Updates an installed extension’s information.<br/>
        /// Updates an installed extension’s information. You can update the extension’s activation state, ID, and version number. The user ID in the access token identifies the broadcaster whose extensions you’re updating.<br/>
        /// NOTE: If you try to activate an extension under multiple extension types, the last write wins (and there is no guarantee of write order).<br/>
        /// __Authorization:__<br/>
        /// Requires a [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens) that includes the **user:edit:broadcast** scope.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.UpdateUserExtensionsResponse> UpdateUserExtensionsAsync(
            object data,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.UpdateUserExtensionsBody
            {
                Data = data,
            };

            return await UpdateUserExtensionsAsync(
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}