//HintName: G.VectorOperationsV2Client.CreateVectordbEntitiesQuery.g.cs

#nullable enable

namespace G
{
    public partial class VectorOperationsV2Client
    {
        partial void PrepareCreateVectordbEntitiesQueryArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref int? requestTimeout,
            ref string? authorization,
            global::G.CreateVectordbEntitiesQueryRequest request);
        partial void PrepareCreateVectordbEntitiesQueryRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            int? requestTimeout,
            string? authorization,
            global::G.CreateVectordbEntitiesQueryRequest request);
        partial void ProcessCreateVectordbEntitiesQueryResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateVectordbEntitiesQueryResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Query<br/>
        /// This operation conducts a filtering on the scalar field with a specified boolean expression.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="authorization"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.CreateVectordbEntitiesQueryResponse> CreateVectordbEntitiesQueryAsync(

            global::G.CreateVectordbEntitiesQueryRequest request,
            int? requestTimeout = default,
            string? authorization = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareCreateVectordbEntitiesQueryArguments(
                httpClient: HttpClient,
                requestTimeout: ref requestTimeout,
                authorization: ref authorization,
                request: request);

            var __pathBuilder = new global::G.PathBuilder(
                path: "/v2/vectordb/entities/query",
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
            PrepareCreateVectordbEntitiesQueryRequest(
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
            ProcessCreateVectordbEntitiesQueryResponse(
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
                ProcessCreateVectordbEntitiesQueryResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.CreateVectordbEntitiesQueryResponse.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::G.CreateVectordbEntitiesQueryResponse.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
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
        /// Query<br/>
        /// This operation conducts a filtering on the scalar field with a specified boolean expression.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="authorization"></param>
        /// <param name="dbName">
        /// The name of the database.
        /// </param>
        /// <param name="collectionName">
        /// The name of the collection to which this operation applies.
        /// </param>
        /// <param name="filter">
        /// The filter used to find matches for the search.
        /// </param>
        /// <param name="outputFields">
        /// An array of fields to return along with the search results.
        /// </param>
        /// <param name="partitionNames">
        /// The name of the partitions to which this operation applies.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.CreateVectordbEntitiesQueryResponse> CreateVectordbEntitiesQueryAsync(
            string collectionName,
            int? requestTimeout = default,
            string? authorization = default,
            string? dbName = default,
            string? filter = default,
            global::System.Collections.Generic.IList<string>? outputFields = default,
            global::System.Collections.Generic.IList<string>? partitionNames = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.CreateVectordbEntitiesQueryRequest
            {
                DbName = dbName,
                CollectionName = collectionName,
                Filter = filter,
                OutputFields = outputFields,
                PartitionNames = partitionNames,
            };

            return await CreateVectordbEntitiesQueryAsync(
                requestTimeout: requestTimeout,
                authorization: authorization,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}