//HintName: G.ObjectsClient.ObjectsList.g.cs

#nullable enable

namespace G
{
    public partial class ObjectsClient
    {
        partial void PrepareObjectsListArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? after,
            ref long? offset,
            ref long? limit,
            ref string? include,
            ref string? sort,
            ref global::G.ObjectsListOrder? order,
            ref string? @class,
            ref string? tenant);
        partial void PrepareObjectsListRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? after,
            long? offset,
            long? limit,
            string? include,
            string? sort,
            global::G.ObjectsListOrder? order,
            string? @class,
            string? tenant);
        partial void ProcessObjectsListResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessObjectsListResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Get a list of objects.<br/>
        /// Lists all objects in reverse order of creation. The data will be returned as an array of objects. &lt;br/&gt;&lt;br/&gt;Tip: If you are looking to list all objects in a collection, use the `after` parameter.
        /// </summary>
        /// <param name="after"></param>
        /// <param name="offset">
        /// Default Value: 0L
        /// </param>
        /// <param name="limit">
        /// Default Value: 25L
        /// </param>
        /// <param name="include"></param>
        /// <param name="sort"></param>
        /// <param name="order"></param>
        /// <param name="class"></param>
        /// <param name="tenant"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.ObjectsListResponse> ObjectsListAsync(
            string? after = default,
            long? offset = default,
            long? limit = default,
            string? include = default,
            string? sort = default,
            global::G.ObjectsListOrder? order = default,
            string? @class = default,
            string? tenant = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareObjectsListArguments(
                httpClient: HttpClient,
                after: ref after,
                offset: ref offset,
                limit: ref limit,
                include: ref include,
                sort: ref sort,
                order: ref order,
                @class: ref @class,
                tenant: ref tenant);

            var orderValue = order switch
            {
                global::G.ObjectsListOrder.Asc => "asc",
                global::G.ObjectsListOrder.Desc => "desc",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var __pathBuilder = new PathBuilder(
                path: "/objects",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("after", after) 
                .AddOptionalParameter("offset", offset?.ToString()) 
                .AddOptionalParameter("limit", limit?.ToString()) 
                .AddOptionalParameter("include", include) 
                .AddOptionalParameter("sort", sort) 
                .AddOptionalParameter("order", orderValue?.ToString()) 
                .AddOptionalParameter("class", @class) 
                .AddOptionalParameter("tenant", tenant) 
                ; 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

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
            PrepareObjectsListRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                after: after,
                offset: offset,
                limit: limit,
                include: include,
                sort: sort,
                order: order,
                @class: @class,
                tenant: tenant);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessObjectsListResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            var __content = await __response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: HttpClient,
                response: __response,
                content: ref __content);
            ProcessObjectsListResponseContent(
                httpClient: HttpClient,
                httpResponseMessage: __response,
                content: ref __content);

            try
            {
                __response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException __ex)
            {
                throw new global::System.InvalidOperationException(__content, __ex);
            }

            return
                global::G.ObjectsListResponse.FromJson(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}