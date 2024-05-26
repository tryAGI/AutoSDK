﻿//HintName: G.TeamsClient.TeamsGetDiscussionLegacy.g.cs

#nullable enable

namespace G
{
    public partial class TeamsClient
    {
        /// <summary>
        /// Get a discussion (Legacy)
        /// </summary>
        /// <param name="teamId"></param>
        /// <param name="discussionNumber"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<TeamDiscussion> TeamsGetDiscussionLegacyAsync(
            int teamId,
            int discussionNumber,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/teams/{teamId}/discussions/{discussionNumber}", global::System.UriKind.RelativeOrAbsolute));

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            return
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<TeamDiscussion>(content) ??
                throw new global::System.InvalidOperationException("Response deserialization failed for \"{content}\" ");
        }
    }
}