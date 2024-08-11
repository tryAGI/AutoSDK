//HintName: G.FileClient.FileGetConvertPDF2SwfResult.g.cs

#nullable enable

namespace G
{
    public partial class FileClient
    {
        partial void PrepareFileGetConvertPDF2SwfResultArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? token,
            ref string? jobId);
        partial void PrepareFileGetConvertPDF2SwfResultRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? token,
            string? jobId);
        partial void ProcessFileGetConvertPDF2SwfResultResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessFileGetConvertPDF2SwfResultResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// GetConvertPDF2SwfResult.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="jobId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.FileGetConvertPDF2SwfResultResponse> FileGetConvertPDF2SwfResultAsync(
            string? token,
            string? jobId,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareFileGetConvertPDF2SwfResultArguments(
                httpClient: _httpClient,
                token: ref token,
                jobId: ref jobId);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/api/v1/file/getconvertpdf2swfresult?jobId={jobId}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareFileGetConvertPDF2SwfResultRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                token: token,
                jobId: jobId);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessFileGetConvertPDF2SwfResultResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessFileGetConvertPDF2SwfResultResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize<global::G.FileGetConvertPDF2SwfResultResponse?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}