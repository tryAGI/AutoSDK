//HintName: G.ModerationClient.GetModerators.g.cs
using System.Linq;

#nullable enable

namespace G
{
    public partial class ModerationClient
    {
        /// <summary>
        /// Gets all users allowed to moderate the broadcaster’s chat room.
        /// </summary>
        /// <param name="broadcasterId"></param>
        /// <param name="userId"></param>
        /// <param name="first"></param>
        /// <param name="after"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<GetModeratorsResponse> GetModeratorsAsync(
            string broadcasterId,
            global::System.Collections.Generic.IList<string> userId,
            string first,
            string after,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/moderation/moderators?broadcaster_id={broadcasterId}&{string.Join("&", userId.Select(static x => $"userId={x}"))}&first={first}&after={after}", global::System.UriKind.RelativeOrAbsolute));

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            return
                global::System.Text.Json.JsonSerializer.Deserialize<GetModeratorsResponse?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}