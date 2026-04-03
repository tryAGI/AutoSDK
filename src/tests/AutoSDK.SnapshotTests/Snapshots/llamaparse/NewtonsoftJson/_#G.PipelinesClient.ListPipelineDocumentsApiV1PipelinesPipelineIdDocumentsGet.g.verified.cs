//HintName: G.PipelinesClient.ListPipelineDocumentsApiV1PipelinesPipelineIdDocumentsGet.g.cs

#nullable enable

namespace G
{
    public partial class PipelinesClient
    {
        partial void PrepareListPipelineDocumentsApiV1PipelinesPipelineIdDocumentsGetArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::System.Guid pipelineId,
            ref int? skip,
            ref int? limit,
            global::System.Guid? fileId,
            bool? onlyDirectUpload,
            bool? onlyApiDataSourceDocuments,
            ref global::G.ListPipelineDocumentsApiV1PipelinesPipelineIdDocumentsGetStatusRefreshPolicy? statusRefreshPolicy,
            ref string? session);
        partial void PrepareListPipelineDocumentsApiV1PipelinesPipelineIdDocumentsGetRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::System.Guid pipelineId,
            int? skip,
            int? limit,
            global::System.Guid? fileId,
            bool? onlyDirectUpload,
            bool? onlyApiDataSourceDocuments,
            global::G.ListPipelineDocumentsApiV1PipelinesPipelineIdDocumentsGetStatusRefreshPolicy? statusRefreshPolicy,
            string? session);
        partial void ProcessListPipelineDocumentsApiV1PipelinesPipelineIdDocumentsGetResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessListPipelineDocumentsApiV1PipelinesPipelineIdDocumentsGetResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List Pipeline Documents<br/>
        /// Return a list of documents for a pipeline.
        /// </summary>
        /// <param name="pipelineId"></param>
        /// <param name="skip">
        /// Default Value: 0
        /// </param>
        /// <param name="limit">
        /// Default Value: 10
        /// </param>
        /// <param name="fileId"></param>
        /// <param name="onlyDirectUpload">
        /// Default Value: false
        /// </param>
        /// <param name="onlyApiDataSourceDocuments">
        /// Default Value: false
        /// </param>
        /// <param name="statusRefreshPolicy">
        /// Default Value: cached
        /// </param>
        /// <param name="session"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.CloudDocument>> ListPipelineDocumentsApiV1PipelinesPipelineIdDocumentsGetAsync(
            global::System.Guid pipelineId,
            int? skip = default,
            int? limit = default,
            global::System.Guid? fileId = default,
            bool? onlyDirectUpload = default,
            bool? onlyApiDataSourceDocuments = default,
            global::G.ListPipelineDocumentsApiV1PipelinesPipelineIdDocumentsGetStatusRefreshPolicy? statusRefreshPolicy = default,
            string? session = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareListPipelineDocumentsApiV1PipelinesPipelineIdDocumentsGetArguments(
                httpClient: HttpClient,
                pipelineId: ref pipelineId,
                skip: ref skip,
                limit: ref limit,
                fileId: fileId,
                onlyDirectUpload: onlyDirectUpload,
                onlyApiDataSourceDocuments: onlyApiDataSourceDocuments,
                statusRefreshPolicy: ref statusRefreshPolicy,
                session: ref session);

            var statusRefreshPolicyValue = statusRefreshPolicy switch
            {
                global::G.ListPipelineDocumentsApiV1PipelinesPipelineIdDocumentsGetStatusRefreshPolicy.Cached => "cached",
                global::G.ListPipelineDocumentsApiV1PipelinesPipelineIdDocumentsGetStatusRefreshPolicy.Ttl => "ttl",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var __pathBuilder = new global::G.PathBuilder(
                path: $"/api/v1/pipelines/{pipelineId}/documents",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddOptionalParameter("skip", skip?.ToString())
                .AddOptionalParameter("limit", limit?.ToString())
                .AddOptionalParameter("file_id", fileId?.ToString())
                .AddOptionalParameter("only_direct_upload", onlyDirectUpload?.ToString().ToLowerInvariant())
                .AddOptionalParameter("only_api_data_source_documents", onlyApiDataSourceDocuments?.ToString().ToLowerInvariant())
                .AddOptionalParameter("status_refresh_policy", statusRefreshPolicy?.ToValueString()) 
                ; 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
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

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareListPipelineDocumentsApiV1PipelinesPipelineIdDocumentsGetRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                pipelineId: pipelineId,
                skip: skip,
                limit: limit,
                fileId: fileId,
                onlyDirectUpload: onlyDirectUpload,
                onlyApiDataSourceDocuments: onlyApiDataSourceDocuments,
                statusRefreshPolicy: statusRefreshPolicy,
                session: session);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessListPipelineDocumentsApiV1PipelinesPipelineIdDocumentsGetResponse(
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
                ProcessListPipelineDocumentsApiV1PipelinesPipelineIdDocumentsGetResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::System.Collections.Generic.IList<global::G.CloudDocument>?>(__content, JsonSerializerOptions) ??
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
                        global::Newtonsoft.Json.JsonSerializer.Create(JsonSerializerOptions).Deserialize<global::System.Collections.Generic.IList<global::G.CloudDocument>?>(new global::Newtonsoft.Json.JsonTextReader(new global::System.IO.StreamReader(__content))) ??
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
    }
}