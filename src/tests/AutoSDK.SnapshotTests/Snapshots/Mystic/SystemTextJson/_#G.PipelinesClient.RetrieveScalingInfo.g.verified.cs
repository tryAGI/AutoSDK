//HintName: G.PipelinesClient.RetrieveScalingInfo.g.cs

#nullable enable

namespace G
{
    public partial class PipelinesClient
    {
        partial void PrepareRetrieveScalingInfoArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string pipelineId,
            ref string? pointer,
            ref string? pipelineIdOrPointer);
        partial void PrepareRetrieveScalingInfoRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string pipelineId,
            string? pointer,
            string? pipelineIdOrPointer);
        partial void ProcessRetrieveScalingInfoResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessRetrieveScalingInfoResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Retrieve Scaling Info<br/>
        /// Get real-time scaling information for the given pipeline.
        /// </summary>
        /// <param name="pipelineId"></param>
        /// <param name="pointer"></param>
        /// <param name="pipelineIdOrPointer"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.PipelineScalingInfo> RetrieveScalingInfoAsync(
            string pipelineId,
            string? pointer = default,
            string? pipelineIdOrPointer = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareRetrieveScalingInfoArguments(
                httpClient: _httpClient,
                pipelineId: ref pipelineId,
                pointer: ref pointer,
                pipelineIdOrPointer: ref pipelineIdOrPointer);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/v4/pipelines/{pipelineId}/scaling?pointer={pointer}&pipeline_id_or_pointer={pipelineIdOrPointer}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareRetrieveScalingInfoRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                pipelineId: pipelineId,
                pointer: pointer,
                pipelineIdOrPointer: pipelineIdOrPointer);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessRetrieveScalingInfoResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessRetrieveScalingInfoResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize<global::G.PipelineScalingInfo?>(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}