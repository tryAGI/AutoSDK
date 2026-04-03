//HintName: G.CollectionsClient.CreateCollection.g.cs

#nullable enable

namespace G
{
    public partial class CollectionsClient
    {
        partial void PrepareCreateCollectionArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string collectionName,
            ref int? timeout,
            global::G.CreateCollection request);
        partial void PrepareCreateCollectionRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string collectionName,
            int? timeout,
            global::G.CreateCollection request);
        partial void ProcessCreateCollectionResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateCollectionResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create collection<br/>
        /// Create new collection with given parameters
        /// </summary>
        /// <param name="collectionName"></param>
        /// <param name="timeout"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.CreateCollectionResponse> CreateCollectionAsync(
            string collectionName,

            global::G.CreateCollection request,
            int? timeout = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareCreateCollectionArguments(
                httpClient: HttpClient,
                collectionName: ref collectionName,
                timeout: ref timeout,
                request: request);

            var __pathBuilder = new global::G.PathBuilder(
                path: $"/collections/{collectionName}",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddOptionalParameter("timeout", timeout?.ToString()) 
                ; 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Put,
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
            var __httpRequestContentBody = request.ToJson(JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareCreateCollectionRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                collectionName: collectionName,
                timeout: timeout,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessCreateCollectionResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // error
            if ((int)__response.StatusCode >= 400 && (int)__response.StatusCode <= 499)
            {
                string? __content_4XX = null;
                global::System.Exception? __exception_4XX = null;
                global::G.ErrorResponse? __value_4XX = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_4XX = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_4XX = global::G.ErrorResponse.FromJson(__content_4XX, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_4XX = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_4XX = global::G.ErrorResponse.FromJson(__content_4XX, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_4XX = __ex;
                }

                throw new global::G.ApiException<global::G.ErrorResponse>(
                    message: __content_4XX ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_4XX,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_4XX,
                    ResponseObject = __value_4XX,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // error
            if (!__response.IsSuccessStatusCode)
            {
                string? __content_default = null;
                global::System.Exception? __exception_default = null;
                global::G.ErrorResponse? __value_default = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_default = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_default = global::G.ErrorResponse.FromJson(__content_default, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_default = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_default = global::G.ErrorResponse.FromJson(__content_default, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_default = __ex;
                }

                throw new global::G.ApiException<global::G.ErrorResponse>(
                    message: __content_default ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_default,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_default,
                    ResponseObject = __value_default,
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
                ProcessCreateCollectionResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.CreateCollectionResponse.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::G.CreateCollectionResponse.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
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
        /// Create collection<br/>
        /// Create new collection with given parameters
        /// </summary>
        /// <param name="collectionName"></param>
        /// <param name="timeout"></param>
        /// <param name="vectors">
        /// Vector params separator for single and multiple vector modes Single mode:<br/>
        /// { "size": 128, "distance": "Cosine" }<br/>
        /// or multiple mode:<br/>
        /// { "default": { "size": 128, "distance": "Cosine" } }
        /// </param>
        /// <param name="shardNumber">
        /// For auto sharding: Number of shards in collection. - Default is 1 for standalone, otherwise equal to the number of nodes - Minimum is 1<br/>
        /// For custom sharding: Number of shards in collection per shard group. - Default is 1, meaning that each shard key will be mapped to a single shard - Minimum is 1<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="shardingMethod">
        /// Sharding method Default is Auto - points are distributed across all available shards Custom - points are distributed across shards according to shard key<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="replicationFactor">
        /// Number of shards replicas. Default is 1 Minimum is 1<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="writeConsistencyFactor">
        /// Defines how many replicas should apply the operation for us to consider it successful. Increasing this number will make the collection more resilient to inconsistencies, but will also make it fail if not enough replicas are available. Does not have any performance impact.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="onDiskPayload">
        /// If true - point's payload will not be stored in memory. It will be read from the disk every time it is requested. This setting saves RAM by (slightly) increasing the response time. Note: those payload values that are involved in filtering and are indexed - remain in RAM.<br/>
        /// Default: true<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="hnswConfig">
        /// Custom params for HNSW index. If none - values from service configuration file are used.
        /// </param>
        /// <param name="walConfig">
        /// Custom params for WAL. If none - values from service configuration file are used.
        /// </param>
        /// <param name="optimizersConfig">
        /// Custom params for Optimizers.  If none - values from service configuration file are used.
        /// </param>
        /// <param name="quantizationConfig">
        /// Quantization parameters. If none - quantization is disabled.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="sparseVectors">
        /// Sparse vector data config.
        /// </param>
        /// <param name="strictModeConfig">
        /// Strict-mode config.
        /// </param>
        /// <param name="metadata">
        /// Arbitrary JSON metadata for the collection This can be used to store application-specific information such as creation time, migration data, inference model info, etc.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.CreateCollectionResponse> CreateCollectionAsync(
            string collectionName,
            int? timeout = default,
            global::G.VectorsConfig? vectors = default,
            int? shardNumber = default,
            global::G.ShardingMethod? shardingMethod = default,
            int? replicationFactor = default,
            int? writeConsistencyFactor = default,
            bool? onDiskPayload = default,
            global::G.HnswConfigDiff? hnswConfig = default,
            global::G.WalConfigDiff? walConfig = default,
            global::G.OptimizersConfigDiff? optimizersConfig = default,
            global::G.QuantizationConfig? quantizationConfig = default,
            global::System.Collections.Generic.Dictionary<string, global::G.SparseVectorParams>? sparseVectors = default,
            global::G.StrictModeConfig? strictModeConfig = default,
            global::G.Payload? metadata = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.CreateCollection
            {
                Vectors = vectors,
                ShardNumber = shardNumber,
                ShardingMethod = shardingMethod,
                ReplicationFactor = replicationFactor,
                WriteConsistencyFactor = writeConsistencyFactor,
                OnDiskPayload = onDiskPayload,
                HnswConfig = hnswConfig,
                WalConfig = walConfig,
                OptimizersConfig = optimizersConfig,
                QuantizationConfig = quantizationConfig,
                SparseVectors = sparseVectors,
                StrictModeConfig = strictModeConfig,
                Metadata = metadata,
            };

            return await CreateCollectionAsync(
                collectionName: collectionName,
                timeout: timeout,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}