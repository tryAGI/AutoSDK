//HintName: G.FeedbackClient.CreateFeedbackWithTokenGet.g.cs

#nullable enable

namespace G
{
    public partial class FeedbackClient
    {
        partial void PrepareCreateFeedbackWithTokenGetArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string token,
            ref global::System.AnyOf<double?, int?, bool?, object>? score,
            ref global::System.AnyOf<double?, int?, bool?, string?, object>? value,
            ref global::System.AnyOf<string?, object>? comment,
            ref global::System.AnyOf<string?, object>? correction);
        partial void PrepareCreateFeedbackWithTokenGetRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string token,
            global::System.AnyOf<double?, int?, bool?, object>? score,
            global::System.AnyOf<double?, int?, bool?, string?, object>? value,
            global::System.AnyOf<string?, object>? comment,
            global::System.AnyOf<string?, object>? correction);
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
            string token,
            global::System.AnyOf<double?, int?, bool?, object>? score,
            global::System.AnyOf<double?, int?, bool?, string?, object>? value,
            global::System.AnyOf<string?, object>? comment,
            global::System.AnyOf<string?, object>? correction,
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

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/api/v1/feedback/tokens/{token}?score={score}&value={value}&comment={comment}&correction={correction}", global::System.UriKind.RelativeOrAbsolute));

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

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

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
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.CreateFeedbackWithTokenGetApiV1FeedbackTokensTokenGetResponse?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}