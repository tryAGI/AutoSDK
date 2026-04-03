//HintName: G.PipelinesClient.UpdateExistingPipelineApiV1PipelinesPipelineIdPut.g.cs

#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace G
{
    public partial class PipelinesClient
    {
        partial void PrepareUpdateExistingPipelineApiV1PipelinesPipelineIdPutArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::System.Guid pipelineId,
            ref string? session,
            global::G.PipelineUpdate request);
        partial void PrepareUpdateExistingPipelineApiV1PipelinesPipelineIdPutRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::System.Guid pipelineId,
            string? session,
            global::G.PipelineUpdate request);
        partial void ProcessUpdateExistingPipelineApiV1PipelinesPipelineIdPutResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessUpdateExistingPipelineApiV1PipelinesPipelineIdPutResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Update Existing Pipeline<br/>
        /// Update an existing pipeline's configuration.
        /// </summary>
        /// <param name="pipelineId"></param>
        /// <param name="session"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.Pipeline> UpdateExistingPipelineApiV1PipelinesPipelineIdPutAsync(
            global::System.Guid pipelineId,

            global::G.PipelineUpdate request,
            string? session = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareUpdateExistingPipelineApiV1PipelinesPipelineIdPutArguments(
                httpClient: HttpClient,
                pipelineId: ref pipelineId,
                session: ref session,
                request: request);

            var __pathBuilder = new global::G.PathBuilder(
                path: $"/api/v1/pipelines/{pipelineId}",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Put,
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
            PrepareUpdateExistingPipelineApiV1PipelinesPipelineIdPutRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                pipelineId: pipelineId,
                session: session,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessUpdateExistingPipelineApiV1PipelinesPipelineIdPutResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // Validation Error
            if ((int)__response.StatusCode == 422)
            {
                string? __content_422 = null;
                global::System.Exception? __exception_422 = null;
                global::G.HTTPValidationError? __value_422 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_422 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_422 = global::G.HTTPValidationError.FromJson(__content_422, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_422 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_422 = global::G.HTTPValidationError.FromJson(__content_422, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_422 = __ex;
                }

                throw new global::G.ApiException<global::G.HTTPValidationError>(
                    message: __content_422 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_422,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_422,
                    ResponseObject = __value_422,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }

            if (ReadResponseAsString)
            {
                var __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                    cancellationToken
#endif
                ).ConfigureAwait(false);

                ProcessResponseContent(
                    client: HttpClient,
                    response: __response,
                    content: ref __content);
                ProcessUpdateExistingPipelineApiV1PipelinesPipelineIdPutResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.Pipeline.FromJson(__content, JsonSerializerOptions) ??
                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                }
                catch (global::System.Exception __ex)
                {
                    throw new global::G.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }
            }
            else
            {
                try
                {
                    __response.EnsureSuccessStatusCode();
                    using var __content = await __response.Content.ReadAsStreamAsync(
#if NET5_0_OR_GREATER
                        cancellationToken
#endif
                    ).ConfigureAwait(false);

                    return
                        await global::G.Pipeline.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                }
                catch (global::System.Exception __ex)
                {
                    string? __content = null;
                    try
                    {
                        __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                            cancellationToken
#endif
                        ).ConfigureAwait(false);
                    }
                    catch (global::System.Exception)
                    {
                    }

                    throw new global::G.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }
            }
        }
        /// <summary>
        /// Update Existing Pipeline<br/>
        /// Update an existing pipeline's configuration.
        /// </summary>
        /// <param name="pipelineId"></param>
        /// <param name="session"></param>
        /// <param name="embeddingConfig"></param>
        /// <param name="transformConfig">
        /// Configuration for the transformation.
        /// </param>
        /// <param name="sparseModelConfig">
        /// Configuration for the sparse model used in hybrid search.
        /// </param>
        /// <param name="dataSinkId">
        /// Data sink ID. When provided instead of data_sink, the data sink will be looked up by ID.
        /// </param>
        /// <param name="embeddingModelConfigId">
        /// Embedding model config ID. When provided instead of embedding_config, the embedding model config will be looked up by ID.
        /// </param>
        /// <param name="dataSink">
        /// Data sink. When provided instead of data_sink_id, the data sink will be created.
        /// </param>
        /// <param name="presetRetrievalParameters">
        /// Preset retrieval parameters for the pipeline.
        /// </param>
        /// <param name="status">
        /// Status of the pipeline deployment.
        /// </param>
        /// <param name="metadataConfig">
        /// Metadata configuration for the pipeline.
        /// </param>
        /// <param name="name"></param>
        /// <param name="managedPipelineId">
        /// The ID of the ManagedPipeline this playground pipeline is linked to.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.Pipeline> UpdateExistingPipelineApiV1PipelinesPipelineIdPutAsync(
            global::System.Guid pipelineId,
            string? session = default,
            global::G.EmbeddingConfigVariant13? embeddingConfig = default,
            global::G.AnyOf<global::G.AutoTransformConfig, global::G.AdvancedModeTransformConfig, object>? transformConfig = default,
            global::G.SparseModelConfig? sparseModelConfig = default,
            global::System.Guid? dataSinkId = default,
            global::System.Guid? embeddingModelConfigId = default,
            global::G.DataSinkCreate? dataSink = default,
            global::G.PresetRetrievalParams? presetRetrievalParameters = default,
            string? status = default,
            global::G.PipelineMetadataConfig2? metadataConfig = default,
            string? name = default,
            global::System.Guid? managedPipelineId = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.PipelineUpdate
            {
                EmbeddingConfig = embeddingConfig,
                TransformConfig = transformConfig,
                SparseModelConfig = sparseModelConfig,
                DataSinkId = dataSinkId,
                EmbeddingModelConfigId = embeddingModelConfigId,
                DataSink = dataSink,
                PresetRetrievalParameters = presetRetrievalParameters,
                Status = status,
                MetadataConfig = metadataConfig,
                Name = name,
                ManagedPipelineId = managedPipelineId,
            };

            return await UpdateExistingPipelineApiV1PipelinesPipelineIdPutAsync(
                pipelineId: pipelineId,
                session: session,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}