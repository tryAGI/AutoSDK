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

        /// <summary>
        /// Pipeline Cooldown
        /// </summary>
        /// <param name="pipelineIdOrPointer"></param>
        /// <param name="pipelineId"></param>
        /// <param name="pointer"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task PipelineCooldownAsync(
            string pipelineIdOrPointer,
            global::G.PipelineCooldown request,
            string? pipelineId = default,
            string? pointer = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PreparePipelineCooldownArguments(
                httpClient: HttpClient,
                pipelineIdOrPointer: ref pipelineIdOrPointer,
                pipelineId: ref pipelineId,
                pointer: ref pointer,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: $"/v4/pipelines/{pipelineIdOrPointer}/cooldown",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("pipeline_id", pipelineId) 
                .AddOptionalParameter("pointer", pointer) 
                ; 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in Authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2")
                {
                    __httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: __authorization.Name,
                        parameter: __authorization.Value);
                }
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Header")
                {
                    __httpRequest.Headers.Add(__authorization.Name, __authorization.Value);
                }
            }
            var __httpRequestContentBody = request.ToJson(JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PreparePipelineCooldownRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                pipelineIdOrPointer: pipelineIdOrPointer,
                pipelineId: pipelineId,
                pointer: pointer,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessPipelineCooldownResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            try
            {
                __response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException __ex)
            {
                throw new global::G.ApiException(
                    message: __response.ReasonPhrase ?? string.Empty,
                    innerException: __ex,
                    statusCode: __response.StatusCode)
                {
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
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
        public async global::System.Threading.Tasks.Task PipelineCooldownAsync(
            string pipelineIdOrPointer,
            string? pipelineId = default,
            string? pointer = default,
            int? duration = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.PipelineCooldown
            {
                Duration = duration,
            };

            await PipelineCooldownAsync(
                pipelineIdOrPointer: pipelineIdOrPointer,
                pipelineId: pipelineId,
                pointer: pointer,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}