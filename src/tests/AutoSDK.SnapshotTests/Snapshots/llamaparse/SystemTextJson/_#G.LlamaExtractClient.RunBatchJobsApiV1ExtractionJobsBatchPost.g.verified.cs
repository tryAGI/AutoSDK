//HintName: G.LlamaExtractClient.RunBatchJobsApiV1ExtractionJobsBatchPost.g.cs

#nullable enable

namespace G
{
    public partial class LlamaExtractClient
    {
        partial void PrepareRunBatchJobsApiV1ExtractionJobsBatchPostArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref bool? fromUi,
            ref string? session,
            global::G.ExtractJobCreateBatch request);
        partial void PrepareRunBatchJobsApiV1ExtractionJobsBatchPostRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            bool? fromUi,
            string? session,
            global::G.ExtractJobCreateBatch request);
        partial void ProcessRunBatchJobsApiV1ExtractionJobsBatchPostResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessRunBatchJobsApiV1ExtractionJobsBatchPostResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Run Batch Jobs
        /// </summary>
        /// <param name="fromUi">
        /// Default Value: false
        /// </param>
        /// <param name="session"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.ExtractJob>> RunBatchJobsApiV1ExtractionJobsBatchPostAsync(

            global::G.ExtractJobCreateBatch request,
            bool? fromUi = default,
            string? session = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareRunBatchJobsApiV1ExtractionJobsBatchPostArguments(
                httpClient: HttpClient,
                fromUi: ref fromUi,
                session: ref session,
                request: request);

            var __pathBuilder = new global::G.PathBuilder(
                path: "/api/v1/extraction/jobs/batch",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddOptionalParameter("from_ui", fromUi?.ToString().ToLowerInvariant()) 
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
            PrepareRunBatchJobsApiV1ExtractionJobsBatchPostRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                fromUi: fromUi,
                session: session,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessRunBatchJobsApiV1ExtractionJobsBatchPostResponse(
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
                ProcessRunBatchJobsApiV1ExtractionJobsBatchPostResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::System.Text.Json.JsonSerializer.Deserialize<global::System.Collections.Generic.IList<global::G.ExtractJob>?>(__content, JsonSerializerOptions) ??
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
                        await global::System.Text.Json.JsonSerializer.DeserializeAsync<global::System.Collections.Generic.IList<global::G.ExtractJob>?>(__content, JsonSerializerOptions).ConfigureAwait(false) ??
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
        /// Run Batch Jobs
        /// </summary>
        /// <param name="fromUi">
        /// Default Value: false
        /// </param>
        /// <param name="session"></param>
        /// <param name="webhookConfigurations">
        /// Outbound webhook endpoints to notify on job status changes
        /// </param>
        /// <param name="extractionAgentId">
        /// The id of the extraction agent
        /// </param>
        /// <param name="fileIds">
        /// The ids of the files
        /// </param>
        /// <param name="dataSchemaOverride">
        /// The data schema to override the extraction agent's data schema with
        /// </param>
        /// <param name="configOverride">
        /// The config to override the extraction agent's config with
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.ExtractJob>> RunBatchJobsApiV1ExtractionJobsBatchPostAsync(
            global::System.Guid extractionAgentId,
            global::System.Collections.Generic.IList<global::System.Guid> fileIds,
            bool? fromUi = default,
            string? session = default,
            global::System.Collections.Generic.IList<global::G.WebhookConfiguration>? webhookConfigurations = default,
            global::G.AnyOf<object, string, object>? dataSchemaOverride = default,
            global::G.ExtractConfig? configOverride = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.ExtractJobCreateBatch
            {
                WebhookConfigurations = webhookConfigurations,
                ExtractionAgentId = extractionAgentId,
                FileIds = fileIds,
                DataSchemaOverride = dataSchemaOverride,
                ConfigOverride = configOverride,
            };

            return await RunBatchJobsApiV1ExtractionJobsBatchPostAsync(
                fromUi: fromUi,
                session: session,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}