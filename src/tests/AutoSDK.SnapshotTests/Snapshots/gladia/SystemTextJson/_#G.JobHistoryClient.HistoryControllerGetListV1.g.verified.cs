//HintName: G.JobHistoryClient.HistoryControllerGetListV1.g.cs

#nullable enable

namespace G
{
    public partial class JobHistoryClient
    {


        private static readonly global::G.EndPointSecurityRequirement s_HistoryControllerGetListV1SecurityRequirement0 =
            new global::G.EndPointSecurityRequirement
            {
                Authorizations = new global::G.EndPointAuthorizationRequirement[]
                {                    new global::G.EndPointAuthorizationRequirement
                    {
                        Type = "ApiKey",
                        SchemeId = "XGladiaKey",
                        Location = "Header",
                        Name = "x-gladia-key",
                        FriendlyName = "ApiKeyInHeader",
                    },
                },
            };
        private static readonly global::G.EndPointSecurityRequirement[] s_HistoryControllerGetListV1SecurityRequirements =
            new global::G.EndPointSecurityRequirement[]
            {                s_HistoryControllerGetListV1SecurityRequirement0,
            };
        partial void PrepareHistoryControllerGetListV1Arguments(
            global::System.Net.Http.HttpClient httpClient,
            ref int? offset,
            ref int? limit,
            ref global::System.DateTime? date,
            ref global::System.DateTime? beforeDate,
            ref global::System.DateTime? afterDate,
            global::System.Collections.Generic.IList<global::G.HistoryControllerGetListV1Statu>? status,
            object? customMetadata,
            global::System.Collections.Generic.IList<global::G.HistoryControllerGetListV1KindItem>? kind);
        partial void PrepareHistoryControllerGetListV1Request(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            int? offset,
            int? limit,
            global::System.DateTime? date,
            global::System.DateTime? beforeDate,
            global::System.DateTime? afterDate,
            global::System.Collections.Generic.IList<global::G.HistoryControllerGetListV1Statu>? status,
            object? customMetadata,
            global::System.Collections.Generic.IList<global::G.HistoryControllerGetListV1KindItem>? kind);
        partial void ProcessHistoryControllerGetListV1Response(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessHistoryControllerGetListV1ResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Get the history of all your jobs
        /// </summary>
        /// <param name="offset">
        /// Default Value: 0
        /// </param>
        /// <param name="limit">
        /// Default Value: 20
        /// </param>
        /// <param name="date">
        /// Example: 2026-03-28
        /// </param>
        /// <param name="beforeDate">
        /// Example: 2024-01-01T00:00:00.000Z
        /// </param>
        /// <param name="afterDate">
        /// Example: 2024-01-01T00:00:00.000Z
        /// </param>
        /// <param name="status">
        /// Example: [done]
        /// </param>
        /// <param name="customMetadata">
        /// Example: {"user":"John Doe"}
        /// </param>
        /// <param name="kind">
        /// Example: [pre-recorded]
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.ListHistoryResponse> HistoryControllerGetListV1Async(
            int? offset = default,
            int? limit = default,
            global::System.DateTime? date = default,
            global::System.DateTime? beforeDate = default,
            global::System.DateTime? afterDate = default,
            global::System.Collections.Generic.IList<global::G.HistoryControllerGetListV1Statu>? status = default,
            object? customMetadata = default,
            global::System.Collections.Generic.IList<global::G.HistoryControllerGetListV1KindItem>? kind = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareHistoryControllerGetListV1Arguments(
                httpClient: HttpClient,
                offset: ref offset,
                limit: ref limit,
                date: ref date,
                beforeDate: ref beforeDate,
                afterDate: ref afterDate,
                status: status,
                customMetadata: customMetadata,
                kind: kind);


            var __authorizations = global::G.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_HistoryControllerGetListV1SecurityRequirements,
                operationName: "HistoryControllerGetListV1Async");

            var __pathBuilder = new global::G.PathBuilder(
                path: "/v1/history",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddOptionalParameter("offset", offset?.ToString())
                .AddOptionalParameter("limit", limit?.ToString())
                .AddOptionalParameter("date", date?.ToString("yyyy-MM-ddTHH:mm:ssZ"))
                .AddOptionalParameter("before_date", beforeDate?.ToString("yyyy-MM-ddTHH:mm:ssZ"))
                .AddOptionalParameter("after_date", afterDate?.ToString("yyyy-MM-ddTHH:mm:ssZ"))
                .AddOptionalParameter("status", status, selector: static x => x.ToValueString(), delimiter: ",", explode: true)
                .AddOptionalParameter("custom_metadata", customMetadata?.ToString())
                .AddOptionalParameter("kind", kind, selector: static x => x.ToValueString(), delimiter: ",", explode: true) 
                ; 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            var __cookies = new global::System.Collections.Generic.List<string>();
            foreach (var __authorization in __authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2" ||
                    __authorization.Type == "OpenIdConnect")
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
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Cookie")
                {
                    var __cookieValue = global::System.Uri.EscapeDataString(__authorization.Value);
                    __cookies.Add($"{__authorization.Name}={__cookieValue}");
                }
            }

            if (__cookies.Count > 0)
            {
                __httpRequest.Headers.TryAddWithoutValidation("Cookie", string.Join("; ", __cookies));
            }

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareHistoryControllerGetListV1Request(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                offset: offset,
                limit: limit,
                date: date,
                beforeDate: beforeDate,
                afterDate: afterDate,
                status: status,
                customMetadata: customMetadata,
                kind: kind);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessHistoryControllerGetListV1Response(
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
                ProcessHistoryControllerGetListV1ResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.ListHistoryResponse.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::G.ListHistoryResponse.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
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
    }
}