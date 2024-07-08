//HintName: G.ExcerptClient.ExcerptUpdateExcerptRange.g.cs

#nullable enable

namespace G
{
    public partial class ExcerptClient
    {
        partial void PrepareExcerptUpdateExcerptRangeArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string token,
            ref string projectId,
            ref string userId,
            ref string excerptId,
            ref int newStart,
            ref int newEnd,
            ref string updatedTextURI);
        partial void PrepareExcerptUpdateExcerptRangeRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string token,
            string projectId,
            string userId,
            string excerptId,
            int newStart,
            int newEnd,
            string updatedTextURI);
        partial void ProcessExcerptUpdateExcerptRangeResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessExcerptUpdateExcerptRangeResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// UpdateExcerptRange.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="projectId"></param>
        /// <param name="userId"></param>
        /// <param name="excerptId"></param>
        /// <param name="newStart"></param>
        /// <param name="newEnd"></param>
        /// <param name="updatedTextURI"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.Excerpt> ExcerptUpdateExcerptRangeAsync(
            string token,
            string projectId,
            string userId,
            string excerptId,
            int newStart,
            int newEnd,
            string updatedTextURI,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareExcerptUpdateExcerptRangeArguments(
                httpClient: _httpClient,
                token: ref token,
                projectId: ref projectId,
                userId: ref userId,
                excerptId: ref excerptId,
                newStart: ref newStart,
                newEnd: ref newEnd,
                updatedTextURI: ref updatedTextURI);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/api/v1/excerpt/updateexcerptrange?projectId={projectId}&userId={userId}&excerptId={excerptId}&newStart={newStart}&newEnd={newEnd}&updatedTextURI={updatedTextURI}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareExcerptUpdateExcerptRangeRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                token: token,
                projectId: projectId,
                userId: userId,
                excerptId: excerptId,
                newStart: newStart,
                newEnd: newEnd,
                updatedTextURI: updatedTextURI);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessExcerptUpdateExcerptRangeResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessExcerptUpdateExcerptRangeResponseContent(
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