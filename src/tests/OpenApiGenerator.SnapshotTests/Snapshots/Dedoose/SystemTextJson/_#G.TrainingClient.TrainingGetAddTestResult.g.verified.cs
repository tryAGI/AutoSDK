//HintName: G.TrainingClient.TrainingGetAddTestResult.g.cs

#nullable enable

namespace G
{
    public partial class TrainingClient
    {
        partial void PrepareTrainingGetAddTestResultArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? token,
            ref string? addTestWorkerId);
        partial void PrepareTrainingGetAddTestResultRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? token,
            string? addTestWorkerId);
        partial void ProcessTrainingGetAddTestResultResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessTrainingGetAddTestResultResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// GetAddTestResult.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="addTestWorkerId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.TrainingTest> TrainingGetAddTestResultAsync(
            string? token,
            string? addTestWorkerId,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareTrainingGetAddTestResultArguments(
                httpClient: _httpClient,
                token: ref token,
                addTestWorkerId: ref addTestWorkerId);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/api/v1/training/getaddtestresult?addTestWorkerId={addTestWorkerId}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareTrainingGetAddTestResultRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                token: token,
                addTestWorkerId: addTestWorkerId);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessTrainingGetAddTestResultResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessTrainingGetAddTestResultResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize<global::G.TrainingTest?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}