//HintName: G.TeamsClient.TeamsCreateDiscussionLegacy.g.cs

#nullable enable

namespace G
{
    public partial class TeamsClient
    {
        /// <summary>
        /// Create a discussion (Legacy)
        /// </summary>
        /// <param name="teamId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<TeamDiscussion> TeamsCreateDiscussionLegacyAsync(
            int teamId,
            TeamsCreateDiscussionLegacyRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/teams/{teamId}/discussions", global::System.UriKind.RelativeOrAbsolute));
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
                global::System.Text.Json.JsonSerializer.Deserialize<TeamDiscussion?>(__content) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Create a discussion (Legacy)
        /// </summary>
        /// <param name="teamId"></param>
        /// <param name="title"></param>
        /// <param name="body"></param>
        /// <param name="@private"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<TeamDiscussion> TeamsCreateDiscussionLegacyAsync(
            int teamId,
            string title,
            string body,
            bool @private = false,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new TeamsCreateDiscussionLegacyRequest
            {
                Title = title,
                Body = body,
                Private = @private,
            };

            return await TeamsCreateDiscussionLegacyAsync(
                teamId: teamId,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}