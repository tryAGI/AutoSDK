//HintName: G.ExcerptClient.ExcerptUpdateExcerptText.g.cs

#nullable enable

namespace G
{
    public partial class ExcerptClient
    {
        partial void PrepareExcerptUpdateExcerptTextArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? token,
            ref string? projectIDL,
            ref string? excerptId,
            ref string? text);
        partial void PrepareExcerptUpdateExcerptTextRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? token,
            string? projectIDL,
            string? excerptId,
            string? text);
        partial void ProcessExcerptUpdateExcerptTextResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessExcerptUpdateExcerptTextResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// UpdateExcerptText.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="projectIDL"></param>
        /// <param name="excerptId"></param>
        /// <param name="text"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.Excerpt> ExcerptUpdateExcerptTextAsync(
            string? token,
            string? projectIDL,
            string? excerptId,
            string? text,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareExcerptUpdateExcerptTextArguments(
                httpClient: _httpClient,
                token: ref token,
                projectIDL: ref projectIDL,
                excerptId: ref excerptId,
                text: ref text);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/api/v1/excerpt/updateexcerpttext?projectIDL={projectIDL}&excerptId={excerptId}&text={text}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareExcerptUpdateExcerptTextRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                token: token,
                projectIDL: projectIDL,
                excerptId: excerptId,
                text: text);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessExcerptUpdateExcerptTextResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessExcerptUpdateExcerptTextResponseContent(
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
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.Excerpt?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}