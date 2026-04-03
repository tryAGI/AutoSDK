//HintName: G.PreRecordedV2Client.PreRecordedControllerGetPreRecordedJobsV2.g.cs

#nullable enable

namespace G
{
    public partial class PreRecordedV2Client
    {
        partial void PreparePreRecordedControllerGetPreRecordedJobsV2Arguments(
            global::System.Net.Http.HttpClient httpClient,
            ref int? offset,
            ref int? limit,
            ref global::System.DateTime? date,
            ref global::System.DateTime? beforeDate,
            ref global::System.DateTime? afterDate,
            global::System.Collections.Generic.IList<global::G.PreRecordedControllerGetPreRecordedJobsV2Statu>? status,
            object? customMetadata);
        partial void PreparePreRecordedControllerGetPreRecordedJobsV2Request(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            int? offset,
            int? limit,
            global::System.DateTime? date,
            global::System.DateTime? beforeDate,
            global::System.DateTime? afterDate,
            global::System.Collections.Generic.IList<global::G.PreRecordedControllerGetPreRecordedJobsV2Statu>? status,
            object? customMetadata);
        partial void ProcessPreRecordedControllerGetPreRecordedJobsV2Response(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessPreRecordedControllerGetPreRecordedJobsV2ResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Get pre recorded jobs based on query parameters
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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.ListPreRecordedResponse> PreRecordedControllerGetPreRecordedJobsV2Async(
            int? offset = default,
            int? limit = default,
            global::System.DateTime? date = default,
            global::System.DateTime? beforeDate = default,
            global::System.DateTime? afterDate = default,
            global::System.Collections.Generic.IList<global::G.PreRecordedControllerGetPreRecordedJobsV2Statu>? status = default,
            object? customMetadata = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PreparePreRecordedControllerGetPreRecordedJobsV2Arguments(
                httpClient: HttpClient,
                offset: ref offset,
                limit: ref limit,
                date: ref date,
                beforeDate: ref beforeDate,
                afterDate: ref afterDate,
                status: status,
                customMetadata: customMetadata);

            var __pathBuilder = new global::G.PathBuilder(
                path: "/v2/pre-recorded",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddOptionalParameter("offset", offset?.ToString())
                .AddOptionalParameter("limit", limit?.ToString())
                .AddOptionalParameter("date", date?.ToString("yyyy-MM-ddTHH:mm:ssZ"))
                .AddOptionalParameter("before_date", beforeDate?.ToString("yyyy-MM-ddTHH:mm:ssZ"))
                .AddOptionalParameter("after_date", afterDate?.ToString("yyyy-MM-ddTHH:mm:ssZ"))
                .AddOptionalParameter("status", status, selector: static x => x.ToValueString(), delimiter: ",", explode: true)
                .AddOptionalParameter("custom_metadata", customMetadata?.ToString()) 
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
            PreparePreRecordedControllerGetPreRecordedJobsV2Request(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                offset: offset,
                limit: limit,
                date: date,
                beforeDate: beforeDate,
                afterDate: afterDate,
                status: status,
                customMetadata: customMetadata);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessPreRecordedControllerGetPreRecordedJobsV2Response(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // You don't have the permissions to access pre recorded jobs
            if ((int)__response.StatusCode == 401)
            {
                string? __content_401 = null;
                global::System.Exception? __exception_401 = null;
                global::G.UnauthorizedErrorResponse? __value_401 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_401 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_401 = global::G.UnauthorizedErrorResponse.FromJson(__content_401, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_401 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_401 = global::G.UnauthorizedErrorResponse.FromJson(__content_401, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_401 = __ex;
                }

                throw new global::G.ApiException<global::G.UnauthorizedErrorResponse>(
                    message: __content_401 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_401,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_401,
                    ResponseObject = __value_401,
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
                ProcessPreRecordedControllerGetPreRecordedJobsV2ResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.ListPreRecordedResponse.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::G.ListPreRecordedResponse.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
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