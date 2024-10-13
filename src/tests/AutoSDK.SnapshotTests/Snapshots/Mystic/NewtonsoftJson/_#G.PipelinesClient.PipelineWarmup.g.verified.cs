//HintName: G.PipelinesClient.PipelineWarmup.g.cs

#nullable enable

namespace G
{
    public partial class PipelinesClient
    {
        partial void PreparePipelineWarmupArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string pipelineIdOrPointer,
            ref string? pipelineId,
            ref string? pointer,
            global::G.PipelineWarmup request);
        partial void PreparePipelineWarmupRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string pipelineIdOrPointer,
            string? pipelineId,
            string? pointer,
            global::G.PipelineWarmup request);
        partial void ProcessPipelineWarmupResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessPipelineWarmupResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Pipeline Warmup
        /// </summary>
        /// <param name="pipelineIdOrPointer"></param>
        /// <param name="pipelineId"></param>
        /// <param name="pointer"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.HTTPValidationError> PipelineWarmupAsync(
            string pipelineIdOrPointer,
            global::G.PipelineWarmup request,
            string? pipelineId = default,
            string? pointer = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PreparePipelineWarmupArguments(
                httpClient: _httpClient,
                pipelineIdOrPointer: ref pipelineIdOrPointer,
                pipelineId: ref pipelineId,
                pointer: ref pointer,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: $"/v4/pipelines/{pipelineIdOrPointer}/warmup",
                baseUri: _httpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("pipeline_id", pipelineId) 
                .AddOptionalParameter("pointer", pointer) 
                ; 
            var __path = __pathBuilder.ToString();
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            foreach (var _authorization in _authorizations)
            {
                if (_authorization.Type == "Http" ||
                    _authorization.Type == "OAuth2")
                {
                    httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: _authorization.Name,
                        parameter: _authorization.Value);
                }
                else if (_authorization.Type == "ApiKey" &&
                         _authorization.Location == "Header")
                {
                    httpRequest.Headers.Add(_authorization.Name, _authorization.Value);
                }
            }
            var __httpRequestContentBody = request.ToJson(JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PreparePipelineWarmupRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                pipelineIdOrPointer: pipelineIdOrPointer,
                pipelineId: pipelineId,
                pointer: pointer,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessPipelineWarmupResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessPipelineWarmupResponseContent(
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
                global::G.HTTPValidationError.FromJson(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Pipeline Warmup
        /// </summary>
        /// <param name="pipelineIdOrPointer"></param>
        /// <param name="pipelineId"></param>
        /// <param name="pointer"></param>
        /// <param name="minimumNodes"></param>
        /// <param name="duration">
        /// Default Value: 300
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.HTTPValidationError> PipelineWarmupAsync(
            string pipelineIdOrPointer,
            int minimumNodes,
            string? pipelineId = default,
            string? pointer = default,
            int? duration = 300,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.PipelineWarmup
            {
                MinimumNodes = minimumNodes,
                Duration = duration,
            };

            return await PipelineWarmupAsync(
                pipelineIdOrPointer: pipelineIdOrPointer,
                pipelineId: pipelineId,
                pointer: pointer,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}