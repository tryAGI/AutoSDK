//HintName: G.ReactionsClient.ReactionsListForTeamDiscussionInOrg.g.cs

#nullable enable

namespace G
{
    public partial class ReactionsClient
    {
        /// <summary>
        /// List reactions for a team discussion
        /// </summary>
        /// <param name="org"></param>
        /// <param name="teamSlug"></param>
        /// <param name="discussionNumber"></param>
        /// <param name="content"></param>
        /// <param name="perPage"></param>
        /// <param name="page"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<Reaction>> ReactionsListForTeamDiscussionInOrgAsync(
            string org,
            string teamSlug,
            int discussionNumber,
            ReactionsListForTeamDiscussionInOrgContent content,
            int perPage,
            int page,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var contentValue = content switch
            {
                ReactionsListForTeamDiscussionInOrgContent.Plus1 => "+1",
                ReactionsListForTeamDiscussionInOrgContent.Minus1 => "-1",
                ReactionsListForTeamDiscussionInOrgContent.Laugh => "laugh",
                ReactionsListForTeamDiscussionInOrgContent.Confused => "confused",
                ReactionsListForTeamDiscussionInOrgContent.Heart => "heart",
                ReactionsListForTeamDiscussionInOrgContent.Hooray => "hooray",
                ReactionsListForTeamDiscussionInOrgContent.Rocket => "rocket",
                ReactionsListForTeamDiscussionInOrgContent.Eyes => "eyes",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/orgs/{org}/teams/{teamSlug}/discussions/{discussionNumber}/reactions?content={contentValue}&per_page={perPage}&page={page}", global::System.UriKind.RelativeOrAbsolute));

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            return
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::System.Collections.Generic.IList<Reaction>?>(__content) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}