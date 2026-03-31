//HintName: G.FoldersClient.ListFolderEntitiesApiPublicV2FoldersEntitiesGet.g.cs

#nullable enable

namespace G
{
    public partial class FoldersClient
    {
        partial void PrepareListFolderEntitiesApiPublicV2FoldersEntitiesGetArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref int workspaceId,
            ref int? folderId,
            ref global::G.OneOf<global::G.ListFolderEntitiesApiPublicV2FoldersEntitiesGetFilterType2?, global::System.Collections.Generic.IList<global::G.ListFolderEntitiesApiPublicV2FoldersEntitiesGetFilterTypeItem>>? filterType,
            ref string? searchQuery,
            ref bool? flatten,
            ref bool? includeMetadata);
        partial void PrepareListFolderEntitiesApiPublicV2FoldersEntitiesGetRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            int workspaceId,
            int? folderId,
            global::G.OneOf<global::G.ListFolderEntitiesApiPublicV2FoldersEntitiesGetFilterType2?, global::System.Collections.Generic.IList<global::G.ListFolderEntitiesApiPublicV2FoldersEntitiesGetFilterTypeItem>>? filterType,
            string? searchQuery,
            bool? flatten,
            bool? includeMetadata);
        partial void ProcessListFolderEntitiesApiPublicV2FoldersEntitiesGetResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessListFolderEntitiesApiPublicV2FoldersEntitiesGetResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List Folder Entities<br/>
        /// Lists entities within a folder or at the workspace root. Returns folders, prompts, snippets, workflows, datasets, evaluations, AB tests, and input variable sets. Supports filtering by entity type, searching by name, flattening the folder hierarchy, and optionally including entity metadata.
        /// </summary>
        /// <param name="workspaceId">
        /// The ID of the workspace to list entities from.
        /// </param>
        /// <param name="folderId">
        /// The ID of the folder to list entities from. If not provided, lists entities at the workspace root level.
        /// </param>
        /// <param name="filterType">
        /// Filter entities by type. Can be a single type or a list of types. If not provided, all entity types are returned.
        /// </param>
        /// <param name="searchQuery">
        /// Search entities by name (case-insensitive partial match).
        /// </param>
        /// <param name="flatten">
        /// When true, returns all entities recursively within the folder hierarchy instead of only direct children.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="includeMetadata">
        /// When true, includes type-specific metadata for each entity (e.g., prompt type, latest version number).<br/>
        /// Default Value: false
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.ListFolderEntitiesResponse> ListFolderEntitiesApiPublicV2FoldersEntitiesGetAsync(
            int workspaceId,
            int? folderId = default,
            global::G.OneOf<global::G.ListFolderEntitiesApiPublicV2FoldersEntitiesGetFilterType2?, global::System.Collections.Generic.IList<global::G.ListFolderEntitiesApiPublicV2FoldersEntitiesGetFilterTypeItem>>? filterType = default,
            string? searchQuery = default,
            bool? flatten = default,
            bool? includeMetadata = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareListFolderEntitiesApiPublicV2FoldersEntitiesGetArguments(
                httpClient: HttpClient,
                workspaceId: ref workspaceId,
                folderId: ref folderId,
                filterType: ref filterType,
                searchQuery: ref searchQuery,
                flatten: ref flatten,
                includeMetadata: ref includeMetadata);

            var __pathBuilder = new global::G.PathBuilder(
                path: "/api/public/v2/folders/entities",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddRequiredParameter("workspace_id", workspaceId.ToString()!)
                .AddOptionalParameter("folder_id", folderId?.ToString())
                .AddOptionalParameter("filter_type", filterType?.ToString())
                .AddOptionalParameter("search_query", searchQuery)
                .AddOptionalParameter("flatten", flatten?.ToString().ToLowerInvariant())
                .AddOptionalParameter("include_metadata", includeMetadata?.ToString().ToLowerInvariant()) 
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
            PrepareListFolderEntitiesApiPublicV2FoldersEntitiesGetRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                workspaceId: workspaceId,
                folderId: folderId,
                filterType: filterType,
                searchQuery: searchQuery,
                flatten: flatten,
                includeMetadata: includeMetadata);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessListFolderEntitiesApiPublicV2FoldersEntitiesGetResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // Bad request - Missing or invalid workspace_id
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
            // Folder not found
            if ((int)__response.StatusCode == 404)
            {
                string? __content_404 = null;
                global::System.Exception? __exception_404 = null;
                global::G.FolderNotFoundError? __value_404 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_404 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_404 = global::G.FolderNotFoundError.FromJson(__content_404, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_404 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_404 = global::G.FolderNotFoundError.FromJson(__content_404, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_404 = __ex;
                }

                throw new global::G.ApiException<global::G.FolderNotFoundError>(
                    message: __content_404 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_404,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_404,
                    ResponseObject = __value_404,
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
                ProcessListFolderEntitiesApiPublicV2FoldersEntitiesGetResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.ListFolderEntitiesResponse.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::G.ListFolderEntitiesResponse.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
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