//HintName: G.AccountsClient.AccountsMeUsageCallsRetrieve.g.cs

#nullable enable

namespace G
{
    public partial class AccountsClient
    {
        partial void PrepareAccountsMeUsageCallsRetrieveArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? durationMax,
            ref string? durationMin,
            ref global::System.DateTime? fromDate,
            global::System.Collections.Generic.Dictionary<string, string>? metadata,
            ref string? search,
            ref global::System.DateTime? toDate,
            ref global::System.Guid? voiceId);
        partial void PrepareAccountsMeUsageCallsRetrieveRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? durationMax,
            string? durationMin,
            global::System.DateTime? fromDate,
            global::System.Collections.Generic.Dictionary<string, string>? metadata,
            string? search,
            global::System.DateTime? toDate,
            global::System.Guid? voiceId);
        partial void ProcessAccountsMeUsageCallsRetrieveResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessAccountsMeUsageCallsRetrieveResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Gets aggregated call usage.
        /// </summary>
        /// <param name="durationMax"></param>
        /// <param name="durationMin"></param>
        /// <param name="fromDate"></param>
        /// <param name="metadata"></param>
        /// <param name="search"></param>
        /// <param name="toDate"></param>
        /// <param name="voiceId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.CallUsage> AccountsMeUsageCallsRetrieveAsync(
            string? durationMax = default,
            string? durationMin = default,
            global::System.DateTime? fromDate = default,
            global::System.Collections.Generic.Dictionary<string, string>? metadata = default,
            string? search = default,
            global::System.DateTime? toDate = default,
            global::System.Guid? voiceId = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareAccountsMeUsageCallsRetrieveArguments(
                httpClient: HttpClient,
                durationMax: ref durationMax,
                durationMin: ref durationMin,
                fromDate: ref fromDate,
                metadata: metadata,
                search: ref search,
                toDate: ref toDate,
                voiceId: ref voiceId);

            var __pathBuilder = new global::G.PathBuilder(
                path: "/api/accounts/me/usage/calls",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("durationMax", durationMax) 
                .AddOptionalParameter("durationMin", durationMin) 
                .AddOptionalParameter("fromDate", fromDate?.ToString("yyyy-MM-dd")) 
                .AddOptionalParameter("metadata", metadata?.ToString()) 
                .AddOptionalParameter("search", search) 
                .AddOptionalParameter("toDate", toDate?.ToString("yyyy-MM-dd")) 
                .AddOptionalParameter("voiceId", voiceId?.ToString()) 
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
            PrepareAccountsMeUsageCallsRetrieveRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                durationMax: durationMax,
                durationMin: durationMin,
                fromDate: fromDate,
                metadata: metadata,
                search: search,
                toDate: toDate,
                voiceId: voiceId);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessAccountsMeUsageCallsRetrieveResponse(
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
                ProcessAccountsMeUsageCallsRetrieveResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.CallUsage.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::G.CallUsage.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                }
                catch (global::System.Exception __ex)
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
}