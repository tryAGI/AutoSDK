//HintName: G.VideosClient.GetVideos.g.cs
using System.Linq;

#nullable enable

namespace G
{
    public partial class VideosClient
    {
        /// <summary>
        /// Gets information about one or more published videos.
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
        public async global::System.Threading.Tasks.Task<GetVideosResponse> GetVideosAsync(
            global::System.Collections.Generic.IList<string> id,
            string userId,
            string gameId,
            string language,
            GetVideosPeriod period,
            GetVideosSort sort,
            GetVideosType type,
            string first,
            string after,
            string before,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var periodValue = period switch
            {
                GetVideosPeriod.All => "all",
                GetVideosPeriod.Day => "day",
                GetVideosPeriod.Month => "month",
                GetVideosPeriod.Week => "week",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var sortValue = sort switch
            {
                GetVideosSort.Time => "time",
                GetVideosSort.Trending => "trending",
                GetVideosSort.Views => "views",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var typeValue = type switch
            {
                GetVideosType.All => "all",
                GetVideosType.Archive => "archive",
                GetVideosType.Highlight => "highlight",
                GetVideosType.Upload => "upload",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/videos?{string.Join("&", id.Select(static x => $"id={x}"))}&user_id={userId}&game_id={gameId}&language={language}&period={periodValue}&sort={sortValue}&type={typeValue}&first={first}&after={after}&before={before}", global::System.UriKind.RelativeOrAbsolute));

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            return
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<GetVideosResponse>(content) ??
                throw new global::System.InvalidOperationException("Response deserialization failed for \"{content}\" ");
        }
    }
}