//HintName: G.ReactionsClient.ReactionsCreateForTeamDiscussionCommentInOrg.g.cs

#nullable enable

namespace G
{
    public partial class ReactionsClient
    {
        partial void PrepareReactionsCreateForTeamDiscussionCommentInOrgArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string org,
            ref string teamSlug,
            ref int discussionNumber,
            ref int commentNumber,
            global::G.ReactionsCreateForTeamDiscussionCommentInOrgRequest request);
        partial void PrepareReactionsCreateForTeamDiscussionCommentInOrgRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string org,
            string teamSlug,
            int discussionNumber,
            int commentNumber,
            global::G.ReactionsCreateForTeamDiscussionCommentInOrgRequest request);
        partial void ProcessReactionsCreateForTeamDiscussionCommentInOrgResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessReactionsCreateForTeamDiscussionCommentInOrgResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create reaction for a team discussion comment<br/>
        /// Create a reaction to a [team discussion comment](https://docs.github.com/rest/teams/discussion-comments#get-a-discussion-comment).<br/>
        /// A response with an HTTP `200` status means that you already added the reaction type to this team discussion comment.<br/>
        /// **Note:** You can also specify a team by `org_id` and `team_id` using the route `POST /organizations/:org_id/team/:team_id/discussions/:discussion_number/comments/:comment_number/reactions`.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `write:discussion` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="teamSlug"></param>
        /// <param name="discussionNumber"></param>
        /// <param name="commentNumber"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.Reaction> ReactionsCreateForTeamDiscussionCommentInOrgAsync(
            string org,
            string teamSlug,
            int discussionNumber,
            int commentNumber,
            global::G.ReactionsCreateForTeamDiscussionCommentInOrgRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareReactionsCreateForTeamDiscussionCommentInOrgArguments(
                httpClient: _httpClient,
                org: ref org,
                teamSlug: ref teamSlug,
                discussionNumber: ref discussionNumber,
                commentNumber: ref commentNumber,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/orgs/{org}/teams/{teamSlug}/discussions/{discussionNumber}/comments/{commentNumber}/reactions", global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: global::System.Text.Json.JsonSerializer.Serialize(request, _jsonSerializerOptions),
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareReactionsCreateForTeamDiscussionCommentInOrgRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                org: org,
                teamSlug: teamSlug,
                discussionNumber: discussionNumber,
                commentNumber: commentNumber,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessReactionsCreateForTeamDiscussionCommentInOrgResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessReactionsCreateForTeamDiscussionCommentInOrgResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize<global::G.Reaction?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Create reaction for a team discussion comment<br/>
        /// Create a reaction to a [team discussion comment](https://docs.github.com/rest/teams/discussion-comments#get-a-discussion-comment).<br/>
        /// A response with an HTTP `200` status means that you already added the reaction type to this team discussion comment.<br/>
        /// **Note:** You can also specify a team by `org_id` and `team_id` using the route `POST /organizations/:org_id/team/:team_id/discussions/:discussion_number/comments/:comment_number/reactions`.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `write:discussion` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="teamSlug"></param>
        /// <param name="discussionNumber"></param>
        /// <param name="commentNumber"></param>
        /// <param name="content">
        /// The [reaction type](https://docs.github.com/rest/reactions/reactions#about-reactions) to add to the team discussion comment.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.Reaction> ReactionsCreateForTeamDiscussionCommentInOrgAsync(
            string org,
            string teamSlug,
            int discussionNumber,
            int commentNumber,
            global::G.ReactionsCreateForTeamDiscussionCommentInOrgRequestContent content,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.ReactionsCreateForTeamDiscussionCommentInOrgRequest
            {
                Content = content,
            };

            return await ReactionsCreateForTeamDiscussionCommentInOrgAsync(
                org: org,
                teamSlug: teamSlug,
                discussionNumber: discussionNumber,
                commentNumber: commentNumber,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}