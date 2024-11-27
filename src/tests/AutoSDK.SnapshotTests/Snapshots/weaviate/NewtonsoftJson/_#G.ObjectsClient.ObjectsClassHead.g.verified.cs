//HintName: G.ObjectsClient.ObjectsClassHead.g.cs

#nullable enable

namespace G
{
    public partial class ObjectsClient
    {
        partial void PrepareObjectsClassHeadArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string className,
            ref global::System.Guid id,
            ref global::G.ObjectsClassHeadConsistencyLevel? consistencyLevel,
            ref string? tenant);
        partial void PrepareObjectsClassHeadRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string className,
            global::System.Guid id,
            global::G.ObjectsClassHeadConsistencyLevel? consistencyLevel,
            string? tenant);
        partial void ProcessObjectsClassHeadResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// Check if an object exists.<br/>
        /// Checks if a data object exists based on its collection and uuid without retrieving it. &lt;br/&gt;&lt;br/&gt;Internally it skips reading the object from disk other than checking if it is present. Thus it does not use resources on marshalling, parsing, etc., and is faster. Note the resulting HTTP request has no body; the existence of an object is indicated solely by the status code.
        /// </summary>
        /// <param name="className"></param>
        /// <param name="id"></param>
        /// <param name="consistencyLevel">
        /// Default Value: QUORUM
        /// </param>
        /// <param name="tenant"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task ObjectsClassHeadAsync(
            string className,
            global::System.Guid id,
            global::G.ObjectsClassHeadConsistencyLevel? consistencyLevel = default,
            string? tenant = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareObjectsClassHeadArguments(
                httpClient: HttpClient,
                className: ref className,
                id: ref id,
                consistencyLevel: ref consistencyLevel,
                tenant: ref tenant);

            var consistencyLevelValue = consistencyLevel switch
            {
                global::G.ObjectsClassHeadConsistencyLevel.ONE => "ONE",
                global::G.ObjectsClassHeadConsistencyLevel.QUORUM => "QUORUM",
                global::G.ObjectsClassHeadConsistencyLevel.ALL => "ALL",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var __pathBuilder = new PathBuilder(
                path: $"/objects/{className}/{id}",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("consistency_level", consistencyLevelValue?.ToString()) 
                .AddOptionalParameter("tenant", tenant) 
                ; 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Head,
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
            PrepareObjectsClassHeadRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                className: className,
                id: id,
                consistencyLevel: consistencyLevel,
                tenant: tenant);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessObjectsClassHeadResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
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
        }
    }
}