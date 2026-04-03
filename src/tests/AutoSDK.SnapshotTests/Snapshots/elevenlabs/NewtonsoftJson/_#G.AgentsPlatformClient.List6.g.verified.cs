//HintName: G.AgentsPlatformClient.List6.g.cs

#nullable enable

namespace G
{
    public partial class AgentsPlatformClient
    {
        partial void PrepareList6Arguments(
            global::System.Net.Http.HttpClient httpClient,
            ref int? pageSize,
            ref string? search,
            ref bool? showOnlyOwnedDocuments,
            global::System.Collections.Generic.IList<global::G.KnowledgeBaseDocumentType>? types,
            ref string? parentFolderId,
            ref string? ancestorFolderId,
            ref bool? foldersFirst,
            ref global::G.SortDirection? sortDirection,
            global::G.KnowledgeBaseSortBy? sortBy,
            ref string? cursor,
            ref string? xiApiKey);
        partial void PrepareList6Request(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            int? pageSize,
            string? search,
            bool? showOnlyOwnedDocuments,
            global::System.Collections.Generic.IList<global::G.KnowledgeBaseDocumentType>? types,
            string? parentFolderId,
            string? ancestorFolderId,
            bool? foldersFirst,
            global::G.SortDirection? sortDirection,
            global::G.KnowledgeBaseSortBy? sortBy,
            string? cursor,
            string? xiApiKey);
        partial void ProcessList6Response(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessList6ResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Get Knowledge Base List<br/>
        /// Get a list of available knowledge base documents
        /// </summary>
        /// <param name="pageSize">
        /// How many documents to return at maximum. Can not exceed 100, defaults to 30.<br/>
        /// Default Value: 30
        /// </param>
        /// <param name="search">
        /// If specified, the endpoint returns only such knowledge base documents whose names start with this string.
        /// </param>
        /// <param name="showOnlyOwnedDocuments">
        /// If set to true, the endpoint will return only documents owned by you (and not shared from somebody else).<br/>
        /// Default Value: false
        /// </param>
        /// <param name="types">
        /// If present, the endpoint will return only documents of the given types.
        /// </param>
        /// <param name="parentFolderId">
        /// If set, the endpoint will return only documents that are direct children of the given folder.
        /// </param>
        /// <param name="ancestorFolderId">
        /// If set, the endpoint will return only documents that are descendants of the given folder.
        /// </param>
        /// <param name="foldersFirst">
        /// Whether folders should be returned first in the list of documents.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="sortDirection">
        /// The direction to sort the results<br/>
        /// Default Value: desc
        /// </param>
        /// <param name="sortBy">
        /// The field to sort the results by
        /// </param>
        /// <param name="cursor">
        /// Used for fetching next page. Cursor is returned in the response.
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programmatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.GetKnowledgeBaseListResponseModel> List6Async(
            int? pageSize = default,
            string? search = default,
            bool? showOnlyOwnedDocuments = default,
            global::System.Collections.Generic.IList<global::G.KnowledgeBaseDocumentType>? types = default,
            string? parentFolderId = default,
            string? ancestorFolderId = default,
            bool? foldersFirst = default,
            global::G.SortDirection? sortDirection = default,
            global::G.KnowledgeBaseSortBy? sortBy = default,
            string? cursor = default,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareList6Arguments(
                httpClient: HttpClient,
                pageSize: ref pageSize,
                search: ref search,
                showOnlyOwnedDocuments: ref showOnlyOwnedDocuments,
                types: types,
                parentFolderId: ref parentFolderId,
                ancestorFolderId: ref ancestorFolderId,
                foldersFirst: ref foldersFirst,
                sortDirection: ref sortDirection,
                sortBy: sortBy,
                cursor: ref cursor,
                xiApiKey: ref xiApiKey);

            var sortDirectionValue = sortDirection switch
            {
                global::G.SortDirection.Asc => "asc",
                global::G.SortDirection.Desc => "desc",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var __pathBuilder = new global::G.PathBuilder(
                path: "/v1/convai/knowledge-base",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddOptionalParameter("page_size", pageSize?.ToString())
                .AddOptionalParameter("search", search)
                .AddOptionalParameter("show_only_owned_documents", showOnlyOwnedDocuments?.ToString().ToLowerInvariant())
                .AddOptionalParameter("types", types?.ToString())
                .AddOptionalParameter("parent_folder_id", parentFolderId)
                .AddOptionalParameter("ancestor_folder_id", ancestorFolderId)
                .AddOptionalParameter("folders_first", foldersFirst?.ToString().ToLowerInvariant())
                .AddOptionalParameter("sort_direction", sortDirection?.ToValueString())
                .AddOptionalParameter("sort_by", sortBy?.ToString())
                .AddOptionalParameter("cursor", cursor) 
                ; 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            if (xiApiKey != default)
            {
                __httpRequest.Headers.TryAddWithoutValidation("xi-api-key", xiApiKey.ToString());
            }


            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareList6Request(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                pageSize: pageSize,
                search: search,
                showOnlyOwnedDocuments: showOnlyOwnedDocuments,
                types: types,
                parentFolderId: parentFolderId,
                ancestorFolderId: ancestorFolderId,
                foldersFirst: foldersFirst,
                sortDirection: sortDirection,
                sortBy: sortBy,
                cursor: cursor,
                xiApiKey: xiApiKey);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessList6Response(
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
                ProcessList6ResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.GetKnowledgeBaseListResponseModel.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::G.GetKnowledgeBaseListResponseModel.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
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