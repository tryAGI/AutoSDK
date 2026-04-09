//HintName: G.CollectionOperationsV2Client.CreateVectordbCollectionsCreate.g.cs

#nullable enable

namespace G
{
    public partial class CollectionOperationsV2Client
    {
        partial void PrepareCreateVectordbCollectionsCreateArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref int requestTimeout,
            ref string? authorization,
            global::G.CreateVectordbCollectionsCreateRequest request);
        partial void PrepareCreateVectordbCollectionsCreateRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            int requestTimeout,
            string? authorization,
            global::G.CreateVectordbCollectionsCreateRequest request);
        partial void ProcessCreateVectordbCollectionsCreateResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateVectordbCollectionsCreateResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create Collection<br/>
        /// This operation creates a collection in a specified cluster.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="authorization"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.HttpapiGenericRespCustomerCreateIndexResp> CreateVectordbCollectionsCreateAsync(
            int requestTimeout,

            global::G.CreateVectordbCollectionsCreateRequest request,
            string? authorization = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareCreateVectordbCollectionsCreateArguments(
                httpClient: HttpClient,
                requestTimeout: ref requestTimeout,
                authorization: ref authorization,
                request: request);

            var __pathBuilder = new global::G.PathBuilder(
                path: "/v2/vectordb/collections/create",
                baseUri: HttpClient.BaseAddress);
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            __httpRequest.Headers.TryAddWithoutValidation("Request-Timeout", requestTimeout.ToString());
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
            PrepareCreateVectordbCollectionsCreateRequest(
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
            ProcessCreateVectordbCollectionsCreateResponse(
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
                ProcessCreateVectordbCollectionsCreateResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.HttpapiGenericRespCustomerCreateIndexResp.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::G.HttpapiGenericRespCustomerCreateIndexResp.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
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
        /// Create Collection<br/>
        /// This operation creates a collection in a specified cluster.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="authorization"></param>
        /// <param name="dbName">
        /// The name of the database. &lt;zilliz&gt;This parameter applies only to dedicated clusters.&lt;/zilliz&gt;
        /// </param>
        /// <param name="collectionName">
        /// The name of the collection to create.
        /// </param>
        /// <param name="dimension">
        /// The number of dimensions a vector value should have.<br/>
        /// This is required if **dtype** of this field is set to **DataType.FLOAT_VECTOR**.
        /// </param>
        /// <param name="metricType">
        /// The metric type applied to this operation. <br/>
        /// Possible values are **L2**, **IP**, and **COSINE**.
        /// </param>
        /// <param name="idType">
        /// The data type of the primary field. This parameter is designed for the quick-setup of a collection and will be ignored if __schema__ is defined.
        /// </param>
        /// <param name="autoID">
        /// Whether the primary field automatically increments. This parameter is designed for the quick-setup of a collection and will be ignored if __schema__ is defined.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="primaryFieldName">
        /// The name of the primary field. This parameter is designed for the quick-setup of a collection and will be ignored if __schema__ is defined.
        /// </param>
        /// <param name="vectorFieldName">
        /// The name of the vector field. This parameter is designed for the quick-setup of a collection and will be ignored if __schema__ is defined.
        /// </param>
        /// <param name="schema"></param>
        /// <param name="indexParams">
        /// The parameters that apply to the index-building process.
        /// </param>
        /// <param name="params"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.HttpapiGenericRespCustomerCreateIndexResp> CreateVectordbCollectionsCreateAsync(
            int requestTimeout,
            string? authorization = default,
            string? dbName = default,
            string? collectionName = default,
            int? dimension = default,
            string? metricType = default,
            string? idType = default,
            string autoID = "false",
            string? primaryFieldName = default,
            string? vectorFieldName = default,
            global::G.CollectionSchema? schema = default,
            global::System.Collections.Generic.IList<global::G.IndexParam>? indexParams = default,
            global::G.CollectionParams? @params = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.CreateVectordbCollectionsCreateRequest
            {
                DbName = dbName,
                CollectionName = collectionName,
                Dimension = dimension,
                MetricType = metricType,
                IdType = idType,
                AutoID = autoID,
                PrimaryFieldName = primaryFieldName,
                VectorFieldName = vectorFieldName,
                Schema = schema,
                IndexParams = indexParams,
                Params = @params,
            };

            return await CreateVectordbCollectionsCreateAsync(
                requestTimeout: requestTimeout,
                authorization: authorization,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}