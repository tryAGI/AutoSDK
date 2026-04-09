//HintName: G.CollectionOperationsV2Client.CreateVectordbCollectionsLoad.g.cs

#nullable enable

namespace G
{
    public partial class CollectionOperationsV2Client
    {
        partial void PrepareCreateVectordbCollectionsLoadArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref int requestHeader,
            ref string? authorization,
            global::G.CollectionName request);
        partial void PrepareCreateVectordbCollectionsLoadRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            int requestHeader,
            string? authorization,
            global::G.CollectionName request);
        partial void ProcessCreateVectordbCollectionsLoadResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// Load Collection<br/>
        /// This operation loads the data of the current collection into memory. 
        /// </summary>
        /// <param name="requestHeader"></param>
        /// <param name="authorization"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task CreateVectordbCollectionsLoadAsync(
            int requestHeader,

            global::G.CollectionName request,
            string? authorization = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareCreateVectordbCollectionsLoadArguments(
                httpClient: HttpClient,
                requestHeader: ref requestHeader,
                authorization: ref authorization,
                request: request);

            var __pathBuilder = new global::G.PathBuilder(
                path: "/v2/vectordb/collections/load",
                baseUri: HttpClient.BaseAddress);
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            __httpRequest.Headers.TryAddWithoutValidation("Request-Header", requestHeader.ToString());
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
            PrepareCreateVectordbCollectionsLoadRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                requestHeader: requestHeader,
                authorization: authorization,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessCreateVectordbCollectionsLoadResponse(
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
        /// Load Collection<br/>
        /// This operation loads the data of the current collection into memory. 
        /// </summary>
        /// <param name="requestHeader"></param>
        /// <param name="authorization"></param>
        /// <param name="dbName">
        /// The name of the database to which the collection belongs.<br/>
        /// Setting this to a non-existing database results in a **MilvusException**.
        /// </param>
        /// <param name="collectionName1">
        /// The name of the target collection.<br/>
        /// Setting this to a non-existing collection results in a **MilvusException**.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task CreateVectordbCollectionsLoadAsync(
            int requestHeader,
            string collectionName1,
            string? authorization = default,
            string? dbName = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.CollectionName
            {
                DbName = dbName,
                CollectionName1 = collectionName1,
            };

            await CreateVectordbCollectionsLoadAsync(
                requestHeader: requestHeader,
                authorization: authorization,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}