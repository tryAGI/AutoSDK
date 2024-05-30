//HintName: G.ClipsClient.GetClips.g.cs
using System.Linq;

#nullable enable

namespace G
{
    public partial class ClipsClient
    {
        /// <summary>
        /// Gets one or more video clips.
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
        public async global::System.Threading.Tasks.Task<GetClipsResponse> GetClipsAsync(
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
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/clips?broadcaster_id={broadcasterId}&game_id={gameId}&{string.Join("&", id.Select(static x => $"id={x}"))}&started_at={startedAt}&ended_at={endedAt}&first={first}&before={before}&after={after}&is_featured={isFeatured}", global::System.UriKind.RelativeOrAbsolute));

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            return
                global::System.Text.Json.JsonSerializer.Deserialize<GetClipsResponse?>(content) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{content}\" ");
        }
    }
}