//HintName: G.VideosClient.GetVideos.g.cs
using System.Linq;

#nullable enable

namespace G
{
    public partial class VideosClient
    {
        partial void PrepareGetVideosArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Collections.Generic.IList<string> id,
            ref string userId,
            ref string gameId,
            ref string language,
            ref global::G.GetVideosPeriod period,
            ref global::G.GetVideosSort sort,
            ref global::G.GetVideosType type,
            ref string first,
            ref string after,
            ref string before);
        partial void PrepareGetVideosRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::System.Collections.Generic.IList<string> id,
            string userId,
            string gameId,
            string language,
            global::G.GetVideosPeriod period,
            global::G.GetVideosSort sort,
            global::G.GetVideosType type,
            string first,
            string after,
            string before);
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
            global::System.Collections.Generic.IList<string> id,
            string userId,
            string gameId,
            string language,
            global::G.GetVideosPeriod period,
            global::G.GetVideosSort sort,
            global::G.GetVideosType type,
            string first,
            string after,
            string before,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var periodValue = period switch
            {
                global::G.GetVideosPeriod.All => "all",
                global::G.GetVideosPeriod.Day => "day",
                global::G.GetVideosPeriod.Month => "month",
                global::G.GetVideosPeriod.Week => "week",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var sortValue = sort switch
            {
                global::G.GetVideosSort.Time => "time",
                global::G.GetVideosSort.Trending => "trending",
                global::G.GetVideosSort.Views => "views",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var typeValue = type switch
            {
                global::G.GetVideosType.All => "all",
                global::G.GetVideosType.Archive => "archive",
                global::G.GetVideosType.Highlight => "highlight",
                global::G.GetVideosType.Upload => "upload",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/videos?{string.Join("&", id.Select(static x => $"id={x}"))}&user_id={userId}&game_id={gameId}&language={language}&period={periodValue}&sort={sortValue}&type={typeValue}&first={first}&after={after}&before={before}", global::System.UriKind.RelativeOrAbsolute));

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            try
            {
                response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException ex)
            {
                throw new global::System.InvalidOperationException(__content, ex);
            }

            return
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.GetVideosResponse?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}