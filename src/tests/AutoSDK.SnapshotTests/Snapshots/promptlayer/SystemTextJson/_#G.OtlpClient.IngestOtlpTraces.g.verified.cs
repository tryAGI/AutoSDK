//HintName: G.OtlpClient.IngestOtlpTraces.g.cs

#nullable enable

namespace G
{
    public partial class OtlpClient
    {
        partial void PrepareIngestOtlpTracesArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::G.IngestOtlpTracesContentType contentType,
            ref global::G.IngestOtlpTracesContentEncoding? contentEncoding,
            global::G.OtlpExportTraceServiceRequest request);
        partial void PrepareIngestOtlpTracesRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::G.IngestOtlpTracesContentType contentType,
            global::G.IngestOtlpTracesContentEncoding? contentEncoding,
            global::G.OtlpExportTraceServiceRequest request);
        partial void ProcessIngestOtlpTracesResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessIngestOtlpTracesResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Ingest Traces (OTLP)<br/>
        /// Ingest OpenTelemetry traces using the standard OTLP/HTTP protocol.<br/>
        /// This endpoint accepts an `ExportTraceServiceRequest` as defined by the [OpenTelemetry specification](https://opentelemetry.io/docs/specs/otel/protocol/otlp/#otlphttp). Spans carrying [GenAI semantic convention](https://opentelemetry.io/docs/specs/semconv/gen-ai/) attributes are automatically converted into PromptLayer request logs.<br/>
        /// Supported content types:<br/>
        /// - `application/x-protobuf` — binary protobuf encoding (recommended)<br/>
        /// - `application/json` — JSON encoding<br/>
        /// Gzip `Content-Encoding` is supported for both formats.<br/>
        /// Spans can include `promptlayer.prompt.name` (or `promptlayer.prompt.id`) and `promptlayer.prompt.version` (or `promptlayer.prompt.label`) attributes to link the generated request log to an existing prompt template in your workspace.
        /// </summary>
        /// <param name="contentType"></param>
        /// <param name="contentEncoding"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.OtlpExportTraceServiceResponse> IngestOtlpTracesAsync(
            global::G.IngestOtlpTracesContentType contentType,

            global::G.OtlpExportTraceServiceRequest request,
            global::G.IngestOtlpTracesContentEncoding? contentEncoding = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareIngestOtlpTracesArguments(
                httpClient: HttpClient,
                contentType: ref contentType,
                contentEncoding: ref contentEncoding,
                request: request);

            var __pathBuilder = new global::G.PathBuilder(
                path: "/v1/traces",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            __httpRequest.Headers.TryAddWithoutValidation("Content-Type", contentType.ToValueString());
            if (contentEncoding != default)
            {
                __httpRequest.Headers.TryAddWithoutValidation("Content-Encoding", contentEncoding?.ToValueString() ?? string.Empty);
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
            PrepareIngestOtlpTracesRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                contentType: contentType,
                contentEncoding: contentEncoding,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessIngestOtlpTracesResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // Unsupported Content-Type
            if ((int)__response.StatusCode == 415)
            {
                string? __content_415 = null;
                global::System.Exception? __exception_415 = null;
                global::G.ErrorResponse? __value_415 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_415 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_415 = global::G.ErrorResponse.FromJson(__content_415, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_415 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_415 = global::G.ErrorResponse.FromJson(__content_415, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_415 = __ex;
                }

                throw new global::G.ApiException<global::G.ErrorResponse>(
                    message: __content_415 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_415,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_415,
                    ResponseObject = __value_415,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // Internal server error during ingestion
            if ((int)__response.StatusCode == 500)
            {
                string? __content_500 = null;
                global::System.Exception? __exception_500 = null;
                global::G.ErrorResponse? __value_500 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_500 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_500 = global::G.ErrorResponse.FromJson(__content_500, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_500 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_500 = global::G.ErrorResponse.FromJson(__content_500, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_500 = __ex;
                }

                throw new global::G.ApiException<global::G.ErrorResponse>(
                    message: __content_500 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_500,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_500,
                    ResponseObject = __value_500,
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
                ProcessIngestOtlpTracesResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.OtlpExportTraceServiceResponse.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::G.OtlpExportTraceServiceResponse.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
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
        /// Ingest Traces (OTLP)<br/>
        /// Ingest OpenTelemetry traces using the standard OTLP/HTTP protocol.<br/>
        /// This endpoint accepts an `ExportTraceServiceRequest` as defined by the [OpenTelemetry specification](https://opentelemetry.io/docs/specs/otel/protocol/otlp/#otlphttp). Spans carrying [GenAI semantic convention](https://opentelemetry.io/docs/specs/semconv/gen-ai/) attributes are automatically converted into PromptLayer request logs.<br/>
        /// Supported content types:<br/>
        /// - `application/x-protobuf` — binary protobuf encoding (recommended)<br/>
        /// - `application/json` — JSON encoding<br/>
        /// Gzip `Content-Encoding` is supported for both formats.<br/>
        /// Spans can include `promptlayer.prompt.name` (or `promptlayer.prompt.id`) and `promptlayer.prompt.version` (or `promptlayer.prompt.label`) attributes to link the generated request log to an existing prompt template in your workspace.
        /// </summary>
        /// <param name="contentType"></param>
        /// <param name="contentEncoding"></param>
        /// <param name="resourceSpans">
        /// An array of ResourceSpans. Each element describes spans from a single instrumented resource.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.OtlpExportTraceServiceResponse> IngestOtlpTracesAsync(
            global::G.IngestOtlpTracesContentType contentType,
            global::G.IngestOtlpTracesContentEncoding? contentEncoding = default,
            global::System.Collections.Generic.IList<global::G.OtlpExportTraceServiceRequestResourceSpan>? resourceSpans = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.OtlpExportTraceServiceRequest
            {
                ResourceSpans = resourceSpans,
            };

            return await IngestOtlpTracesAsync(
                contentType: contentType,
                contentEncoding: contentEncoding,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}