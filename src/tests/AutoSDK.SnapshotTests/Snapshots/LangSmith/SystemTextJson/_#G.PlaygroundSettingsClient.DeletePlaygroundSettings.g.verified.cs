//HintName: G.PlaygroundSettingsClient.DeletePlaygroundSettings.g.cs

#nullable enable

namespace G
{
    public partial class PlaygroundSettingsClient
    {
        partial void PrepareDeletePlaygroundSettingsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string playgroundSettingsId);
        partial void PrepareDeletePlaygroundSettingsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string playgroundSettingsId);
        partial void ProcessDeletePlaygroundSettingsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessDeletePlaygroundSettingsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Delete Playground Settings<br/>
        /// Delete playground settings.
        /// </summary>
        /// <param name="playgroundSettingsId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.DeletePlaygroundSettingsApiV1PlaygroundSettingsPlaygroundSettingsIdDeleteResponse> DeletePlaygroundSettingsAsync(
            string playgroundSettingsId,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareDeletePlaygroundSettingsArguments(
                httpClient: _httpClient,
                playgroundSettingsId: ref playgroundSettingsId);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Delete,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/api/v1/playground-settings/{playgroundSettingsId}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareDeletePlaygroundSettingsRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                playgroundSettingsId: playgroundSettingsId);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessDeletePlaygroundSettingsResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessDeletePlaygroundSettingsResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize<global::G.DeletePlaygroundSettingsApiV1PlaygroundSettingsPlaygroundSettingsIdDeleteResponse?>(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}