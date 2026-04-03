//HintName: G.Api.OpenGetSpaceFolder.g.cs

#nullable enable

namespace G
{
    public partial class Api
    {
        partial void PrepareOpenGetSpaceFolderArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string workspaceId,
            ref global::G.FolderType folderType,
            ref string? parentFolderId,
            ref int? pageNum,
            ref int? pageSize);
        partial void PrepareOpenGetSpaceFolderRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string workspaceId,
            global::G.FolderType folderType,
            string? parentFolderId,
            int? pageNum,
            int? pageSize);
        partial void ProcessOpenGetSpaceFolderResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessOpenGetSpaceFolderResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// 查询文件夹列表<br/>
        /// {"0":{"ops":[{"insert":"工作空间中的用户可以查询工作空间中的文件夹列表。\n"},{"attributes":{"anchor":"6aa831bb","heading":"h2","lmkr":"1"},"insert":"*"},{"insert":"接口描述\n"},{"attributes":{"lmkr":"1"},"insert":"*"},{"insert":"你可以查询某个文件夹或工作空间根目录下的子文件夹列表。每次查询仅返回下一层级的文件夹信息，不包含更深层级的子文件夹。若需要获取更深层级的文件夹信息，你可以多次调用本 API，利用上一次查询返回的文件夹 ID 继续查询。\n"}],"zoneId":"0","zoneType":"Z"}}
        /// </summary>
        /// <param name="workspaceId"></param>
        /// <param name="folderType"></param>
        /// <param name="parentFolderId"></param>
        /// <param name="pageNum"></param>
        /// <param name="pageSize"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.OpenGetSpaceFolderResponse> OpenGetSpaceFolderAsync(
            string workspaceId,
            global::G.FolderType folderType,
            string? parentFolderId = default,
            int? pageNum = default,
            int? pageSize = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareOpenGetSpaceFolderArguments(
                httpClient: HttpClient,
                workspaceId: ref workspaceId,
                folderType: ref folderType,
                parentFolderId: ref parentFolderId,
                pageNum: ref pageNum,
                pageSize: ref pageSize);

            var __pathBuilder = new global::G.PathBuilder(
                path: "/v1/folders",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddRequiredParameter("workspace_id", workspaceId)
                .AddRequiredParameter("folder_type", folderType.ToValueString())
                .AddOptionalParameter("parent_folder_id", parentFolderId)
                .AddOptionalParameter("page_num", pageNum?.ToString())
                .AddOptionalParameter("page_size", pageSize?.ToString()) 
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
            PrepareOpenGetSpaceFolderRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                workspaceId: workspaceId,
                folderType: folderType,
                parentFolderId: parentFolderId,
                pageNum: pageNum,
                pageSize: pageSize);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessOpenGetSpaceFolderResponse(
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
                ProcessOpenGetSpaceFolderResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.OpenGetSpaceFolderResponse.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::G.OpenGetSpaceFolderResponse.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
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