//HintName: G.FeedbackClient.ReadFeedbacks.g.cs

#nullable enable

namespace G
{
    public partial class FeedbackClient
    {
        partial void PrepareReadFeedbacksArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::System.AnyOf<global::System.Collections.Generic.IList<global::System.Guid>, object>? run,
            ref global::System.AnyOf<global::System.Collections.Generic.IList<string>, object>? key,
            ref global::System.AnyOf<global::System.Collections.Generic.IList<global::System.Guid>, object>? session,
            ref global::System.AnyOf<global::System.Collections.Generic.IList<global::G.SourceType>, object>? source,
            ref int limit,
            ref int offset,
            ref global::System.AnyOf<global::System.Collections.Generic.IList<global::System.Guid>, object>? user,
            ref global::System.AnyOf<bool?, object>? hasComment,
            ref global::System.AnyOf<bool?, object>? hasScore,
            ref global::System.AnyOf<global::G.FeedbackLevel?, object>? level,
            ref global::System.AnyOf<global::System.DateTime?, object>? maxCreatedAt,
            ref global::System.AnyOf<global::System.DateTime?, object>? minCreatedAt);
        partial void PrepareReadFeedbacksRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::System.AnyOf<global::System.Collections.Generic.IList<global::System.Guid>, object>? run,
            global::System.AnyOf<global::System.Collections.Generic.IList<string>, object>? key,
            global::System.AnyOf<global::System.Collections.Generic.IList<global::System.Guid>, object>? session,
            global::System.AnyOf<global::System.Collections.Generic.IList<global::G.SourceType>, object>? source,
            int limit,
            int offset,
            global::System.AnyOf<global::System.Collections.Generic.IList<global::System.Guid>, object>? user,
            global::System.AnyOf<bool?, object>? hasComment,
            global::System.AnyOf<bool?, object>? hasScore,
            global::System.AnyOf<global::G.FeedbackLevel?, object>? level,
            global::System.AnyOf<global::System.DateTime?, object>? maxCreatedAt,
            global::System.AnyOf<global::System.DateTime?, object>? minCreatedAt);
        partial void ProcessReadFeedbacksResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessReadFeedbacksResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Read Feedbacks<br/>
        /// List all Feedback by query params.
        /// </summary>
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
        /// <param name="maxCreatedAt"></param>
        /// <param name="minCreatedAt"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.FeedbackSchema>> ReadFeedbacksAsync(
            global::System.AnyOf<global::System.Collections.Generic.IList<global::System.Guid>, object>? run = default,
            global::System.AnyOf<global::System.Collections.Generic.IList<string>, object>? key = default,
            global::System.AnyOf<global::System.Collections.Generic.IList<global::System.Guid>, object>? session = default,
            global::System.AnyOf<global::System.Collections.Generic.IList<global::G.SourceType>, object>? source = default,
            int limit = 100,
            int offset = 0,
            global::System.AnyOf<global::System.Collections.Generic.IList<global::System.Guid>, object>? user = default,
            global::System.AnyOf<bool?, object>? hasComment = default,
            global::System.AnyOf<bool?, object>? hasScore = default,
            global::System.AnyOf<global::G.FeedbackLevel?, object>? level = default,
            global::System.AnyOf<global::System.DateTime?, object>? maxCreatedAt = default,
            global::System.AnyOf<global::System.DateTime?, object>? minCreatedAt = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareReadFeedbacksArguments(
                httpClient: _httpClient,
                run: ref run,
                key: ref key,
                session: ref session,
                source: ref source,
                limit: ref limit,
                offset: ref offset,
                user: ref user,
                hasComment: ref hasComment,
                hasScore: ref hasScore,
                level: ref level,
                maxCreatedAt: ref maxCreatedAt,
                minCreatedAt: ref minCreatedAt);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/api/v1/feedback?run={run}&key={key}&session={session}&source={source}&limit={limit}&offset={offset}&user={user}&has_comment={hasComment}&has_score={hasScore}&level={level}&max_created_at={maxCreatedAt}&min_created_at={minCreatedAt}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareReadFeedbacksRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                run: run,
                key: key,
                session: session,
                source: source,
                limit: limit,
                offset: offset,
                user: user,
                hasComment: hasComment,
                hasScore: hasScore,
                level: level,
                maxCreatedAt: maxCreatedAt,
                minCreatedAt: minCreatedAt);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessReadFeedbacksResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessReadFeedbacksResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize<global::System.Collections.Generic.IList<global::G.FeedbackSchema>?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}