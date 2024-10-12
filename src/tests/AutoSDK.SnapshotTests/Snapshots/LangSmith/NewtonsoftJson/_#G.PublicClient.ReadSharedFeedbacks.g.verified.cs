//HintName: G.PublicClient.ReadSharedFeedbacks.g.cs

#nullable enable

namespace G
{
    public partial class PublicClient
    {
        partial void PrepareReadSharedFeedbacksArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::System.Guid shareToken,
            ref global::G.AnyOf<global::System.Collections.Generic.IList<global::System.Guid>, object>? run,
            ref global::G.AnyOf<global::System.Collections.Generic.IList<string>, object>? key,
            ref global::G.AnyOf<global::System.Collections.Generic.IList<global::System.Guid>, object>? session,
            ref global::G.AnyOf<global::System.Collections.Generic.IList<global::G.SourceType>, object>? source,
            ref int? limit,
            ref int? offset,
            ref global::G.AnyOf<global::System.Collections.Generic.IList<global::System.Guid>, object>? user,
            ref global::G.AnyOf<bool?, object>? hasComment,
            ref global::G.AnyOf<bool?, object>? hasScore,
            ref global::G.AnyOf<global::G.FeedbackLevel?, object>? level);
        partial void PrepareReadSharedFeedbacksRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::System.Guid shareToken,
            global::G.AnyOf<global::System.Collections.Generic.IList<global::System.Guid>, object>? run,
            global::G.AnyOf<global::System.Collections.Generic.IList<string>, object>? key,
            global::G.AnyOf<global::System.Collections.Generic.IList<global::System.Guid>, object>? session,
            global::G.AnyOf<global::System.Collections.Generic.IList<global::G.SourceType>, object>? source,
            int? limit,
            int? offset,
            global::G.AnyOf<global::System.Collections.Generic.IList<global::System.Guid>, object>? user,
            global::G.AnyOf<bool?, object>? hasComment,
            global::G.AnyOf<bool?, object>? hasScore,
            global::G.AnyOf<global::G.FeedbackLevel?, object>? level);
        partial void ProcessReadSharedFeedbacksResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessReadSharedFeedbacksResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Read Shared Feedbacks
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
        /// <param name="level"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.FeedbackSchema>> ReadSharedFeedbacksAsync(
            global::System.Guid shareToken,
            global::G.AnyOf<global::System.Collections.Generic.IList<global::System.Guid>, object>? run = default,
            global::G.AnyOf<global::System.Collections.Generic.IList<string>, object>? key = default,
            global::G.AnyOf<global::System.Collections.Generic.IList<global::System.Guid>, object>? session = default,
            global::G.AnyOf<global::System.Collections.Generic.IList<global::G.SourceType>, object>? source = default,
            int? limit = 100,
            int? offset = 0,
            global::G.AnyOf<global::System.Collections.Generic.IList<global::System.Guid>, object>? user = default,
            global::G.AnyOf<bool?, object>? hasComment = default,
            global::G.AnyOf<bool?, object>? hasScore = default,
            global::G.AnyOf<global::G.FeedbackLevel?, object>? level = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareReadSharedFeedbacksArguments(
                httpClient: _httpClient,
                shareToken: ref shareToken,
                run: ref run,
                key: ref key,
                session: ref session,
                source: ref source,
                limit: ref limit,
                offset: ref offset,
                user: ref user,
                hasComment: ref hasComment,
                hasScore: ref hasScore,
                level: ref level);

            var __pathBuilder = new PathBuilder(
                path: $"/api/v1/public/{shareToken}/feedbacks",
                baseUri: _httpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("run", run?.ToString() ?? string.Empty) 
                .AddOptionalParameter("key", key?.ToString() ?? string.Empty) 
                .AddOptionalParameter("session", session?.ToString() ?? string.Empty) 
                .AddOptionalParameter("source", source?.ToString() ?? string.Empty) 
                .AddOptionalParameter("limit", limit?.ToString()) 
                .AddOptionalParameter("offset", offset?.ToString()) 
                .AddOptionalParameter("user", user?.ToString() ?? string.Empty) 
                .AddOptionalParameter("has_comment", hasComment?.ToString() ?? string.Empty) 
                .AddOptionalParameter("has_score", hasScore?.ToString() ?? string.Empty) 
                .AddOptionalParameter("level", level?.ToString() ?? string.Empty) 
                ; 
            var __path = __pathBuilder.ToString();
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareReadSharedFeedbacksRequest(
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
            ProcessReadSharedFeedbacksResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessReadSharedFeedbacksResponseContent(
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