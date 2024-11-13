//HintName: G.ReactionsClient.ReactionsCreateForTeamDiscussionInOrg.g.cs

#nullable enable

namespace G
{
    public partial class ReactionsClient
    {
        partial void PrepareReactionsCreateForTeamDiscussionInOrgArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string org,
            ref string teamSlug,
            ref int discussionNumber,
            global::G.ReactionsCreateForTeamDiscussionInOrgRequest request);
        partial void PrepareReactionsCreateForTeamDiscussionInOrgRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string org,
            string teamSlug,
            int discussionNumber,
            global::G.ReactionsCreateForTeamDiscussionInOrgRequest request);
        partial void ProcessReactionsCreateForTeamDiscussionInOrgResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessReactionsCreateForTeamDiscussionInOrgResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create reaction for a team discussion<br/>
        /// Create a reaction to a [team discussion](https://docs.github.com/rest/teams/discussions#get-a-discussion).<br/>
        /// A response with an HTTP `200` status means that you already added the reaction type to this team discussion.<br/>
        /// &gt; [!NOTE]<br/>
        /// &gt; You can also specify a team by `org_id` and `team_id` using the route `POST /organizations/:org_id/team/:team_id/discussions/:discussion_number/reactions`.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `write:discussion` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="teamSlug"></param>
        /// <param name="discussionNumber"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.Reaction> ReactionsCreateForTeamDiscussionInOrgAsync(
            string org,
            string teamSlug,
            int discussionNumber,
            global::G.ReactionsCreateForTeamDiscussionInOrgRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareReactionsCreateForTeamDiscussionInOrgArguments(
                httpClient: HttpClient,
                org: ref org,
                teamSlug: ref teamSlug,
                discussionNumber: ref discussionNumber,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: $"/orgs/{org}/teams/{teamSlug}/discussions/{discussionNumber}/reactions",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = request.ToJson(JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareReactionsCreateForTeamDiscussionInOrgRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                org: org,
                teamSlug: teamSlug,
                discussionNumber: discussionNumber,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessReactionsCreateForTeamDiscussionInOrgResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            if (ReadResponseAsString)
            {
                var __content = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                ProcessResponseContent(
                    client: HttpClient,
                    response: __response,
                    content: ref __content);
                ProcessReactionsCreateForTeamDiscussionInOrgResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();
                }
                catch (global::System.Net.Http.HttpRequestException __ex)
                {
                    throw new global::G.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }

                return
                    global::G.Reaction.FromJson(__content, JsonSerializerOptions) ??
                    throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
            }
            else
            {
                try
                {
                    __response.EnsureSuccessStatusCode();
                }
                catch (global::System.Net.Http.HttpRequestException __ex)
                {
                    throw new global::G.ApiException(
                        message: __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }

                using var __content = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);

                return
                    await global::G.Reaction.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
                    throw new global::System.InvalidOperationException("Response deserialization failed.");
            }
        }

        /// <summary>
        /// Create reaction for a team discussion<br/>
        /// Create a reaction to a [team discussion](https://docs.github.com/rest/teams/discussions#get-a-discussion).<br/>
        /// A response with an HTTP `200` status means that you already added the reaction type to this team discussion.<br/>
        /// &gt; [!NOTE]<br/>
        /// &gt; You can also specify a team by `org_id` and `team_id` using the route `POST /organizations/:org_id/team/:team_id/discussions/:discussion_number/reactions`.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `write:discussion` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="teamSlug"></param>
        /// <param name="discussionNumber"></param>
        /// <param name="content">
        /// The [reaction type](https://docs.github.com/rest/reactions/reactions#about-reactions) to add to the team discussion.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.Reaction> ReactionsCreateForTeamDiscussionInOrgAsync(
            string org,
            string teamSlug,
            int discussionNumber,
            global::G.ReactionsCreateForTeamDiscussionInOrgRequestContent content,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.ReactionsCreateForTeamDiscussionInOrgRequest
            {
                Content = content,
            };

            return await ReactionsCreateForTeamDiscussionInOrgAsync(
                org: org,
                teamSlug: teamSlug,
                discussionNumber: discussionNumber,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}