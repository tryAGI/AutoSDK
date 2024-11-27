//HintName: G.ReactionsClient.ReactionsListForTeamDiscussionCommentLegacy.g.cs

#nullable enable

namespace G
{
    public partial class ReactionsClient
    {
        partial void PrepareReactionsListForTeamDiscussionCommentLegacyArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref int teamId,
            ref int discussionNumber,
            ref int commentNumber,
            ref global::G.ReactionsListForTeamDiscussionCommentLegacyContent? content,
            ref int? perPage,
            ref int? page);
        partial void PrepareReactionsListForTeamDiscussionCommentLegacyRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            int teamId,
            int discussionNumber,
            int commentNumber,
            global::G.ReactionsListForTeamDiscussionCommentLegacyContent? content,
            int? perPage,
            int? page);
        partial void ProcessReactionsListForTeamDiscussionCommentLegacyResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessReactionsListForTeamDiscussionCommentLegacyResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List reactions for a team discussion comment (Legacy)<br/>
        /// &gt; [!WARNING]<br/>
        /// &gt; **Deprecation notice:** This endpoint route is deprecated and will be removed from the Teams API. We recommend migrating your existing code to use the new [`List reactions for a team discussion comment`](https://docs.github.com/rest/reactions/reactions#list-reactions-for-a-team-discussion-comment) endpoint.<br/>
        /// List the reactions to a [team discussion comment](https://docs.github.com/rest/teams/discussion-comments#get-a-discussion-comment).<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `read:discussion` scope to use this endpoint.
        /// </summary>
        /// <param name="teamId"></param>
        /// <param name="discussionNumber"></param>
        /// <param name="commentNumber"></param>
        /// <param name="content"></param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        [global::System.Obsolete("This method marked as deprecated.")]
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.Reaction>> ReactionsListForTeamDiscussionCommentLegacyAsync(
            int teamId,
            int discussionNumber,
            int commentNumber,
            global::G.ReactionsListForTeamDiscussionCommentLegacyContent? content = default,
            int? perPage = default,
            int? page = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareReactionsListForTeamDiscussionCommentLegacyArguments(
                httpClient: HttpClient,
                teamId: ref teamId,
                discussionNumber: ref discussionNumber,
                commentNumber: ref commentNumber,
                content: ref content,
                perPage: ref perPage,
                page: ref page);

            var contentValue = content switch
            {
                global::G.ReactionsListForTeamDiscussionCommentLegacyContent.Plus1 => "+1",
                global::G.ReactionsListForTeamDiscussionCommentLegacyContent.Minus1 => "-1",
                global::G.ReactionsListForTeamDiscussionCommentLegacyContent.Laugh => "laugh",
                global::G.ReactionsListForTeamDiscussionCommentLegacyContent.Confused => "confused",
                global::G.ReactionsListForTeamDiscussionCommentLegacyContent.Heart => "heart",
                global::G.ReactionsListForTeamDiscussionCommentLegacyContent.Hooray => "hooray",
                global::G.ReactionsListForTeamDiscussionCommentLegacyContent.Rocket => "rocket",
                global::G.ReactionsListForTeamDiscussionCommentLegacyContent.Eyes => "eyes",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var __pathBuilder = new PathBuilder(
                path: $"/teams/{teamId}/discussions/{discussionNumber}/comments/{commentNumber}/reactions",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("content", contentValue?.ToString()) 
                .AddOptionalParameter("per_page", perPage?.ToString()) 
                .AddOptionalParameter("page", page?.ToString()) 
                ; 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareReactionsListForTeamDiscussionCommentLegacyRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                teamId: teamId,
                discussionNumber: discussionNumber,
                commentNumber: commentNumber,
                content: content,
                perPage: perPage,
                page: page);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessReactionsListForTeamDiscussionCommentLegacyResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            if (ReadResponseAsString)
            {
                var __content = await __response.Content.ReadAsStringAsync().ConfigureAwait(false);

                ProcessResponseContent(
                    client: HttpClient,
                    response: __response,
                    content: ref __content);
                ProcessReactionsListForTeamDiscussionCommentLegacyResponseContent(
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
                    global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::System.Collections.Generic.IList<global::G.Reaction>?>(__content, JsonSerializerOptions) ??
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

                using var __content = await __response.Content.ReadAsStreamAsync().ConfigureAwait(false);

                return
                    global::Newtonsoft.Json.JsonSerializer.Create(JsonSerializerOptions).Deserialize<global::System.Collections.Generic.IList<global::G.Reaction>?>(new global::Newtonsoft.Json.JsonTextReader(new global::System.IO.StreamReader(__content))) ??
                    throw new global::System.InvalidOperationException("Response deserialization failed.");
            }
        }
    }
}