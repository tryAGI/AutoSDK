//HintName: G.TeamsClient.TeamsCreateDiscussionCommentInOrg.g.cs

#nullable enable

namespace G
{
    public partial class TeamsClient
    {
        partial void PrepareTeamsCreateDiscussionCommentInOrgArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string org,
            ref string teamSlug,
            ref int discussionNumber,
            global::G.TeamsCreateDiscussionCommentInOrgRequest request);
        partial void PrepareTeamsCreateDiscussionCommentInOrgRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string org,
            string teamSlug,
            int discussionNumber,
            global::G.TeamsCreateDiscussionCommentInOrgRequest request);
        partial void ProcessTeamsCreateDiscussionCommentInOrgResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessTeamsCreateDiscussionCommentInOrgResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create a discussion comment<br/>
        /// Creates a new comment on a team discussion.<br/>
        /// This endpoint triggers [notifications](https://docs.github.com/github/managing-subscriptions-and-notifications-on-github/about-notifications). Creating content too quickly using this endpoint may result in secondary rate limiting. For more information, see "[Rate limits for the API](https://docs.github.com/rest/overview/rate-limits-for-the-rest-api#about-secondary-rate-limits)" and "[Best practices for using the REST API](https://docs.github.com/rest/guides/best-practices-for-using-the-rest-api)."<br/>
        /// **Note:** You can also specify a team by `org_id` and `team_id` using the route `POST /organizations/{org_id}/team/{team_id}/discussions/{discussion_number}/comments`.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `write:discussion` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="teamSlug"></param>
        /// <param name="discussionNumber"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.TeamDiscussionComment> TeamsCreateDiscussionCommentInOrgAsync(
            string org,
            string teamSlug,
            int discussionNumber,
            global::G.TeamsCreateDiscussionCommentInOrgRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareTeamsCreateDiscussionCommentInOrgArguments(
                httpClient: _httpClient,
                org: ref org,
                teamSlug: ref teamSlug,
                discussionNumber: ref discussionNumber,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/orgs/{org}/teams/{teamSlug}/discussions/{discussionNumber}/comments", global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: global::Newtonsoft.Json.JsonConvert.SerializeObject(request, _jsonSerializerOptions),
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareTeamsCreateDiscussionCommentInOrgRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                org: org,
                teamSlug: teamSlug,
                discussionNumber: discussionNumber,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessTeamsCreateDiscussionCommentInOrgResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessTeamsCreateDiscussionCommentInOrgResponseContent(
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
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.TeamDiscussionComment?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Create a discussion comment<br/>
        /// Creates a new comment on a team discussion.<br/>
        /// This endpoint triggers [notifications](https://docs.github.com/github/managing-subscriptions-and-notifications-on-github/about-notifications). Creating content too quickly using this endpoint may result in secondary rate limiting. For more information, see "[Rate limits for the API](https://docs.github.com/rest/overview/rate-limits-for-the-rest-api#about-secondary-rate-limits)" and "[Best practices for using the REST API](https://docs.github.com/rest/guides/best-practices-for-using-the-rest-api)."<br/>
        /// **Note:** You can also specify a team by `org_id` and `team_id` using the route `POST /organizations/{org_id}/team/{team_id}/discussions/{discussion_number}/comments`.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `write:discussion` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="teamSlug"></param>
        /// <param name="discussionNumber"></param>
        /// <param name="body">
        /// The discussion comment's body text.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.TeamDiscussionComment> TeamsCreateDiscussionCommentInOrgAsync(
            string org,
            string teamSlug,
            int discussionNumber,
            string body,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.TeamsCreateDiscussionCommentInOrgRequest
            {
                Body = body,
            };

            return await TeamsCreateDiscussionCommentInOrgAsync(
                org: org,
                teamSlug: teamSlug,
                discussionNumber: discussionNumber,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}