//HintName: G.RunsClient.StreamRun.g.cs

#nullable enable

namespace G
{
    public partial class RunsClient
    {
        partial void PrepareStreamRunArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::G.RunCreate request);
        partial void PrepareStreamRunRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::G.RunCreate request);
        partial void ProcessStreamRunResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessStreamRunResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Stream Run<br/>
        /// Submit a new streaming run request, where the run output is streamed as<br/>
        /// it becomes available, rather than waiting for all the data to be<br/>
        /// generated.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.StreamRunV4RunsStreamPostResponse> StreamRunAsync(
            global::G.RunCreate request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareStreamRunArguments(
                httpClient: _httpClient,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: "/v4/runs/stream",
                baseUri: _httpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = global::Newtonsoft.Json.JsonConvert.SerializeObject(request, JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareStreamRunRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessStreamRunResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessStreamRunResponseContent(
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
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.StreamRunV4RunsStreamPostResponse?>(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Stream Run<br/>
        /// Submit a new streaming run request, where the run output is streamed as<br/>
        /// it becomes available, rather than waiting for all the data to be<br/>
        /// generated.
        /// </summary>
        /// <param name="pipeline"></param>
        /// <param name="inputs"></param>
        /// <param name="asyncRun">
        /// Default Value: false
        /// </param>
        /// <param name="waitForResources"></param>
        /// <param name="runId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.StreamRunV4RunsStreamPostResponse> StreamRunAsync(
            string pipeline,
            global::System.Collections.Generic.IList<global::G.RunInput> inputs,
            bool? asyncRun = false,
            bool? waitForResources = default,
            string? runId = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.RunCreate
            {
                Pipeline = pipeline,
                Inputs = inputs,
                AsyncRun = asyncRun,
                WaitForResources = waitForResources,
                RunId = runId,
            };

            return await StreamRunAsync(
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}