//HintName: G.FineTuningClient.ListPaginatedFineTuningJobs.g.cs

#nullable enable

namespace G
{
    public partial class FineTuningClient
    {
        partial void PrepareListPaginatedFineTuningJobsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? after,
            ref int limit);
        partial void PrepareListPaginatedFineTuningJobsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? after,
            int limit);
        partial void ProcessListPaginatedFineTuningJobsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessListPaginatedFineTuningJobsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List your organization's fine-tuning jobs
        /// </summary>
        /// <param name="after"></param>
        /// <param name="limit">
        /// Default Value: 20
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.ListPaginatedFineTuningJobsResponse> ListPaginatedFineTuningJobsAsync(
            string? after,
            int limit,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareListPaginatedFineTuningJobsArguments(
                httpClient: _httpClient,
                after: ref after,
                limit: ref limit);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/fine_tuning/jobs?after={after}&limit={limit}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareListPaginatedFineTuningJobsRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                after: after,
                limit: limit);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessListPaginatedFineTuningJobsResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessListPaginatedFineTuningJobsResponseContent(
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
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.ListPaginatedFineTuningJobsResponse?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}