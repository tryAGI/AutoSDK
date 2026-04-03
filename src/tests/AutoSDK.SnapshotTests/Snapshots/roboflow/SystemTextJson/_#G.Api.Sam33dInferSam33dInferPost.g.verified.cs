//HintName: G.Api.Sam33dInferSam33dInferPost.g.cs

#nullable enable

namespace G
{
    public partial class Api
    {
        partial void PrepareSam33dInferSam33dInferPostArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? apiKey,
            bool? countinference,
            ref string? serviceSecret,
            global::G.Sam33dObjectsInferenceRequest request);
        partial void PrepareSam33dInferSam33dInferPostRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? apiKey,
            bool? countinference,
            string? serviceSecret,
            global::G.Sam33dObjectsInferenceRequest request);
        partial void ProcessSam33dInferSam33dInferPostResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessSam33dInferSam33dInferPostResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// SAM3 3D Object Generation<br/>
        /// Generate 3D meshes and Gaussian splatting from 2D images with mask prompts.
        /// </summary>
        /// <param name="apiKey">
        /// Roboflow API Key that will be passed to the model during initialization for artifact retrieval
        /// </param>
        /// <param name="countinference"></param>
        /// <param name="serviceSecret"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<string> Sam33dInferSam33dInferPostAsync(

            global::G.Sam33dObjectsInferenceRequest request,
            string? apiKey = default,
            bool? countinference = default,
            string? serviceSecret = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareSam33dInferSam33dInferPostArguments(
                httpClient: HttpClient,
                apiKey: ref apiKey,
                countinference: countinference,
                serviceSecret: ref serviceSecret,
                request: request);

            var __pathBuilder = new global::G.PathBuilder(
                path: "/sam3_3d/infer",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddOptionalParameter("api_key", apiKey)
                .AddOptionalParameter("countinference", countinference?.ToString().ToLowerInvariant())
                .AddOptionalParameter("service_secret", serviceSecret) 
                ; 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif
            var __httpRequestContentBody = request.ToJson(JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareSam33dInferSam33dInferPostRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                apiKey: apiKey,
                countinference: countinference,
                serviceSecret: serviceSecret,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessSam33dInferSam33dInferPostResponse(
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
                ProcessSam33dInferSam33dInferPostResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return __content;
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
                    var __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                        cancellationToken
#endif
                    ).ConfigureAwait(false);

                    return __content;
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
        /// SAM3 3D Object Generation<br/>
        /// Generate 3D meshes and Gaussian splatting from 2D images with mask prompts.
        /// </summary>
        /// <param name="apiKey">
        /// Roboflow API Key that will be passed to the model during initialization for artifact retrieval
        /// </param>
        /// <param name="countinference"></param>
        /// <param name="serviceSecret"></param>
        /// <param name="id"></param>
        /// <param name="requestApiKey">
        /// Roboflow API Key that will be passed to the model during initialization for artifact retrieval
        /// </param>
        /// <param name="usageBillable">
        /// Default Value: true
        /// </param>
        /// <param name="start"></param>
        /// <param name="source"></param>
        /// <param name="sourceInfo"></param>
        /// <param name="disableModelMonitoring">
        /// If true, disables model monitoring for this request<br/>
        /// Default Value: false
        /// </param>
        /// <param name="image">
        /// The input image to be used for 3D generation.
        /// </param>
        /// <param name="maskInput">
        /// Mask input in any supported format: polygon [x1,y1,x2,y2,...], binary mask (base64), RLE dict, or list of these.
        /// </param>
        /// <param name="modelId">
        /// The model ID for SAM3_3D.<br/>
        /// Default Value: sam3-3d-objects
        /// </param>
        /// <param name="outputMeshes">
        /// SAM3 3D always outputs object gaussians, and can optionally output object meshes if output_meshes is True.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="outputScene">
        /// Output the combined scene reconstruction in addition to individual object reconstructions.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="withMeshPostprocess">
        /// Enable mesh postprocessing.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="withTextureBaking">
        /// Enable texture baking for meshes.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="useDistillations">
        /// Use the distilled versions of the model components.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<string> Sam33dInferSam33dInferPostAsync(
            string id,
            global::G.InferenceRequestImage image,
            object maskInput,
            string? apiKey = default,
            bool? countinference = default,
            string? serviceSecret = default,
            string? requestApiKey = default,
            bool? usageBillable = default,
            double? start = default,
            string? source = default,
            string? sourceInfo = default,
            bool? disableModelMonitoring = default,
            string? modelId = default,
            bool? outputMeshes = default,
            bool? outputScene = default,
            bool? withMeshPostprocess = default,
            bool? withTextureBaking = default,
            bool? useDistillations = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.Sam33dObjectsInferenceRequest
            {
                Id = id,
                ApiKey = requestApiKey,
                UsageBillable = usageBillable,
                Start = start,
                Source = source,
                SourceInfo = sourceInfo,
                DisableModelMonitoring = disableModelMonitoring,
                Image = image,
                MaskInput = maskInput,
                ModelId = modelId,
                OutputMeshes = outputMeshes,
                OutputScene = outputScene,
                WithMeshPostprocess = withMeshPostprocess,
                WithTextureBaking = withTextureBaking,
                UseDistillations = useDistillations,
            };

            return await Sam33dInferSam33dInferPostAsync(
                apiKey: apiKey,
                countinference: countinference,
                serviceSecret: serviceSecret,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}