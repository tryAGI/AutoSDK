//HintName: G.ClipsClient.GetClips.g.cs
using System.Linq;

#nullable enable

namespace G
{
    public partial class ClipsClient
    {
        /// <summary>
        /// Gets one or more video clips.<br/>
        /// Gets one or more video clips that were captured from streams. For information about clips, see [How to use clips](https://help.twitch.tv/s/article/how-to-use-clips).<br/>
        /// __Authorization:__<br/>
        /// Requires an [app access token](https://dev.twitch.tv/docs/authentication#app-access-tokens) or [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens).<br/>
        /// __Request Query Parameters:__<br/>
        /// The _id_, _game\_id_, and _broadcaster\_id_ query parameters are mutually exclusive.
        /// </summary>
        /// <param name="broadcasterId"></param>
        /// <param name="gameId"></param>
        /// <param name="id"></param>
        /// <param name="startedAt"></param>
        /// <param name="endedAt"></param>
        /// <param name="first"></param>
        /// <param name="before"></param>
        /// <param name="after"></param>
        /// <param name="isFeatured"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.GetClipsResponse> GetClipsAsync(
            string broadcasterId,
            string gameId,
            global::System.Collections.Generic.IList<string> id,
            global::System.DateTime startedAt,
            global::System.DateTime endedAt,
            int first,
            string before,
            string after,
            bool isFeatured,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.GetLeftPart(global::System.UriPartial.Authority) + $"/clips?broadcaster_id={broadcasterId}&game_id={gameId}&{string.Join("&", id.Select(static x => $"id={x}"))}&started_at={startedAt:yyyy-MM-ddTHH:mm:ssZ)}&ended_at={endedAt:yyyy-MM-ddTHH:mm:ssZ)}&first={first}&before={before}&after={after}&is_featured={isFeatured}", global::System.UriKind.RelativeOrAbsolute));

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
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.GetClipsResponse?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}