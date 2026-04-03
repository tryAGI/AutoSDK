//HintName: G.LlamaExtractClient.UpdateExtractionAgentApiV1ExtractionExtractionAgentsExtractionAgentIdPut.g.cs

#nullable enable

namespace G
{
    public partial class LlamaExtractClient
    {
        partial void PrepareUpdateExtractionAgentApiV1ExtractionExtractionAgentsExtractionAgentIdPutArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::System.Guid extractionAgentId,
            ref string? session,
            global::G.ExtractAgentUpdate request);
        partial void PrepareUpdateExtractionAgentApiV1ExtractionExtractionAgentsExtractionAgentIdPutRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::System.Guid extractionAgentId,
            string? session,
            global::G.ExtractAgentUpdate request);
        partial void ProcessUpdateExtractionAgentApiV1ExtractionExtractionAgentsExtractionAgentIdPutResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessUpdateExtractionAgentApiV1ExtractionExtractionAgentsExtractionAgentIdPutResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Update Extraction Agent
        /// </summary>
        /// <param name="extractionAgentId"></param>
        /// <param name="session"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.ExtractAgent> UpdateExtractionAgentApiV1ExtractionExtractionAgentsExtractionAgentIdPutAsync(
            global::System.Guid extractionAgentId,

            global::G.ExtractAgentUpdate request,
            string? session = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareUpdateExtractionAgentApiV1ExtractionExtractionAgentsExtractionAgentIdPutArguments(
                httpClient: HttpClient,
                extractionAgentId: ref extractionAgentId,
                session: ref session,
                request: request);

            var __pathBuilder = new global::G.PathBuilder(
                path: $"/api/v1/extraction/extraction-agents/{extractionAgentId}",
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
            PrepareUpdateExtractionAgentApiV1ExtractionExtractionAgentsExtractionAgentIdPutRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                extractionAgentId: extractionAgentId,
                session: session,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessUpdateExtractionAgentApiV1ExtractionExtractionAgentsExtractionAgentIdPutResponse(
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
                ProcessUpdateExtractionAgentApiV1ExtractionExtractionAgentsExtractionAgentIdPutResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.ExtractAgent.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::G.ExtractAgent.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
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
        /// Update Extraction Agent
        /// </summary>
        /// <param name="extractionAgentId"></param>
        /// <param name="session"></param>
        /// <param name="dataSchema">
        /// The schema of the data
        /// </param>
        /// <param name="config">
        /// The configuration parameters for the extraction agent.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.ExtractAgent> UpdateExtractionAgentApiV1ExtractionExtractionAgentsExtractionAgentIdPutAsync(
            global::System.Guid extractionAgentId,
            global::G.AnyOf<object, string> dataSchema,
            global::G.ExtractConfig config,
            string? session = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.ExtractAgentUpdate
            {
                DataSchema = dataSchema,
                Config = config,
            };

            return await UpdateExtractionAgentApiV1ExtractionExtractionAgentsExtractionAgentIdPutAsync(
                extractionAgentId: extractionAgentId,
                session: session,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}