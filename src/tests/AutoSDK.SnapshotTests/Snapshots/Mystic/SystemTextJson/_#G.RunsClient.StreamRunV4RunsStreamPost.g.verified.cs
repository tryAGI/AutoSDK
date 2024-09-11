//HintName: G.RunsClient.StreamRunV4RunsStreamPost.g.cs

#nullable enable

namespace G
{
    public partial class RunsClient
    {
        partial void PrepareStreamRunV4RunsStreamPostArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::G.RunCreate request);
        partial void PrepareStreamRunV4RunsStreamPostRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::G.RunCreate request);
        partial void ProcessStreamRunV4RunsStreamPostResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessStreamRunV4RunsStreamPostResponseContent(
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
        public async global::System.Threading.Tasks.Task<global::G.StreamRunV4RunsStreamPostResponse> StreamRunV4RunsStreamPostAsync(
            global::G.RunCreate request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareStreamRunV4RunsStreamPostArguments(
                httpClient: _httpClient,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + "/v4/runs/stream", global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = global::System.Text.Json.JsonSerializer.Serialize(request, _jsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareStreamRunV4RunsStreamPostRequest(
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
            ProcessStreamRunV4RunsStreamPostResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessStreamRunV4RunsStreamPostResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize<global::G.StreamRunV4RunsStreamPostResponse?>(__content, _jsonSerializerOptions) ??
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
        public async global::System.Threading.Tasks.Task<global::G.StreamRunV4RunsStreamPostResponse> StreamRunV4RunsStreamPostAsync(
            string pipeline,
            global::System.Collections.Generic.IList<global::G.RunInput> inputs,
            bool asyncRun = false,
            bool waitForResources = default,
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

            return await StreamRunV4RunsStreamPostAsync(
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}