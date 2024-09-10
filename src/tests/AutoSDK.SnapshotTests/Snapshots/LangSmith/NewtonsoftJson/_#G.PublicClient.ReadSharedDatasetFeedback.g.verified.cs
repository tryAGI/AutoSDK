//HintName: G.PublicClient.ReadSharedDatasetFeedback.g.cs

#nullable enable

namespace G
{
    public partial class PublicClient
    {
        partial void PrepareReadSharedDatasetFeedbackArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::System.Guid shareToken,
            ref global::System.AnyOf<global::System.Collections.Generic.IList<global::System.Guid>, object>? run,
            ref global::System.AnyOf<global::System.Collections.Generic.IList<string>, object>? key,
            ref global::System.AnyOf<global::System.Collections.Generic.IList<global::System.Guid>, object>? session,
            ref global::System.AnyOf<global::System.Collections.Generic.IList<global::G.SourceType>, object>? source,
            ref int limit,
            ref int offset,
            ref global::System.AnyOf<global::System.Collections.Generic.IList<global::System.Guid>, object>? user,
            ref global::System.AnyOf<bool?, object>? hasComment,
            ref global::System.AnyOf<bool?, object>? hasScore,
            ref global::System.AnyOf<global::G.FeedbackLevel?, object>? level);
        partial void PrepareReadSharedDatasetFeedbackRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::System.Guid shareToken,
            global::System.AnyOf<global::System.Collections.Generic.IList<global::System.Guid>, object>? run,
            global::System.AnyOf<global::System.Collections.Generic.IList<string>, object>? key,
            global::System.AnyOf<global::System.Collections.Generic.IList<global::System.Guid>, object>? session,
            global::System.AnyOf<global::System.Collections.Generic.IList<global::G.SourceType>, object>? source,
            int limit,
            int offset,
            global::System.AnyOf<global::System.Collections.Generic.IList<global::System.Guid>, object>? user,
            global::System.AnyOf<bool?, object>? hasComment,
            global::System.AnyOf<bool?, object>? hasScore,
            global::System.AnyOf<global::G.FeedbackLevel?, object>? level);
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
        /// <param name="level"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.FeedbackSchema>> ReadSharedDatasetFeedbackAsync(
            global::System.Guid shareToken,
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
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareReadSharedDatasetFeedbackArguments(
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

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/api/v1/public/{shareToken}/datasets/feedback?run={run}&key={key}&session={session}&source={source}&limit={limit}&offset={offset}&user={user}&has_comment={hasComment}&has_score={hasScore}&level={level}", global::System.UriKind.RelativeOrAbsolute));

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
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::System.Collections.Generic.IList<global::G.FeedbackSchema>?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}