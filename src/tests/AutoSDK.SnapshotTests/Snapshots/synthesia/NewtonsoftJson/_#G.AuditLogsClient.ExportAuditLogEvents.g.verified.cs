//HintName: G.AuditLogsClient.ExportAuditLogEvents.g.cs

#nullable enable

namespace G
{
    public partial class AuditLogsClient
    {


        private static readonly global::G.EndPointSecurityRequirement s_ExportAuditLogEventsSecurityRequirement0 =
            new global::G.EndPointSecurityRequirement
            {
                Authorizations = new global::G.EndPointAuthorizationRequirement[]
                {                    new global::G.EndPointAuthorizationRequirement
                    {
                        Type = "ApiKey",
                        Location = "Header",
                        Name = "Authorization",
                        FriendlyName = "ApiKeyInHeader",
                    },
                },
            };
        private static readonly global::G.EndPointSecurityRequirement[] s_ExportAuditLogEventsSecurityRequirements =
            new global::G.EndPointSecurityRequirement[]
            {                s_ExportAuditLogEventsSecurityRequirement0,
            };
        partial void PrepareExportAuditLogEventsArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::G.AuditLogsExportRequest request);
        partial void PrepareExportAuditLogEventsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::G.AuditLogsExportRequest request);
        partial void ProcessExportAuditLogEventsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessExportAuditLogEventsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref byte[] content);

        /// <summary>
        /// Export audit log events as CSV<br/>
        /// Export audit log events for a workspace or organization as a CSV file.<br/>
        /// Exactly one of workspaceId or organizationId must be provided.<br/>
        /// Supports the same filtering options as the query endpoints:<br/>
        /// - Date range (Unix timestamps)<br/>
        /// - Multiple actions<br/>
        /// - Multiple actor IDs<br/>
        /// - Target ID<br/>
        /// **Export limits:**<br/>
        /// - Maximum 10,000 events per export<br/>
        /// - If more events match the filters, the export will be truncated<br/>
        /// - Truncated exports include "_TRUNCATED" in the filename<br/>
        /// **Example requests:**<br/>
        /// - Export all events for an organization:<br/>
        ///   {"organizationId": "12345678-1234-1234-1234-123456789abc"}<br/>
        /// - Export filtered events:<br/>
        ///   {"organizationId": "12345678-1234-1234-1234-123456789abc",<br/>
        ///    "startDate": 1704067200, "endDate": 1735689599,<br/>
        ///    "actions": ["billing.credits.consumed", "video.created"]}<br/>
        /// - Export by workspace with filters:<br/>
        ///   {"workspaceId": "12345678-1234-1234-1234-123456789abc",<br/>
        ///    "actorIds": ["user-123", "user-456"]}<br/>
        /// This endpoint is rate-limited and usage is tracked against your API quota.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<byte[]> ExportAuditLogEventsAsync(

            global::G.AuditLogsExportRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await ExportAuditLogEventsAsResponseAsync(

                request: request,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
        /// <summary>
        /// Export audit log events as CSV<br/>
        /// Export audit log events for a workspace or organization as a CSV file.<br/>
        /// Exactly one of workspaceId or organizationId must be provided.<br/>
        /// Supports the same filtering options as the query endpoints:<br/>
        /// - Date range (Unix timestamps)<br/>
        /// - Multiple actions<br/>
        /// - Multiple actor IDs<br/>
        /// - Target ID<br/>
        /// **Export limits:**<br/>
        /// - Maximum 10,000 events per export<br/>
        /// - If more events match the filters, the export will be truncated<br/>
        /// - Truncated exports include "_TRUNCATED" in the filename<br/>
        /// **Example requests:**<br/>
        /// - Export all events for an organization:<br/>
        ///   {"organizationId": "12345678-1234-1234-1234-123456789abc"}<br/>
        /// - Export filtered events:<br/>
        ///   {"organizationId": "12345678-1234-1234-1234-123456789abc",<br/>
        ///    "startDate": 1704067200, "endDate": 1735689599,<br/>
        ///    "actions": ["billing.credits.consumed", "video.created"]}<br/>
        /// - Export by workspace with filters:<br/>
        ///   {"workspaceId": "12345678-1234-1234-1234-123456789abc",<br/>
        ///    "actorIds": ["user-123", "user-456"]}<br/>
        /// This endpoint is rate-limited and usage is tracked against your API quota.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.AutoSDKHttpResponse<byte[]>> ExportAuditLogEventsAsResponseAsync(

            global::G.AuditLogsExportRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareExportAuditLogEventsArguments(
                httpClient: HttpClient,
                request: request);


            var __authorizations = global::G.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_ExportAuditLogEventsSecurityRequirements,
                operationName: "ExportAuditLogEventsAsync");

            var __pathBuilder = new global::G.PathBuilder(
                path: "/v2/auditLogs/export",
                baseUri: HttpClient.BaseAddress);
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in __authorizations)
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
            var __httpRequestContentBody = request.ToJson(JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareExportAuditLogEventsRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessExportAuditLogEventsResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // Invalid request parameters
            if ((int)__response.StatusCode == 400)
            {
                string? __content_400 = null;
                global::System.Exception? __exception_400 = null;
                global::G.Error? __value_400 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_400 = global::G.Error.FromJson(__content_400, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_400 = global::G.Error.FromJson(__content_400, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_400 = __ex;
                }

                throw new global::G.ApiException<global::G.Error>(
                    message: __content_400 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_400,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_400,
                    ResponseObject = __value_400,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // Forbidden - Wrong API key or Public API access disabled
            if ((int)__response.StatusCode == 403)
            {
                string? __content_403 = null;
                global::System.Exception? __exception_403 = null;
                global::G.Error? __value_403 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_403 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_403 = global::G.Error.FromJson(__content_403, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_403 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_403 = global::G.Error.FromJson(__content_403, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_403 = __ex;
                }

                throw new global::G.ApiException<global::G.Error>(
                    message: __content_403 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_403,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_403,
                    ResponseObject = __value_403,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // Workspace or organization not found
            if ((int)__response.StatusCode == 404)
            {
                string? __content_404 = null;
                global::System.Exception? __exception_404 = null;
                global::G.Error? __value_404 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_404 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_404 = global::G.Error.FromJson(__content_404, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_404 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_404 = global::G.Error.FromJson(__content_404, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_404 = __ex;
                }

                throw new global::G.ApiException<global::G.Error>(
                    message: __content_404 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_404,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_404,
                    ResponseObject = __value_404,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // Rate limit exceeded
            if ((int)__response.StatusCode == 429)
            {
                string? __content_429 = null;
                global::System.Exception? __exception_429 = null;
                global::G.Error? __value_429 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_429 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_429 = global::G.Error.FromJson(__content_429, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_429 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_429 = global::G.Error.FromJson(__content_429, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_429 = __ex;
                }

                throw new global::G.ApiException<global::G.Error>(
                    message: __content_429 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_429,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_429,
                    ResponseObject = __value_429,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // Unexpected Server error
            if (!__response.IsSuccessStatusCode)
            {
                string? __content_default = null;
                global::System.Exception? __exception_default = null;
                global::G.Error? __value_default = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_default = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_default = global::G.Error.FromJson(__content_default, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_default = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_default = global::G.Error.FromJson(__content_default, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_default = __ex;
                }

                throw new global::G.ApiException<global::G.Error>(
                    message: __content_default ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_default,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_default,
                    ResponseObject = __value_default,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }

            if (ReadResponseAsString)
            {
                var __content = await __response.Content.ReadAsByteArrayAsync(
#if NET5_0_OR_GREATER
                    cancellationToken
#endif
                ).ConfigureAwait(false);

                ProcessExportAuditLogEventsResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return new global::G.AutoSDKHttpResponse<byte[]>(
                        statusCode: __response.StatusCode,
                        headers: global::G.AutoSDKHttpResponse.CreateHeaders(__response),
                        body: __content);
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
            else
            {
                try
                {
                    __response.EnsureSuccessStatusCode();
                    var __content = await __response.Content.ReadAsByteArrayAsync(
#if NET5_0_OR_GREATER
                        cancellationToken
#endif
                    ).ConfigureAwait(false);

                    return new global::G.AutoSDKHttpResponse<byte[]>(
                        statusCode: __response.StatusCode,
                        headers: global::G.AutoSDKHttpResponse.CreateHeaders(__response),
                        body: __content);
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
        /// Export audit log events as CSV<br/>
        /// Export audit log events for a workspace or organization as a CSV file.<br/>
        /// Exactly one of workspaceId or organizationId must be provided.<br/>
        /// Supports the same filtering options as the query endpoints:<br/>
        /// - Date range (Unix timestamps)<br/>
        /// - Multiple actions<br/>
        /// - Multiple actor IDs<br/>
        /// - Target ID<br/>
        /// **Export limits:**<br/>
        /// - Maximum 10,000 events per export<br/>
        /// - If more events match the filters, the export will be truncated<br/>
        /// - Truncated exports include "_TRUNCATED" in the filename<br/>
        /// **Example requests:**<br/>
        /// - Export all events for an organization:<br/>
        ///   {"organizationId": "12345678-1234-1234-1234-123456789abc"}<br/>
        /// - Export filtered events:<br/>
        ///   {"organizationId": "12345678-1234-1234-1234-123456789abc",<br/>
        ///    "startDate": 1704067200, "endDate": 1735689599,<br/>
        ///    "actions": ["billing.credits.consumed", "video.created"]}<br/>
        /// - Export by workspace with filters:<br/>
        ///   {"workspaceId": "12345678-1234-1234-1234-123456789abc",<br/>
        ///    "actorIds": ["user-123", "user-456"]}<br/>
        /// This endpoint is rate-limited and usage is tracked against your API quota.
        /// </summary>
        /// <param name="workspaceId">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="organizationId">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="startDate">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="endDate">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="actions">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="actorIds">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="targetId">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<byte[]> ExportAuditLogEventsAsync(
            global::System.Guid? workspaceId = default,
            global::System.Guid? organizationId = default,
            int? startDate = default,
            int? endDate = default,
            global::System.Collections.Generic.IList<string>? actions = default,
            global::System.Collections.Generic.IList<string>? actorIds = default,
            string? targetId = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.AuditLogsExportRequest
            {
                WorkspaceId = workspaceId,
                OrganizationId = organizationId,
                StartDate = startDate,
                EndDate = endDate,
                Actions = actions,
                ActorIds = actorIds,
                TargetId = targetId,
            };

            return await ExportAuditLogEventsAsync(
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}