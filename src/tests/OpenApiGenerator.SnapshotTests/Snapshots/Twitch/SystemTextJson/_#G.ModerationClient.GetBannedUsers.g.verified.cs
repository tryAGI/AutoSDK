//HintName: G.ModerationClient.GetBannedUsers.g.cs
using System.Linq;

#nullable enable

namespace G
{
    public partial class ModerationClient
    {
        /// <summary>
        /// Gets all users that the broadcaster banned or put in a timeout.
        /// </summary>
        /// <param name="broadcasterId"></param>
        /// <param name="userId"></param>
        /// <param name="first"></param>
        /// <param name="after"></param>
        /// <param name="before"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<GetBannedUsersResponse> GetBannedUsersAsync(
            string broadcasterId,
            global::System.Collections.Generic.IList<string> userId,
            int first,
            string after,
            string before,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/moderation/banned?broadcaster_id={broadcasterId}&{string.Join("&", userId.Select(static x => $"userId={x}"))}&first={first}&after={after}&before={before}", global::System.UriKind.RelativeOrAbsolute));

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            return
                global::System.Text.Json.JsonSerializer.Deserialize<GetBannedUsersResponse?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}