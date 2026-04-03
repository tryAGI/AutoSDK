//HintName: G.VectorOperationsV2Client.CreateVectordbEntitiesSearch.g.cs

#nullable enable

namespace G
{
    public partial class VectorOperationsV2Client
    {
        partial void PrepareCreateVectordbEntitiesSearchArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref int? requestTimeout,
            ref string? authorization,
            global::G.CreateVectordbEntitiesSearchRequest request);
        partial void PrepareCreateVectordbEntitiesSearchRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            int? requestTimeout,
            string? authorization,
            global::G.CreateVectordbEntitiesSearchRequest request);
        partial void ProcessCreateVectordbEntitiesSearchResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateVectordbEntitiesSearchResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Search<br/>
        /// This operation conducts a vector similarity search with an optional scalar filtering expression.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="authorization"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.CreateVectordbEntitiesSearchResponse> CreateVectordbEntitiesSearchAsync(

            global::G.CreateVectordbEntitiesSearchRequest request,
            int? requestTimeout = default,
            string? authorization = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareCreateVectordbEntitiesSearchArguments(
                httpClient: HttpClient,
                requestTimeout: ref requestTimeout,
                authorization: ref authorization,
                request: request);

            var __pathBuilder = new global::G.PathBuilder(
                path: "/v2/vectordb/entities/search",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            if (requestTimeout != default)
            {
                __httpRequest.Headers.TryAddWithoutValidation("Request-Timeout", requestTimeout.ToString());
            }
            if (authorization != default)
            {
                __httpRequest.Headers.TryAddWithoutValidation("Authorization", authorization.ToString());
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
            PrepareCreateVectordbEntitiesSearchRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                requestTimeout: requestTimeout,
                authorization: authorization,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessCreateVectordbEntitiesSearchResponse(
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
                ProcessCreateVectordbEntitiesSearchResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.CreateVectordbEntitiesSearchResponse.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::G.CreateVectordbEntitiesSearchResponse.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
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
        /// Search<br/>
        /// This operation conducts a vector similarity search with an optional scalar filtering expression.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="authorization"></param>
        /// <param name="dbName">
        /// The name of the database.
        /// </param>
        /// <param name="collectionName">
        /// The name of the collection to which this operation applies.
        /// </param>
        /// <param name="vector">
        /// A list of vector embeddings.<br/>
        /// &lt;include target="milvus"&gt;Milvus&lt;/include&gt;&lt;include target="zilliz"&gt;Zilliz Cloud&lt;/include&gt; searches for the most similar vector embeddings to the specified ones.
        /// </param>
        /// <param name="annsField"></param>
        /// <param name="filter">
        /// The filter used to find matches for the search.
        /// </param>
        /// <param name="limit">
        /// The total number of entities to return.<br/>
        /// You can use this parameter in combination with **offset** in **param** to enable pagination.<br/>
        /// The sum of this value and **offset** in **param** should be less than 16,384. 
        /// </param>
        /// <param name="offset">
        ///     The number of records to skip in the search result.      You can use this parameter in combination with limit to enable pagination.     The sum of this value and limit should be less than 16,384. 
        /// </param>
        /// <param name="groupingField">
        /// https://zilliverse.feishu.cn/docx/S3brdwmUHoG33dxhifpcruAYnsb
        /// </param>
        /// <param name="outputFields">
        /// An array of fields to return along with the search results.
        /// </param>
        /// <param name="searchParams"></param>
        /// <param name="partitionNames">
        /// The name of the partitions to which this operation applies.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.CreateVectordbEntitiesSearchResponse> CreateVectordbEntitiesSearchAsync(
            string collectionName,
            global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::G.AnyOf<int?, string>>> vector,
            global::G.SearchParams searchParams,
            int? requestTimeout = default,
            string? authorization = default,
            string? dbName = default,
            string? annsField = default,
            string? filter = default,
            int? limit = default,
            int? offset = default,
            string? groupingField = default,
            global::System.Collections.Generic.IList<string>? outputFields = default,
            global::System.Collections.Generic.IList<string>? partitionNames = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.CreateVectordbEntitiesSearchRequest
            {
                DbName = dbName,
                CollectionName = collectionName,
                Vector = vector,
                AnnsField = annsField,
                Filter = filter,
                Limit = limit,
                Offset = offset,
                GroupingField = groupingField,
                OutputFields = outputFields,
                SearchParams = searchParams,
                PartitionNames = partitionNames,
            };

            return await CreateVectordbEntitiesSearchAsync(
                requestTimeout: requestTimeout,
                authorization: authorization,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}