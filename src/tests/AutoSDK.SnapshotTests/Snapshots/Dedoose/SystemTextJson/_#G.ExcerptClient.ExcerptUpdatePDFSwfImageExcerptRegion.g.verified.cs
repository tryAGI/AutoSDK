//HintName: G.ExcerptClient.ExcerptUpdatePDFSwfImageExcerptRegion.g.cs

#nullable enable

namespace G
{
    public partial class ExcerptClient
    {
        partial void PrepareExcerptUpdatePDFSwfImageExcerptRegionArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? token,
            ref global::System.Guid projectId,
            ref global::System.Guid currentUserId,
            ref global::System.Guid excerptId,
            ref int newStart,
            ref int newEnd);
        partial void PrepareExcerptUpdatePDFSwfImageExcerptRegionRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? token,
            global::System.Guid projectId,
            global::System.Guid currentUserId,
            global::System.Guid excerptId,
            int newStart,
            int newEnd);
        partial void ProcessExcerptUpdatePDFSwfImageExcerptRegionResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessExcerptUpdatePDFSwfImageExcerptRegionResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// UpdatePDFSwfImageExcerptRegion.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="projectId"></param>
        /// <param name="currentUserId"></param>
        /// <param name="excerptId"></param>
        /// <param name="newStart"></param>
        /// <param name="newEnd"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.Excerpt> ExcerptUpdatePDFSwfImageExcerptRegionAsync(
            string? token = default,
            global::System.Guid projectId = default,
            global::System.Guid currentUserId = default,
            global::System.Guid excerptId = default,
            int newStart = default,
            int newEnd = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareExcerptUpdatePDFSwfImageExcerptRegionArguments(
                httpClient: _httpClient,
                token: ref token,
                projectId: ref projectId,
                currentUserId: ref currentUserId,
                excerptId: ref excerptId,
                newStart: ref newStart,
                newEnd: ref newEnd);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/api/v1/excerpt/updatepdfswfimageexcerptregion?projectId={projectId}&currentUserId={currentUserId}&excerptId={excerptId}&newStart={newStart}&newEnd={newEnd}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareExcerptUpdatePDFSwfImageExcerptRegionRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                token: token,
                projectId: projectId,
                currentUserId: currentUserId,
                excerptId: excerptId,
                newStart: newStart,
                newEnd: newEnd);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessExcerptUpdatePDFSwfImageExcerptRegionResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessExcerptUpdatePDFSwfImageExcerptRegionResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize<global::G.Excerpt?>(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}