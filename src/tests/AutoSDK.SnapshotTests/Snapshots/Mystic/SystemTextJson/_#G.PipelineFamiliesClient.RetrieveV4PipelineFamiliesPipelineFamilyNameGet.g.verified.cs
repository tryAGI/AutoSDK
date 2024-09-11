//HintName: G.PipelineFamiliesClient.RetrieveV4PipelineFamiliesPipelineFamilyNameGet.g.cs

#nullable enable

namespace G
{
    public partial class PipelineFamiliesClient
    {
        partial void PrepareRetrieveV4PipelineFamiliesPipelineFamilyNameGetArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string pipelineFamilyName);
        partial void PrepareRetrieveV4PipelineFamiliesPipelineFamilyNameGetRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string pipelineFamilyName);
        partial void ProcessRetrieveV4PipelineFamiliesPipelineFamilyNameGetResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessRetrieveV4PipelineFamiliesPipelineFamilyNameGetResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Retrieve<br/>
        /// Retrieve a pipeline family by name with its latest pipeline.<br/>
        /// If the user/selected team owns the family, the latest pipeline may be a<br/>
        /// private pipeline, otherwise it will only be public.
        /// </summary>
        /// <param name="pipelineFamilyName"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.PipelineFamilyGet> RetrieveV4PipelineFamiliesPipelineFamilyNameGetAsync(
            string pipelineFamilyName,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareRetrieveV4PipelineFamiliesPipelineFamilyNameGetArguments(
                httpClient: _httpClient,
                pipelineFamilyName: ref pipelineFamilyName);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/v4/pipeline-families/{pipelineFamilyName}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareRetrieveV4PipelineFamiliesPipelineFamilyNameGetRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                pipelineFamilyName: pipelineFamilyName);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessRetrieveV4PipelineFamiliesPipelineFamilyNameGetResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessRetrieveV4PipelineFamiliesPipelineFamilyNameGetResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize<global::G.PipelineFamilyGet?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}