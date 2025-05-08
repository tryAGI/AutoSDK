//HintName: G.EvalsClient.ListEvals.g.cs

#nullable enable

namespace G
{
    public partial class EvalsClient
    {
        partial void PrepareListEvalsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? after,
            ref int? limit,
            ref global::G.ListEvalsOrder? order,
            ref global::G.ListEvalsOrderBy? orderBy);
        partial void PrepareListEvalsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? after,
            int? limit,
            global::G.ListEvalsOrder? order,
            global::G.ListEvalsOrderBy? orderBy);
        partial void ProcessListEvalsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessListEvalsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List evaluations for a project.
        /// </summary>
        /// <param name="after"></param>
        /// <param name="limit">
        /// Default Value: 20
        /// </param>
        /// <param name="order">
        /// Default Value: asc
        /// </param>
        /// <param name="orderBy">
        /// Default Value: created_at
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.EvalList> ListEvalsAsync(
            string? after = default,
            int? limit = default,
            global::G.ListEvalsOrder? order = default,
            global::G.ListEvalsOrderBy? orderBy = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareListEvalsArguments(
                httpClient: HttpClient,
                after: ref after,
                limit: ref limit,
                order: ref order,
                orderBy: ref orderBy);

            var orderValue = order switch
            {
                global::G.ListEvalsOrder.Asc => "asc",
                global::G.ListEvalsOrder.Desc => "desc",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var orderByValue = orderBy switch
            {
                global::G.ListEvalsOrderBy.CreatedAt => "created_at",
                global::G.ListEvalsOrderBy.UpdatedAt => "updated_at",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var __pathBuilder = new PathBuilder(
                path: "/evals",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("after", after) 
                .AddOptionalParameter("limit", limit?.ToString()) 
                .AddOptionalParameter("order", orderValue?.ToString()) 
                .AddOptionalParameter("order_by", orderByValue?.ToString()) 
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
            PrepareListEvalsRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                after: after,
                limit: limit,
                order: order,
                orderBy: orderBy);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessListEvalsResponse(
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
                ProcessListEvalsResponseContent(
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
                    global::G.EvalList.FromJson(__content, JsonSerializerOptions) ??
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

                using var __content = await __response.Content.ReadAsStreamAsync(
#if NET5_0_OR_GREATER
                    cancellationToken
#endif
                ).ConfigureAwait(false);

                return
                    await global::G.EvalList.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
                    throw new global::System.InvalidOperationException("Response deserialization failed.");
            }
        }
    }
}