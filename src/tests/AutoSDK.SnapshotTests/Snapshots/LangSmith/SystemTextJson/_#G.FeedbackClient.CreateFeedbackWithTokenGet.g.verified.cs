//HintName: G.FeedbackClient.CreateFeedbackWithTokenGet.g.cs

#nullable enable

namespace G
{
    public partial class FeedbackClient
    {
        partial void PrepareCreateFeedbackWithTokenGetArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::System.Guid token,
            ref global::G.AnyOf<double?, int?, bool?, object>? score,
            ref global::G.AnyOf<double?, int?, bool?, string, object>? value,
            ref global::G.AnyOf<string, object>? comment,
            ref global::G.AnyOf<string, object>? correction);
        partial void PrepareCreateFeedbackWithTokenGetRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::System.Guid token,
            global::G.AnyOf<double?, int?, bool?, object>? score,
            global::G.AnyOf<double?, int?, bool?, string, object>? value,
            global::G.AnyOf<string, object>? comment,
            global::G.AnyOf<string, object>? correction);
        partial void ProcessCreateFeedbackWithTokenGetResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateFeedbackWithTokenGetResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create Feedback With Token Get<br/>
        /// Create a new feedback with a token.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="score"></param>
        /// <param name="value"></param>
        /// <param name="comment"></param>
        /// <param name="correction"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.CreateFeedbackWithTokenGetApiV1FeedbackTokensTokenGetResponse> CreateFeedbackWithTokenGetAsync(
            global::System.Guid token,
            global::G.AnyOf<double?, int?, bool?, object>? score = default,
            global::G.AnyOf<double?, int?, bool?, string, object>? value = default,
            global::G.AnyOf<string, object>? comment = default,
            global::G.AnyOf<string, object>? correction = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareCreateFeedbackWithTokenGetArguments(
                httpClient: _httpClient,
                token: ref token,
                score: ref score,
                value: ref value,
                comment: ref comment,
                correction: ref correction);

            var __pathBuilder = new PathBuilder(
                path: $"/api/v1/feedback/tokens/{token}",
                baseUri: _httpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("score", score?.ToString() ?? string.Empty) 
                .AddOptionalParameter("value", value?.ToString() ?? string.Empty) 
                .AddOptionalParameter("comment", comment?.ToString() ?? string.Empty) 
                .AddOptionalParameter("correction", correction?.ToString() ?? string.Empty) 
                ; 
            var __path = __pathBuilder.ToString();
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareCreateFeedbackWithTokenGetRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                token: token,
                score: score,
                value: value,
                comment: comment,
                correction: correction);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessCreateFeedbackWithTokenGetResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessCreateFeedbackWithTokenGetResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize<global::G.CreateFeedbackWithTokenGetApiV1FeedbackTokensTokenGetResponse?>(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}