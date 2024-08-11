//HintName: G.ReactionsClient.ReactionsListForTeamDiscussionLegacy.g.cs

#nullable enable

namespace G
{
    public partial class ReactionsClient
    {
        partial void PrepareReactionsListForTeamDiscussionLegacyArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref int teamId,
            ref int discussionNumber,
            ref global::G.ReactionsListForTeamDiscussionLegacyContent? content,
            ref int perPage,
            ref int page);
        partial void PrepareReactionsListForTeamDiscussionLegacyRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            int teamId,
            int discussionNumber,
            global::G.ReactionsListForTeamDiscussionLegacyContent? content,
            int perPage,
            int page);
        partial void ProcessReactionsListForTeamDiscussionLegacyResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessReactionsListForTeamDiscussionLegacyResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List reactions for a team discussion (Legacy)<br/>
        /// **Deprecation Notice:** This endpoint route is deprecated and will be removed from the Teams API. We recommend migrating your existing code to use the new [`List reactions for a team discussion`](https://docs.github.com/rest/reactions/reactions#list-reactions-for-a-team-discussion) endpoint.<br/>
        /// List the reactions to a [team discussion](https://docs.github.com/rest/teams/discussions#get-a-discussion).<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `read:discussion` scope to use this endpoint.
        /// </summary>
        /// <param name="teamId"></param>
        /// <param name="discussionNumber"></param>
        /// <param name="content"></param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        [global::System.Obsolete("This method marked as deprecated.")]
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.Reaction>> ReactionsListForTeamDiscussionLegacyAsync(
            int teamId,
            int discussionNumber,
            global::G.ReactionsListForTeamDiscussionLegacyContent? content,
            int perPage,
            int page,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareReactionsListForTeamDiscussionLegacyArguments(
                httpClient: _httpClient,
                teamId: ref teamId,
                discussionNumber: ref discussionNumber,
                content: ref content,
                perPage: ref perPage,
                page: ref page);

            var contentValue = content switch
            {
                global::G.ReactionsListForTeamDiscussionLegacyContent.Plus1 => "+1",
                global::G.ReactionsListForTeamDiscussionLegacyContent.Minus1 => "-1",
                global::G.ReactionsListForTeamDiscussionLegacyContent.Laugh => "laugh",
                global::G.ReactionsListForTeamDiscussionLegacyContent.Confused => "confused",
                global::G.ReactionsListForTeamDiscussionLegacyContent.Heart => "heart",
                global::G.ReactionsListForTeamDiscussionLegacyContent.Hooray => "hooray",
                global::G.ReactionsListForTeamDiscussionLegacyContent.Rocket => "rocket",
                global::G.ReactionsListForTeamDiscussionLegacyContent.Eyes => "eyes",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/teams/{teamId}/discussions/{discussionNumber}/reactions?content={contentValue}&per_page={perPage}&page={page}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareReactionsListForTeamDiscussionLegacyRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                teamId: teamId,
                discussionNumber: discussionNumber,
                content: content,
                perPage: perPage,
                page: page);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessReactionsListForTeamDiscussionLegacyResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessReactionsListForTeamDiscussionLegacyResponseContent(
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
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::System.Collections.Generic.IList<global::G.Reaction>?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}