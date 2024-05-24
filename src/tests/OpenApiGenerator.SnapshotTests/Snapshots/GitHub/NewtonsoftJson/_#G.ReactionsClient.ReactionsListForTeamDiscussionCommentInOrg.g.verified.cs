//HintName: G.ReactionsClient.ReactionsListForTeamDiscussionCommentInOrg.g.cs

#nullable enable

namespace G
{
    public partial class ReactionsClient
    {
        /// <summary>
        /// List reactions for a team discussion comment
        /// </summary>
        /// <param name="org"></param>
        /// <param name="teamSlug"></param>
        /// <param name="discussionNumber"></param>
        /// <param name="commentNumber"></param>
        /// <param name="content"></param>
        /// <param name="perPage"></param>
        /// <param name="page"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task ReactionsListForTeamDiscussionCommentInOrgAsync(
            string org,
            string teamSlug,
            int discussionNumber,
            int commentNumber,
            ReactionsListForTeamDiscussionCommentInOrgContent content,
            int perPage,
            int page,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var contentValue = content switch
            {
                ReactionsListForTeamDiscussionCommentInOrgContent.Plus1 => "+1",
                ReactionsListForTeamDiscussionCommentInOrgContent.Minus1 => "-1",
                ReactionsListForTeamDiscussionCommentInOrgContent.Laugh => "laugh",
                ReactionsListForTeamDiscussionCommentInOrgContent.Confused => "confused",
                ReactionsListForTeamDiscussionCommentInOrgContent.Heart => "heart",
                ReactionsListForTeamDiscussionCommentInOrgContent.Hooray => "hooray",
                ReactionsListForTeamDiscussionCommentInOrgContent.Rocket => "rocket",
                ReactionsListForTeamDiscussionCommentInOrgContent.Eyes => "eyes",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/orgs/{org}/teams/{teamSlug}/discussions/{discussionNumber}/comments/{commentNumber}/reactions?content={contentValue}&per_page={perPage}&page={page}", global::System.UriKind.RelativeOrAbsolute));

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();
        }
    }
}