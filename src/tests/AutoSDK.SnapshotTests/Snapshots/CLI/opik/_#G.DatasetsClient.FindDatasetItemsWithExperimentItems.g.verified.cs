//HintName: G.DatasetsClient.FindDatasetItemsWithExperimentItems.g.cs

#nullable enable

namespace G
{
    public partial class DatasetsClient
    {
        partial void PrepareFindDatasetItemsWithExperimentItemsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::System.Guid id,
            ref int? page,
            ref int? size,
            ref string experimentIds,
            ref string? filters,
            ref string? sorting,
            ref string? search,
            ref bool? truncate);
        partial void PrepareFindDatasetItemsWithExperimentItemsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::System.Guid id,
            int? page,
            int? size,
            string experimentIds,
            string? filters,
            string? sorting,
            string? search,
            bool? truncate);
        partial void ProcessFindDatasetItemsWithExperimentItemsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessFindDatasetItemsWithExperimentItemsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Find dataset items with experiment items<br/>
        /// Find dataset items with experiment items
        /// </summary>
        /// <param name="id"></param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="size">
        /// Default Value: 10
        /// </param>
        /// <param name="experimentIds"></param>
        /// <param name="filters"></param>
        /// <param name="sorting"></param>
        /// <param name="search"></param>
        /// <param name="truncate">
        /// Truncate image included in either input, output or metadata
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.DatasetItemPageCompare> FindDatasetItemsWithExperimentItemsAsync(
            global::System.Guid id,
            string experimentIds,
            int? page = default,
            int? size = default,
            string? filters = default,
            string? sorting = default,
            string? search = default,
            bool? truncate = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareFindDatasetItemsWithExperimentItemsArguments(
                httpClient: HttpClient,
                id: ref id,
                page: ref page,
                size: ref size,
                experimentIds: ref experimentIds,
                filters: ref filters,
                sorting: ref sorting,
                search: ref search,
                truncate: ref truncate);

            var __pathBuilder = new global::G.PathBuilder(
                path: $"/v1/private/datasets/{id}/items/experiments/items",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddOptionalParameter("page", page?.ToString())
                .AddOptionalParameter("size", size?.ToString())
                .AddRequiredParameter("experiment_ids", experimentIds)
                .AddOptionalParameter("filters", filters)
                .AddOptionalParameter("sorting", sorting)
                .AddOptionalParameter("search", search)
                .AddOptionalParameter("truncate", truncate?.ToString().ToLowerInvariant()) 
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
            PrepareFindDatasetItemsWithExperimentItemsRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                id: id,
                page: page,
                size: size,
                experimentIds: experimentIds,
                filters: filters,
                sorting: sorting,
                search: search,
                truncate: truncate);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessFindDatasetItemsWithExperimentItemsResponse(
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
                ProcessFindDatasetItemsWithExperimentItemsResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.DatasetItemPageCompare.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::G.DatasetItemPageCompare.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
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