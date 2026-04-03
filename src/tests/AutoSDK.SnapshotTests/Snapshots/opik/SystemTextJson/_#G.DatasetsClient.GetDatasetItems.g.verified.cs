//HintName: G.DatasetsClient.GetDatasetItems.g.cs

#nullable enable

namespace G
{
    public partial class DatasetsClient
    {
        partial void PrepareGetDatasetItemsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::System.Guid id,
            ref int? page,
            ref int? size,
            ref string? version,
            ref string? filters,
            ref bool? truncate);
        partial void PrepareGetDatasetItemsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::System.Guid id,
            int? page,
            int? size,
            string? version,
            string? filters,
            bool? truncate);
        partial void ProcessGetDatasetItemsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGetDatasetItemsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Get dataset items<br/>
        /// Get dataset items
        /// </summary>
        /// <param name="id"></param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="size">
        /// Default Value: 10
        /// </param>
        /// <param name="version">
        /// Version hash or tag to fetch specific dataset version
        /// </param>
        /// <param name="filters"></param>
        /// <param name="truncate">
        /// Truncate image included in either input, output or metadata
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.DatasetItemPagePublic> GetDatasetItemsAsync(
            global::System.Guid id,
            int? page = default,
            int? size = default,
            string? version = default,
            string? filters = default,
            bool? truncate = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareGetDatasetItemsArguments(
                httpClient: HttpClient,
                id: ref id,
                page: ref page,
                size: ref size,
                version: ref version,
                filters: ref filters,
                truncate: ref truncate);

            var __pathBuilder = new global::G.PathBuilder(
                path: $"/v1/private/datasets/{id}/items",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddOptionalParameter("page", page?.ToString())
                .AddOptionalParameter("size", size?.ToString())
                .AddOptionalParameter("version", version)
                .AddOptionalParameter("filters", filters)
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
            PrepareGetDatasetItemsRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                id: id,
                page: page,
                size: size,
                version: version,
                filters: filters,
                truncate: truncate);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessGetDatasetItemsResponse(
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
                ProcessGetDatasetItemsResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.DatasetItemPagePublic.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::G.DatasetItemPagePublic.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
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