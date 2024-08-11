//HintName: G.TeamsClient.TeamsCreateDiscussionInOrg.g.cs

#nullable enable

namespace G
{
    public partial class TeamsClient
    {
        partial void PrepareTeamsCreateDiscussionInOrgArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string org,
            ref string teamSlug,
            global::G.TeamsCreateDiscussionInOrgRequest request);
        partial void PrepareTeamsCreateDiscussionInOrgRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string org,
            string teamSlug,
            global::G.TeamsCreateDiscussionInOrgRequest request);
        partial void ProcessTeamsCreateDiscussionInOrgResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessTeamsCreateDiscussionInOrgResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create a discussion<br/>
        /// Creates a new discussion post on a team's page.<br/>
        /// This endpoint triggers [notifications](https://docs.github.com/github/managing-subscriptions-and-notifications-on-github/about-notifications). Creating content too quickly using this endpoint may result in secondary rate limiting. For more information, see "[Rate limits for the API](https://docs.github.com/rest/overview/rate-limits-for-the-rest-api#about-secondary-rate-limits)" and "[Best practices for using the REST API](https://docs.github.com/rest/guides/best-practices-for-using-the-rest-api)."<br/>
        /// **Note:** You can also specify a team by `org_id` and `team_id` using the route `POST /organizations/{org_id}/team/{team_id}/discussions`.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `write:discussion` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="teamSlug"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.TeamDiscussion> TeamsCreateDiscussionInOrgAsync(
            string org,
            string teamSlug,
            global::G.TeamsCreateDiscussionInOrgRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareTeamsCreateDiscussionInOrgArguments(
                httpClient: _httpClient,
                org: ref org,
                teamSlug: ref teamSlug,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/orgs/{org}/teams/{teamSlug}/discussions", global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: global::System.Text.Json.JsonSerializer.Serialize(request, _jsonSerializerOptions),
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareTeamsCreateDiscussionInOrgRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                org: org,
                teamSlug: teamSlug,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessTeamsCreateDiscussionInOrgResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessTeamsCreateDiscussionInOrgResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize<global::G.TeamDiscussion?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Create a discussion<br/>
        /// Creates a new discussion post on a team's page.<br/>
        /// This endpoint triggers [notifications](https://docs.github.com/github/managing-subscriptions-and-notifications-on-github/about-notifications). Creating content too quickly using this endpoint may result in secondary rate limiting. For more information, see "[Rate limits for the API](https://docs.github.com/rest/overview/rate-limits-for-the-rest-api#about-secondary-rate-limits)" and "[Best practices for using the REST API](https://docs.github.com/rest/guides/best-practices-for-using-the-rest-api)."<br/>
        /// **Note:** You can also specify a team by `org_id` and `team_id` using the route `POST /organizations/{org_id}/team/{team_id}/discussions`.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `write:discussion` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="teamSlug"></param>
        /// <param name="title">
        /// The discussion post's title.
        /// </param>
        /// <param name="body">
        /// The discussion post's body text.
        /// </param>
        /// <param name="@private">
        /// Private posts are only visible to team members, organization owners, and team maintainers. Public posts are visible to all members of the organization. Set to `true` to create a private post.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.TeamDiscussion> TeamsCreateDiscussionInOrgAsync(
            string org,
            string teamSlug,
            string title,
            string body,
            bool @private = false,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.TeamsCreateDiscussionInOrgRequest
            {
                Title = title,
                Body = body,
                Private = @private,
            };

            return await TeamsCreateDiscussionInOrgAsync(
                org: org,
                teamSlug: teamSlug,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}