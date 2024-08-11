//HintName: G.TeamsClient.TeamsListDiscussionCommentsInOrg.g.cs

#nullable enable

namespace G
{
    public partial class TeamsClient
    {
        partial void PrepareTeamsListDiscussionCommentsInOrgArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string org,
            ref string teamSlug,
            ref int discussionNumber,
            ref global::G.TeamsListDiscussionCommentsInOrgDirection? direction,
            ref int perPage,
            ref int page);
        partial void PrepareTeamsListDiscussionCommentsInOrgRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string org,
            string teamSlug,
            int discussionNumber,
            global::G.TeamsListDiscussionCommentsInOrgDirection? direction,
            int perPage,
            int page);
        partial void ProcessTeamsListDiscussionCommentsInOrgResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessTeamsListDiscussionCommentsInOrgResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List discussion comments<br/>
        /// List all comments on a team discussion.<br/>
        /// **Note:** You can also specify a team by `org_id` and `team_id` using the route `GET /organizations/{org_id}/team/{team_id}/discussions/{discussion_number}/comments`.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `read:discussion` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="teamSlug"></param>
        /// <param name="discussionNumber"></param>
        /// <param name="direction">
        /// Default Value: desc
        /// </param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.TeamDiscussionComment>> TeamsListDiscussionCommentsInOrgAsync(
            string org,
            string teamSlug,
            int discussionNumber,
            global::G.TeamsListDiscussionCommentsInOrgDirection? direction,
            int perPage,
            int page,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareTeamsListDiscussionCommentsInOrgArguments(
                httpClient: _httpClient,
                org: ref org,
                teamSlug: ref teamSlug,
                discussionNumber: ref discussionNumber,
                direction: ref direction,
                perPage: ref perPage,
                page: ref page);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/orgs/{org}/teams/{teamSlug}/discussions/{discussionNumber}/comments?direction={direction}&per_page={perPage}&page={page}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareTeamsListDiscussionCommentsInOrgRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                org: org,
                teamSlug: teamSlug,
                discussionNumber: discussionNumber,
                direction: direction,
                perPage: perPage,
                page: page);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessTeamsListDiscussionCommentsInOrgResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessTeamsListDiscussionCommentsInOrgResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize<global::System.Collections.Generic.IList<global::G.TeamDiscussionComment>?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}