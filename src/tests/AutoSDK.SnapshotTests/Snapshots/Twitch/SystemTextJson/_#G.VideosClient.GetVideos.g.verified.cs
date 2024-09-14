//HintName: G.VideosClient.GetVideos.g.cs
using System.Linq;

#nullable enable

namespace G
{
    public partial class VideosClient
    {
        partial void PrepareGetVideosArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Collections.Generic.IList<string>? id,
            ref string? userId,
            ref string? gameId,
            ref string? language,
            ref global::G.GetVideosPeriod? period,
            ref global::G.GetVideosSort? sort,
            ref global::G.GetVideosType? type,
            ref string? first,
            ref string? after,
            ref string? before);
        partial void PrepareGetVideosRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::System.Collections.Generic.IList<string>? id,
            string? userId,
            string? gameId,
            string? language,
            global::G.GetVideosPeriod? period,
            global::G.GetVideosSort? sort,
            global::G.GetVideosType? type,
            string? first,
            string? after,
            string? before);
        partial void ProcessGetVideosResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGetVideosResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Gets information about one or more published videos.<br/>
        /// Gets information about one or more published videos. You may get videos by ID, by user, or by game/category.<br/>
        /// You may apply several filters to get a subset of the videos. The filters are applied as an AND operation to each video. For example, if _language_ is set to ‘de’ and _game\_id_ is set to 21779, the response includes only videos that show playing League of Legends by users that stream in German. The filters apply only if you get videos by user ID or game ID.<br/>
        /// __Authorization:__<br/>
        /// Requires an [app access token](https://dev.twitch.tv/docs/authentication#app-access-tokens) or [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens).
        /// </summary>
        /// <param name="id"></param>
        /// <param name="userId"></param>
        /// <param name="gameId"></param>
        /// <param name="language"></param>
        /// <param name="period"></param>
        /// <param name="sort"></param>
        /// <param name="type"></param>
        /// <param name="first"></param>
        /// <param name="after"></param>
        /// <param name="before"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.GetVideosResponse> GetVideosAsync(
            global::System.Collections.Generic.IList<string>? id = default,
            string? userId = default,
            string? gameId = default,
            string? language = default,
            global::G.GetVideosPeriod? period = default,
            global::G.GetVideosSort? sort = default,
            global::G.GetVideosType? type = default,
            string? first = default,
            string? after = default,
            string? before = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareGetVideosArguments(
                httpClient: _httpClient,
                id: id,
                userId: ref userId,
                gameId: ref gameId,
                language: ref language,
                period: ref period,
                sort: ref sort,
                type: ref type,
                first: ref first,
                after: ref after,
                before: ref before);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/videos?{string.Join("&", id?.Select(static x => $"id={x}") ?? global::System.Array.Empty<string>())}&user_id={userId}&game_id={gameId}&language={language}&period={(global::System.Uri.EscapeDataString(period?.ToValueString() ?? string.Empty))}&sort={(global::System.Uri.EscapeDataString(sort?.ToValueString() ?? string.Empty))}&type={(global::System.Uri.EscapeDataString(type?.ToValueString() ?? string.Empty))}&first={first}&after={after}&before={before}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareGetVideosRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                id: id,
                userId: userId,
                gameId: gameId,
                language: language,
                period: period,
                sort: sort,
                type: type,
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
            ProcessGetVideosResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessGetVideosResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize<global::G.GetVideosResponse?>(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}