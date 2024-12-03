//HintName: G.VectorStoresClient.ListVectorStoreFiles.g.cs

#nullable enable

namespace G
{
    public partial class VectorStoresClient
    {
        partial void PrepareListVectorStoreFilesArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string vectorStoreId,
            ref int? limit,
            ref global::G.ListVectorStoreFilesOrder? order,
            ref string? after,
            ref string? before,
            ref global::G.ListVectorStoreFilesFilter? filter);
        partial void PrepareListVectorStoreFilesRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string vectorStoreId,
            int? limit,
            global::G.ListVectorStoreFilesOrder? order,
            string? after,
            string? before,
            global::G.ListVectorStoreFilesFilter? filter);
        partial void ProcessListVectorStoreFilesResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessListVectorStoreFilesResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Returns a list of vector store files.
        /// </summary>
        /// <param name="vectorStoreId"></param>
        /// <param name="limit">
        /// Default Value: 20
        /// </param>
        /// <param name="order">
        /// Default Value: desc
        /// </param>
        /// <param name="after"></param>
        /// <param name="before"></param>
        /// <param name="filter"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "G_BETA_001")]
        public async global::System.Threading.Tasks.Task<global::G.ListVectorStoreFilesResponse> ListVectorStoreFilesAsync(
            string vectorStoreId,
            int? limit = default,
            global::G.ListVectorStoreFilesOrder? order = default,
            string? after = default,
            string? before = default,
            global::G.ListVectorStoreFilesFilter? filter = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareListVectorStoreFilesArguments(
                httpClient: HttpClient,
                vectorStoreId: ref vectorStoreId,
                limit: ref limit,
                order: ref order,
                after: ref after,
                before: ref before,
                filter: ref filter);

            var __pathBuilder = new PathBuilder(
                path: $"/vector_stores/{vectorStoreId}/files",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("limit", limit?.ToString()) 
                .AddOptionalParameter("order", order?.ToValueString()) 
                .AddOptionalParameter("after", after) 
                .AddOptionalParameter("before", before) 
                .AddOptionalParameter("filter", filter?.ToValueString()) 
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
            PrepareListVectorStoreFilesRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                vectorStoreId: vectorStoreId,
                limit: limit,
                order: order,
                after: after,
                before: before,
                filter: filter);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessListVectorStoreFilesResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            if (ReadResponseAsString)
            {
                var __content = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                ProcessResponseContent(
                    client: HttpClient,
                    response: __response,
                    content: ref __content);
                ProcessListVectorStoreFilesResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();
                }
                catch (global::System.Net.Http.HttpRequestException __ex)
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

                return
                    global::G.ListVectorStoreFilesResponse.FromJson(__content, JsonSerializerContext) ??
                    throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
            }
            else
            {
                try
                {
                    __response.EnsureSuccessStatusCode();
                }
                catch (global::System.Net.Http.HttpRequestException __ex)
                {
                    throw new global::G.ApiException(
                        message: __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }

                using var __content = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);

                return
                    await global::G.ListVectorStoreFilesResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                    throw new global::System.InvalidOperationException("Response deserialization failed.");
            }
        }
    }
}