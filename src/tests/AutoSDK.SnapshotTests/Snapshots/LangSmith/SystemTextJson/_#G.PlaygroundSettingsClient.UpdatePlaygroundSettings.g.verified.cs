﻿//HintName: G.PlaygroundSettingsClient.UpdatePlaygroundSettings.g.cs

#nullable enable

namespace G
{
    public partial class PlaygroundSettingsClient
    {
        partial void PrepareUpdatePlaygroundSettingsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string playgroundSettingsId,
            global::G.PlaygroundSettingsUpdateRequest request);
        partial void PrepareUpdatePlaygroundSettingsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string playgroundSettingsId,
            global::G.PlaygroundSettingsUpdateRequest request);
        partial void ProcessUpdatePlaygroundSettingsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessUpdatePlaygroundSettingsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Update Playground Settings<br/>
        /// Update playground settings.
        /// </summary>
        /// <param name="playgroundSettingsId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.PlaygroundSettingsResponse> UpdatePlaygroundSettingsAsync(
            string playgroundSettingsId,
            global::G.PlaygroundSettingsUpdateRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareUpdatePlaygroundSettingsArguments(
                httpClient: _httpClient,
                playgroundSettingsId: ref playgroundSettingsId,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: $"/api/v1/playground-settings/{playgroundSettingsId}",
                baseUri: _httpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: new global::System.Net.Http.HttpMethod("PATCH"),
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            foreach (var _authorization in _authorizations)
            {
                if (_authorization.Type == "Http" ||
                    _authorization.Type == "OAuth2")
                {
                    httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: _authorization.Name,
                        parameter: _authorization.Value);
                }
                else if (_authorization.Type == "ApiKey" &&
                         _authorization.Location == "Header")
                {
                    httpRequest.Headers.Add(_authorization.Name, _authorization.Value);
                }
            }
            var __httpRequestContentBody = request.ToJson(JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareUpdatePlaygroundSettingsRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                playgroundSettingsId: playgroundSettingsId,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessUpdatePlaygroundSettingsResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessUpdatePlaygroundSettingsResponseContent(
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
                global::G.PlaygroundSettingsResponse.FromJson(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Update Playground Settings<br/>
        /// Update playground settings.
        /// </summary>
        /// <param name="playgroundSettingsId"></param>
        /// <param name="name"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.PlaygroundSettingsResponse> UpdatePlaygroundSettingsAsync(
            string playgroundSettingsId,
            string? name = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.PlaygroundSettingsUpdateRequest
            {
                Name = name,
            };

            return await UpdatePlaygroundSettingsAsync(
                playgroundSettingsId: playgroundSettingsId,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}