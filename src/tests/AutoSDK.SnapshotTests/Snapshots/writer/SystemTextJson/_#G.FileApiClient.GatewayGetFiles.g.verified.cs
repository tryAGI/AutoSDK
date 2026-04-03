//HintName: G.FileApiClient.GatewayGetFiles.g.cs

#nullable enable

namespace G
{
    public partial class FileApiClient
    {
        partial void PrepareGatewayGetFilesArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? before,
            ref string? after,
            ref int? limit,
            ref global::G.GatewayGetFilesOrder? order,
            ref global::System.Guid? graphId,
            ref global::G.GatewayGetFilesStatus? status,
            ref string? fileTypes);
        partial void PrepareGatewayGetFilesRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? before,
            string? after,
            int? limit,
            global::G.GatewayGetFilesOrder? order,
            global::System.Guid? graphId,
            global::G.GatewayGetFilesStatus? status,
            string? fileTypes);
        partial void ProcessGatewayGetFilesResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGatewayGetFilesResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List files<br/>
        /// Retrieve a paginated list of files with optional filtering by status, graph association, and file type.
        /// </summary>
        /// <param name="before"></param>
        /// <param name="after"></param>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="order">
        /// Default Value: desc
        /// </param>
        /// <param name="graphId"></param>
        /// <param name="status"></param>
        /// <param name="fileTypes"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        /// <remarks>
        /// curl --location --request GET https://api.writer.com/v1/files \<br/>
        ///  --header "Authorization: Bearer &lt;token&gt;"
        /// </remarks>
        public async global::System.Threading.Tasks.Task<global::G.FilesResponse> GatewayGetFilesAsync(
            string? before = default,
            string? after = default,
            int? limit = default,
            global::G.GatewayGetFilesOrder? order = default,
            global::System.Guid? graphId = default,
            global::G.GatewayGetFilesStatus? status = default,
            string? fileTypes = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareGatewayGetFilesArguments(
                httpClient: HttpClient,
                before: ref before,
                after: ref after,
                limit: ref limit,
                order: ref order,
                graphId: ref graphId,
                status: ref status,
                fileTypes: ref fileTypes);

            var __pathBuilder = new global::G.PathBuilder(
                path: "/v1/files",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddOptionalParameter("before", before)
                .AddOptionalParameter("after", after)
                .AddOptionalParameter("limit", limit?.ToString())
                .AddOptionalParameter("order", order?.ToValueString())
                .AddOptionalParameter("graph_id", graphId?.ToString())
                .AddOptionalParameter("status", status?.ToValueString())
                .AddOptionalParameter("file_types", fileTypes) 
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
            PrepareGatewayGetFilesRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                before: before,
                after: after,
                limit: limit,
                order: order,
                graphId: graphId,
                status: status,
                fileTypes: fileTypes);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessGatewayGetFilesResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

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
                ProcessGatewayGetFilesResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.FilesResponse.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::G.FilesResponse.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
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