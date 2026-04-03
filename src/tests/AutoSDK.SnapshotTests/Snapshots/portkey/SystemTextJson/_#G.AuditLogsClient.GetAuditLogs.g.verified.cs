//HintName: G.AuditLogsClient.GetAuditLogs.g.cs

#nullable enable

namespace G
{
    public partial class AuditLogsClient
    {
        partial void PrepareGetAuditLogsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string startTime,
            ref string endTime,
            ref string organisationId,
            ref global::G.GetAuditLogsMethod? method,
            ref string? uri,
            ref string? requestId,
            ref string? userId,
            ref global::G.GetAuditLogsUserType? userType,
            ref string? workspaceId,
            ref int? responseStatusCode,
            ref string? resourceType,
            ref string? action,
            ref string? clientIp,
            ref string? country,
            ref int? currentPage,
            ref int? pageSize);
        partial void PrepareGetAuditLogsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string startTime,
            string endTime,
            string organisationId,
            global::G.GetAuditLogsMethod? method,
            string? uri,
            string? requestId,
            string? userId,
            global::G.GetAuditLogsUserType? userType,
            string? workspaceId,
            int? responseStatusCode,
            string? resourceType,
            string? action,
            string? clientIp,
            string? country,
            int? currentPage,
            int? pageSize);
        partial void ProcessGetAuditLogsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGetAuditLogsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Get Audit Logs
        /// </summary>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <param name="organisationId"></param>
        /// <param name="method"></param>
        /// <param name="uri"></param>
        /// <param name="requestId"></param>
        /// <param name="userId"></param>
        /// <param name="userType"></param>
        /// <param name="workspaceId"></param>
        /// <param name="responseStatusCode"></param>
        /// <param name="resourceType"></param>
        /// <param name="action"></param>
        /// <param name="clientIp"></param>
        /// <param name="country"></param>
        /// <param name="currentPage"></param>
        /// <param name="pageSize"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.AuditLogObjectList> GetAuditLogsAsync(
            string startTime,
            string endTime,
            string organisationId,
            global::G.GetAuditLogsMethod? method = default,
            string? uri = default,
            string? requestId = default,
            string? userId = default,
            global::G.GetAuditLogsUserType? userType = default,
            string? workspaceId = default,
            int? responseStatusCode = default,
            string? resourceType = default,
            string? action = default,
            string? clientIp = default,
            string? country = default,
            int? currentPage = default,
            int? pageSize = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareGetAuditLogsArguments(
                httpClient: HttpClient,
                startTime: ref startTime,
                endTime: ref endTime,
                organisationId: ref organisationId,
                method: ref method,
                uri: ref uri,
                requestId: ref requestId,
                userId: ref userId,
                userType: ref userType,
                workspaceId: ref workspaceId,
                responseStatusCode: ref responseStatusCode,
                resourceType: ref resourceType,
                action: ref action,
                clientIp: ref clientIp,
                country: ref country,
                currentPage: ref currentPage,
                pageSize: ref pageSize);

            var __pathBuilder = new global::G.PathBuilder(
                path: "/audit-logs",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddRequiredParameter("start_time", startTime)
                .AddRequiredParameter("end_time", endTime)
                .AddRequiredParameter("organisation_id", organisationId)
                .AddOptionalParameter("method", method?.ToValueString())
                .AddOptionalParameter("uri", uri)
                .AddOptionalParameter("request_id", requestId)
                .AddOptionalParameter("user_id", userId)
                .AddOptionalParameter("user_type", userType?.ToValueString())
                .AddOptionalParameter("workspace_id", workspaceId)
                .AddOptionalParameter("response_status_code", responseStatusCode?.ToString())
                .AddOptionalParameter("resource_type", resourceType)
                .AddOptionalParameter("action", action)
                .AddOptionalParameter("client_ip", clientIp)
                .AddOptionalParameter("country", country)
                .AddOptionalParameter("current_page", currentPage?.ToString())
                .AddOptionalParameter("page_size", pageSize?.ToString()) 
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
            PrepareGetAuditLogsRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                startTime: startTime,
                endTime: endTime,
                organisationId: organisationId,
                method: method,
                uri: uri,
                requestId: requestId,
                userId: userId,
                userType: userType,
                workspaceId: workspaceId,
                responseStatusCode: responseStatusCode,
                resourceType: resourceType,
                action: action,
                clientIp: clientIp,
                country: country,
                currentPage: currentPage,
                pageSize: pageSize);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessGetAuditLogsResponse(
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
                ProcessGetAuditLogsResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.AuditLogObjectList.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::G.AuditLogObjectList.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
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