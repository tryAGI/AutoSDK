//HintName: G.GamesClient.GetTopGames.g.cs

#nullable enable

namespace G
{
    public partial class GamesClient
    {
        partial void PrepareGetTopGamesArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref int first,
            ref string after,
            ref string before);
        partial void PrepareGetTopGamesRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            int first,
            string after,
            string before);
        partial void ProcessGetTopGamesResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGetTopGamesResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Gets information about all broadcasts on Twitch.<br/>
        /// Gets information about all broadcasts on Twitch.<br/>
        /// __Authorization:__<br/>
        /// Requires an [app access token](https://dev.twitch.tv/docs/authentication#app-access-tokens) or [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens).
        /// </summary>
        /// <param name="first"></param>
        /// <param name="after"></param>
        /// <param name="before"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.GetTopGamesResponse> GetTopGamesAsync(
            int first,
            string after,
            string before,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareGetTopGamesArguments(
                httpClient: _httpClient,
                first: ref first,
                after: ref after,
                before: ref before);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/games/top?first={first}&after={after}&before={before}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareGetTopGamesRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                first: first,
                after: after,
                before: before);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessGetTopGamesResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessGetTopGamesResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize<global::G.GetTopGamesResponse?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}