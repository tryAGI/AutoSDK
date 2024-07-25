//HintName: G.PublicClient.ReadSharedDelta.g.cs

#nullable enable

namespace G
{
    public partial class PublicClient
    {
        partial void PrepareReadSharedDeltaArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string shareToken,
            global::G.QueryFeedbackDelta request);
        partial void PrepareReadSharedDeltaRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string shareToken,
            global::G.QueryFeedbackDelta request);
        partial void ProcessReadSharedDeltaResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessReadSharedDeltaResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Read Shared Delta<br/>
        /// Fetch the number of regressions/improvements for each example in a dataset, between sessions[0] and sessions[1].
        /// </summary>
        /// <param name="shareToken"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.SessionFeedbackDelta> ReadSharedDeltaAsync(
            string shareToken,
            global::G.QueryFeedbackDelta request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareReadSharedDeltaArguments(
                httpClient: _httpClient,
                shareToken: ref shareToken,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/api/v1/public/{shareToken}/datasets/runs/delta", global::System.UriKind.RelativeOrAbsolute));
            var __json = global::System.Text.Json.JsonSerializer.Serialize(request, _jsonSerializerOptions);
            httpRequest.Content = new global::System.Net.Http.StringContent(
                content: __json,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareReadSharedDeltaRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                shareToken: shareToken,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessReadSharedDeltaResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessReadSharedDeltaResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize<global::G.SessionFeedbackDelta?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Read Shared Delta<br/>
        /// Fetch the number of regressions/improvements for each example in a dataset, between sessions[0] and sessions[1].
        /// </summary>
        /// <param name="shareToken"></param>
        /// <param name="baselineSessionId"></param>
        /// <param name="comparisonSessionIds"></param>
        /// <param name="feedbackKey"></param>
        /// <param name="filters"></param>
        /// <param name="offset">
        /// Default Value: 0
        /// </param>
        /// <param name="limit">
        /// Default Value: 100
        /// </param>
        /// <param name="comparativeExperimentId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.SessionFeedbackDelta> ReadSharedDeltaAsync(
            string shareToken,
            string baselineSessionId,
            global::System.Collections.Generic.IList<string> comparisonSessionIds,
            string feedbackKey,
            global::System.AnyOf<object?, object?>? filters = default,
            int offset = 0,
            int limit = 100,
            global::System.AnyOf<string?, object?>? comparativeExperimentId = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.QueryFeedbackDelta
            {
                BaselineSessionId = baselineSessionId,
                ComparisonSessionIds = comparisonSessionIds,
                FeedbackKey = feedbackKey,
                Filters = filters,
                Offset = offset,
                Limit = limit,
                ComparativeExperimentId = comparativeExperimentId,
            };

            return await ReadSharedDeltaAsync(
                shareToken: shareToken,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}