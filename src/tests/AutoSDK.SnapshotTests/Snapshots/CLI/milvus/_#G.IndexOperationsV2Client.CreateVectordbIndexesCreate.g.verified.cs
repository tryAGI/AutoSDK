//HintName: G.IndexOperationsV2Client.CreateVectordbIndexesCreate.g.cs

#nullable enable

namespace G
{
    public partial class IndexOperationsV2Client
    {
        partial void PrepareCreateVectordbIndexesCreateArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref int? requestTimeout,
            ref string? authorization,
            global::G.CreateVectordbIndexesCreateRequest request);
        partial void PrepareCreateVectordbIndexesCreateRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            int? requestTimeout,
            string? authorization,
            global::G.CreateVectordbIndexesCreateRequest request);
        partial void ProcessCreateVectordbIndexesCreateResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// Create Index<br/>
        /// This creates a named index for a target field, which can either be a vector field or a scalar field.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="authorization"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task CreateVectordbIndexesCreateAsync(

            global::G.CreateVectordbIndexesCreateRequest request,
            int? requestTimeout = default,
            string? authorization = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareCreateVectordbIndexesCreateArguments(
                httpClient: HttpClient,
                requestTimeout: ref requestTimeout,
                authorization: ref authorization,
                request: request);

            var __pathBuilder = new global::G.PathBuilder(
                path: "/v2/vectordb/indexes/create",
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
            PrepareCreateVectordbIndexesCreateRequest(
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
            ProcessCreateVectordbIndexesCreateResponse(
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

                try
                {
                    __response.EnsureSuccessStatusCode();

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
        /// Create Index<br/>
        /// This creates a named index for a target field, which can either be a vector field or a scalar field.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="authorization"></param>
        /// <param name="dbName">
        /// The name of the database to which the collection belongs.<br/>
        /// Setting this to a non-existing database results in a **MilvusException**.
        /// </param>
        /// <param name="collectionName">
        /// The name of the target collection.<br/>
        /// Setting this to a non-existing collection results in a **MilvusException**.
        /// </param>
        /// <param name="indexParams">
        ///   The parameters that apply to the index-building process.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task CreateVectordbIndexesCreateAsync(
            string collectionName,
            global::System.Collections.Generic.IList<global::G.IndexParam> indexParams,
            int? requestTimeout = default,
            string? authorization = default,
            string? dbName = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.CreateVectordbIndexesCreateRequest
            {
                DbName = dbName,
                CollectionName = collectionName,
                IndexParams = indexParams,
            };

            await CreateVectordbIndexesCreateAsync(
                requestTimeout: requestTimeout,
                authorization: authorization,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}