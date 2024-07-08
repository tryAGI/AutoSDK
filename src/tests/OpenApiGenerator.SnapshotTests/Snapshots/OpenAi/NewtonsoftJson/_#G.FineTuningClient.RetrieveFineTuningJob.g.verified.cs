//HintName: G.FineTuningClient.RetrieveFineTuningJob.g.cs

#nullable enable

namespace G
{
    public partial class FineTuningClient
    {
        partial void PrepareRetrieveFineTuningJobArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string fineTuningJobId);
        partial void PrepareRetrieveFineTuningJobRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string fineTuningJobId);
        partial void ProcessRetrieveFineTuningJobResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessRetrieveFineTuningJobResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Get info about a fine-tuning job.<br/>
        /// [Learn more about fine-tuning](/docs/guides/fine-tuning)
        /// </summary>
        /// <param name="fineTuningJobId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.FineTuningJob> RetrieveFineTuningJobAsync(
            string fineTuningJobId,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareRetrieveFineTuningJobArguments(
                httpClient: _httpClient,
                fineTuningJobId: ref fineTuningJobId);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/fine_tuning/jobs/{fineTuningJobId}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareRetrieveFineTuningJobRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                fineTuningJobId: fineTuningJobId);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessRetrieveFineTuningJobResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessRetrieveFineTuningJobResponseContent(
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
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.FineTuningJob?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}