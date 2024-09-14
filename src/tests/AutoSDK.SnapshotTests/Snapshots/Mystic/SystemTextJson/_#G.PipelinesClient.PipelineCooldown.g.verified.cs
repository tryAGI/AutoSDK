//HintName: G.PipelinesClient.PipelineCooldown.g.cs

#nullable enable

namespace G
{
    public partial class PipelinesClient
    {
        partial void PreparePipelineCooldownArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string pipelineIdOrPointer,
            ref string? pipelineId,
            ref string? pointer,
            global::G.PipelineCooldown request);
        partial void PreparePipelineCooldownRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string pipelineIdOrPointer,
            string? pipelineId,
            string? pointer,
            global::G.PipelineCooldown request);
        partial void ProcessPipelineCooldownResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessPipelineCooldownResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Pipeline Cooldown
        /// </summary>
        /// <param name="pipelineIdOrPointer"></param>
        /// <param name="pipelineId"></param>
        /// <param name="pointer"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.HTTPValidationError> PipelineCooldownAsync(
            string pipelineIdOrPointer,
            global::G.PipelineCooldown request,
            string? pipelineId = default,
            string? pointer = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PreparePipelineCooldownArguments(
                httpClient: _httpClient,
                pipelineIdOrPointer: ref pipelineIdOrPointer,
                pipelineId: ref pipelineId,
                pointer: ref pointer,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/v4/pipelines/{pipelineIdOrPointer}/cooldown?pipeline_id={pipelineId}&pointer={pointer}", global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = global::System.Text.Json.JsonSerializer.Serialize(request, JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PreparePipelineCooldownRequest(
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
            ProcessPipelineCooldownResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessPipelineCooldownResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize<global::G.HTTPValidationError?>(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Pipeline Cooldown
        /// </summary>
        /// <param name="pipelineIdOrPointer"></param>
        /// <param name="pipelineId"></param>
        /// <param name="pointer"></param>
        /// <param name="duration">
        /// Default Value: 1800
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.HTTPValidationError> PipelineCooldownAsync(
            string pipelineIdOrPointer,
            string? pipelineId = default,
            string? pointer = default,
            int duration = 1800,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.PipelineCooldown
            {
                Duration = duration,
            };

            return await PipelineCooldownAsync(
                pipelineIdOrPointer: pipelineIdOrPointer,
                pipelineId: pipelineId,
                pointer: pointer,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}