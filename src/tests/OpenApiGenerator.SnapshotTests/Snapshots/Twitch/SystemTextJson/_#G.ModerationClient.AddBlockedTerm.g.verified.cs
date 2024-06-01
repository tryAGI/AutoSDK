//HintName: G.ModerationClient.AddBlockedTerm.g.cs

#nullable enable

namespace G
{
    public partial class ModerationClient
    {
        /// <summary>
        /// Adds a word or phrase to the broadcaster’s list of blocked terms.
        /// </summary>
        /// <param name="broadcasterId"></param>
        /// <param name="moderatorId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<AddBlockedTermResponse> AddBlockedTermAsync(
            string broadcasterId,
            string moderatorId,
            AddBlockedTermBody request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/moderation/blocked_terms?broadcaster_id={broadcasterId}&moderator_id={moderatorId}", global::System.UriKind.RelativeOrAbsolute));
            httpRequest.Content = new global::System.Net.Http.StringContent(
                content: global::System.Text.Json.JsonSerializer.Serialize(request),
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            return
                global::System.Text.Json.JsonSerializer.Deserialize<AddBlockedTermResponse?>(__content) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Adds a word or phrase to the broadcaster’s list of blocked terms.
        /// </summary>
        /// <param name="broadcasterId"></param>
        /// <param name="moderatorId"></param>
        /// <param name="text"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<AddBlockedTermResponse> AddBlockedTermAsync(
            string broadcasterId,
            string moderatorId,
            string text,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new AddBlockedTermBody
            {
                Text = text,
            };

            return await AddBlockedTermAsync(
                broadcasterId: broadcasterId,
                moderatorId: moderatorId,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}