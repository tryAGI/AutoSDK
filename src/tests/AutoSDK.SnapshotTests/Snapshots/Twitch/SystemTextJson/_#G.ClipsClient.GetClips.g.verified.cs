//HintName: G.ClipsClient.GetClips.g.cs
using System.Linq;

#nullable enable

namespace G
{
    public partial class ClipsClient
    {
        partial void PrepareGetClipsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? broadcasterId,
            ref string? gameId,
            global::System.Collections.Generic.IList<string>? id,
            ref global::System.DateTime startedAt,
            ref global::System.DateTime endedAt,
            ref int first,
            ref string? before,
            ref string? after,
            ref bool isFeatured);
        partial void PrepareGetClipsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? broadcasterId,
            string? gameId,
            global::System.Collections.Generic.IList<string>? id,
            global::System.DateTime startedAt,
            global::System.DateTime endedAt,
            int first,
            string? before,
            string? after,
            bool isFeatured);
        partial void ProcessGetClipsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGetClipsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

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
            string? broadcasterId = default,
            string? gameId = default,
            global::System.Collections.Generic.IList<string>? id = default,
            global::System.DateTime startedAt = default,
            global::System.DateTime endedAt = default,
            int first = default,
            string? before = default,
            string? after = default,
            bool isFeatured = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareGetClipsArguments(
                httpClient: _httpClient,
                broadcasterId: ref broadcasterId,
                gameId: ref gameId,
                id: id,
                startedAt: ref startedAt,
                endedAt: ref endedAt,
                first: ref first,
                before: ref before,
                after: ref after,
                isFeatured: ref isFeatured);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/clips?broadcaster_id={broadcasterId}&game_id={gameId}&{string.Join("&", id?.Select(static x => $"id={x}") ?? global::System.Array.Empty<string>())}&started_at={startedAt:yyyy-MM-ddTHH:mm:ssZ}&ended_at={endedAt:yyyy-MM-ddTHH:mm:ssZ}&first={first}&before={before}&after={after}&is_featured={isFeatured}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareGetClipsRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                broadcasterId: broadcasterId,
                gameId: gameId,
                id: id,
                startedAt: startedAt,
                endedAt: endedAt,
                first: first,
                before: before,
                after: after,
                isFeatured: isFeatured);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessGetClipsResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessGetClipsResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize<global::G.GetClipsResponse?>(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}