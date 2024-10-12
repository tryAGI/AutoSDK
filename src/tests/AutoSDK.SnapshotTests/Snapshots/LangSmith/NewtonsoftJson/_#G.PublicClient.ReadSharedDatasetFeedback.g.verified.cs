//HintName: G.PublicClient.ReadSharedDatasetFeedback.g.cs

#nullable enable

namespace G
{
    public partial class PublicClient
    {
        partial void PrepareReadSharedDatasetFeedbackArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::System.Guid shareToken,
            global::System.Collections.Generic.IList<global::System.Guid>? run,
            global::System.Collections.Generic.IList<string>? key,
            global::System.Collections.Generic.IList<global::System.Guid>? session,
            global::System.Collections.Generic.IList<global::G.SourceType>? source,
            ref int? limit,
            ref int? offset,
            global::System.Collections.Generic.IList<global::System.Guid>? user,
            ref bool? hasComment,
            ref bool? hasScore,
            ref global::G.FeedbackLevel? level);
        partial void PrepareReadSharedDatasetFeedbackRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::System.Guid shareToken,
            global::System.Collections.Generic.IList<global::System.Guid>? run,
            global::System.Collections.Generic.IList<string>? key,
            global::System.Collections.Generic.IList<global::System.Guid>? session,
            global::System.Collections.Generic.IList<global::G.SourceType>? source,
            int? limit,
            int? offset,
            global::System.Collections.Generic.IList<global::System.Guid>? user,
            bool? hasComment,
            bool? hasScore,
            global::G.FeedbackLevel? level);
        partial void ProcessReadSharedDatasetFeedbackResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessReadSharedDatasetFeedbackResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Read Shared Dataset Feedback<br/>
        /// Get feedback for runs in projects run over a dataset that has been shared.
        /// </summary>
        /// <param name="shareToken"></param>
        /// <param name="run"></param>
        /// <param name="key"></param>
        /// <param name="session"></param>
        /// <param name="source"></param>
        /// <param name="limit">
        /// Default Value: 100
        /// </param>
        /// <param name="offset">
        /// Default Value: 0
        /// </param>
        /// <param name="user"></param>
        /// <param name="hasComment"></param>
        /// <param name="hasScore"></param>
        /// <param name="level">
        /// Enum for feedback levels.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.FeedbackSchema>> ReadSharedDatasetFeedbackAsync(
            global::System.Guid shareToken,
            global::System.Collections.Generic.IList<global::System.Guid>? run = default,
            global::System.Collections.Generic.IList<string>? key = default,
            global::System.Collections.Generic.IList<global::System.Guid>? session = default,
            global::System.Collections.Generic.IList<global::G.SourceType>? source = default,
            int? limit = 100,
            int? offset = 0,
            global::System.Collections.Generic.IList<global::System.Guid>? user = default,
            bool? hasComment = default,
            bool? hasScore = default,
            global::G.FeedbackLevel? level = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareReadSharedDatasetFeedbackArguments(
                httpClient: _httpClient,
                shareToken: ref shareToken,
                run: run,
                key: key,
                session: session,
                source: source,
                limit: ref limit,
                offset: ref offset,
                user: user,
                hasComment: ref hasComment,
                hasScore: ref hasScore,
                level: ref level);

            var levelValue = level switch
            {
                global::G.FeedbackLevel.Run => "run",
                global::G.FeedbackLevel.Session => "session",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var __pathBuilder = new PathBuilder(
                path: $"/api/v1/public/{shareToken}/datasets/feedback",
                baseUri: _httpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("run", run, selector: static x => x.ToString(), delimiter: ",", explode: true) 
                .AddOptionalParameter("key", key, delimiter: ",", explode: true) 
                .AddOptionalParameter("session", session, selector: static x => x.ToString(), delimiter: ",", explode: true) 
                .AddOptionalParameter("limit", limit?.ToString()) 
                .AddOptionalParameter("offset", offset?.ToString()) 
                .AddOptionalParameter("user", user, selector: static x => x.ToString(), delimiter: ",", explode: true) 
                .AddOptionalParameter("has_comment", hasComment?.ToString()) 
                .AddOptionalParameter("has_score", hasScore?.ToString()) 
                .AddOptionalParameter("level", levelValue?.ToString()) 
                ; 
            var __path = __pathBuilder.ToString();
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareReadSharedDatasetFeedbackRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                shareToken: shareToken,
                run: run,
                key: key,
                session: session,
                source: source,
                limit: limit,
                offset: offset,
                user: user,
                hasComment: hasComment,
                hasScore: hasScore,
                level: level);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessReadSharedDatasetFeedbackResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessReadSharedDatasetFeedbackResponseContent(
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
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::System.Collections.Generic.IList<global::G.FeedbackSchema>?>(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}