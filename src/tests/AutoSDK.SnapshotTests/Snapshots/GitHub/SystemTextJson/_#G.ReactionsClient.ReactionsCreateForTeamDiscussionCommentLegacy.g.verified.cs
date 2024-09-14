//HintName: G.ReactionsClient.ReactionsCreateForTeamDiscussionCommentLegacy.g.cs

#nullable enable

namespace G
{
    public partial class ReactionsClient
    {
        partial void PrepareReactionsCreateForTeamDiscussionCommentLegacyArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref int teamId,
            ref int discussionNumber,
            ref int commentNumber,
            global::G.ReactionsCreateForTeamDiscussionCommentLegacyRequest request);
        partial void PrepareReactionsCreateForTeamDiscussionCommentLegacyRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            int teamId,
            int discussionNumber,
            int commentNumber,
            global::G.ReactionsCreateForTeamDiscussionCommentLegacyRequest request);
        partial void ProcessReactionsCreateForTeamDiscussionCommentLegacyResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessReactionsCreateForTeamDiscussionCommentLegacyResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create reaction for a team discussion comment (Legacy)<br/>
        /// **Deprecation Notice:** This endpoint route is deprecated and will be removed from the Teams API. We recommend migrating your existing code to use the new "[Create reaction for a team discussion comment](https://docs.github.com/rest/reactions/reactions#create-reaction-for-a-team-discussion-comment)" endpoint.<br/>
        /// Create a reaction to a [team discussion comment](https://docs.github.com/rest/teams/discussion-comments#get-a-discussion-comment).<br/>
        /// A response with an HTTP `200` status means that you already added the reaction type to this team discussion comment.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `write:discussion` scope to use this endpoint.
        /// </summary>
        /// <param name="teamId"></param>
        /// <param name="discussionNumber"></param>
        /// <param name="commentNumber"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        [global::System.Obsolete("This method marked as deprecated.")]
        public async global::System.Threading.Tasks.Task<global::G.Reaction> ReactionsCreateForTeamDiscussionCommentLegacyAsync(
            int teamId,
            int discussionNumber,
            int commentNumber,
            global::G.ReactionsCreateForTeamDiscussionCommentLegacyRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareReactionsCreateForTeamDiscussionCommentLegacyArguments(
                httpClient: _httpClient,
                teamId: ref teamId,
                discussionNumber: ref discussionNumber,
                commentNumber: ref commentNumber,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/teams/{teamId}/discussions/{discussionNumber}/comments/{commentNumber}/reactions", global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = global::System.Text.Json.JsonSerializer.Serialize(request, JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareReactionsCreateForTeamDiscussionCommentLegacyRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                teamId: teamId,
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
            ProcessReactionsCreateForTeamDiscussionCommentLegacyResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessReactionsCreateForTeamDiscussionCommentLegacyResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize<global::G.Reaction?>(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Create reaction for a team discussion comment (Legacy)<br/>
        /// **Deprecation Notice:** This endpoint route is deprecated and will be removed from the Teams API. We recommend migrating your existing code to use the new "[Create reaction for a team discussion comment](https://docs.github.com/rest/reactions/reactions#create-reaction-for-a-team-discussion-comment)" endpoint.<br/>
        /// Create a reaction to a [team discussion comment](https://docs.github.com/rest/teams/discussion-comments#get-a-discussion-comment).<br/>
        /// A response with an HTTP `200` status means that you already added the reaction type to this team discussion comment.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `write:discussion` scope to use this endpoint.
        /// </summary>
        /// <param name="teamId"></param>
        /// <param name="discussionNumber"></param>
        /// <param name="commentNumber"></param>
        /// <param name="content">
        /// The [reaction type](https://docs.github.com/rest/reactions/reactions#about-reactions) to add to the team discussion comment.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        [global::System.Obsolete("This method marked as deprecated.")]
        public async global::System.Threading.Tasks.Task<global::G.Reaction> ReactionsCreateForTeamDiscussionCommentLegacyAsync(
            int teamId,
            int discussionNumber,
            int commentNumber,
            global::G.ReactionsCreateForTeamDiscussionCommentLegacyRequestContent content,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.ReactionsCreateForTeamDiscussionCommentLegacyRequest
            {
                Content = content,
            };

            return await ReactionsCreateForTeamDiscussionCommentLegacyAsync(
                teamId: teamId,
                discussionNumber: discussionNumber,
                commentNumber: commentNumber,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}