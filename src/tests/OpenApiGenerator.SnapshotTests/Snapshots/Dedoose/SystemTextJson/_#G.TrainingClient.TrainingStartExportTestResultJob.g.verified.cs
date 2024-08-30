//HintName: G.TrainingClient.TrainingStartExportTestResultJob.g.cs

#nullable enable

namespace G
{
    public partial class TrainingClient
    {
        partial void PrepareTrainingStartExportTestResultJobArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? token,
            ref string? projectId,
            ref string? testResultId,
            ref string? fileExtension,
            ref string? cryptoKey);
        partial void PrepareTrainingStartExportTestResultJobRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? token,
            string? projectId,
            string? testResultId,
            string? fileExtension,
            string? cryptoKey);
        partial void ProcessTrainingStartExportTestResultJobResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessTrainingStartExportTestResultJobResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// StartExportTestResultJob.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="projectId"></param>
        /// <param name="testResultId"></param>
        /// <param name="fileExtension"></param>
        /// <param name="cryptoKey"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<string> TrainingStartExportTestResultJobAsync(
            string? token = default,
            string? projectId = default,
            string? testResultId = default,
            string? fileExtension = default,
            string? cryptoKey = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareTrainingStartExportTestResultJobArguments(
                httpClient: _httpClient,
                token: ref token,
                projectId: ref projectId,
                testResultId: ref testResultId,
                fileExtension: ref fileExtension,
                cryptoKey: ref cryptoKey);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/api/v1/training/startexporttestresultjob?projectId={projectId}&testResultId={testResultId}&fileExtension={fileExtension}&cryptoKey={cryptoKey}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareTrainingStartExportTestResultJobRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                token: token,
                projectId: projectId,
                testResultId: testResultId,
                fileExtension: fileExtension,
                cryptoKey: cryptoKey);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessTrainingStartExportTestResultJobResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessTrainingStartExportTestResultJobResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize<string?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}