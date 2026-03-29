//HintName: G.DatasetsClient.ListDatasets.g.cs

#nullable enable

namespace G
{
    public partial class DatasetsClient
    {
        partial void PrepareListDatasetsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref int? datasetGroupId,
            ref int? promptId,
            ref int? promptVersionId,
            ref int? promptLabelId,
            ref int? workspaceId,
            ref int? reportId,
            ref string? name,
            ref global::G.ListDatasetsStatus? status,
            ref int? page,
            ref int? perPage);
        partial void PrepareListDatasetsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            int? datasetGroupId,
            int? promptId,
            int? promptVersionId,
            int? promptLabelId,
            int? workspaceId,
            int? reportId,
            string? name,
            global::G.ListDatasetsStatus? status,
            int? page,
            int? perPage);
        partial void ProcessListDatasetsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessListDatasetsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List Datasets
        /// </summary>
        /// <param name="datasetGroupId"></param>
        /// <param name="promptId"></param>
        /// <param name="promptVersionId"></param>
        /// <param name="promptLabelId"></param>
        /// <param name="workspaceId"></param>
        /// <param name="reportId"></param>
        /// <param name="name"></param>
        /// <param name="status">
        /// Default Value: active
        /// </param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="perPage">
        /// Default Value: 10
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.ListDatasetsResponse> ListDatasetsAsync(
            int? datasetGroupId = default,
            int? promptId = default,
            int? promptVersionId = default,
            int? promptLabelId = default,
            int? workspaceId = default,
            int? reportId = default,
            string? name = default,
            global::G.ListDatasetsStatus? status = default,
            int? page = default,
            int? perPage = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareListDatasetsArguments(
                httpClient: HttpClient,
                datasetGroupId: ref datasetGroupId,
                promptId: ref promptId,
                promptVersionId: ref promptVersionId,
                promptLabelId: ref promptLabelId,
                workspaceId: ref workspaceId,
                reportId: ref reportId,
                name: ref name,
                status: ref status,
                page: ref page,
                perPage: ref perPage);

            var statusValue = status switch
            {
                global::G.ListDatasetsStatus.Active => "active",
                global::G.ListDatasetsStatus.Deleted => "deleted",
                global::G.ListDatasetsStatus.All => "all",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var __pathBuilder = new global::G.PathBuilder(
                path: "/api/public/v2/datasets",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddOptionalParameter("dataset_group_id", datasetGroupId?.ToString())
                .AddOptionalParameter("prompt_id", promptId?.ToString())
                .AddOptionalParameter("prompt_version_id", promptVersionId?.ToString())
                .AddOptionalParameter("prompt_label_id", promptLabelId?.ToString())
                .AddOptionalParameter("workspace_id", workspaceId?.ToString())
                .AddOptionalParameter("report_id", reportId?.ToString())
                .AddOptionalParameter("name", name)
                .AddOptionalParameter("status", status?.ToValueString())
                .AddOptionalParameter("page", page?.ToString())
                .AddOptionalParameter("per_page", perPage?.ToString()) 
                ; 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareListDatasetsRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                datasetGroupId: datasetGroupId,
                promptId: promptId,
                promptVersionId: promptVersionId,
                promptLabelId: promptLabelId,
                workspaceId: workspaceId,
                reportId: reportId,
                name: name,
                status: status,
                page: page,
                perPage: perPage);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessListDatasetsResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // Invalid workspace_id
            if ((int)__response.StatusCode == 400)
            {
                string? __content_400 = null;
                global::System.Exception? __exception_400 = null;
                global::G.ErrorResponse? __value_400 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_400 = global::G.ErrorResponse.FromJson(__content_400, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_400 = global::G.ErrorResponse.FromJson(__content_400, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_400 = __ex;
                }

                throw new global::G.ApiException<global::G.ErrorResponse>(
                    message: __content_400 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_400,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_400,
                    ResponseObject = __value_400,
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
                ProcessListDatasetsResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.ListDatasetsResponse.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::G.ListDatasetsResponse.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
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