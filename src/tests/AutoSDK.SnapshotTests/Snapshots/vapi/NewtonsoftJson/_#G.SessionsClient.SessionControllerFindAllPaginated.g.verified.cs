//HintName: G.SessionsClient.SessionControllerFindAllPaginated.g.cs

#nullable enable

namespace G
{
    public partial class SessionsClient
    {


        private static readonly global::G.EndPointSecurityRequirement s_SessionControllerFindAllPaginatedSecurityRequirement0 =
            new global::G.EndPointSecurityRequirement
            {
                Authorizations = new global::G.EndPointAuthorizationRequirement[]
                {                    new global::G.EndPointAuthorizationRequirement
                    {
                        Type = "Http",
                        Location = "Header",
                        Name = "Bearer",
                        FriendlyName = "Bearer",
                    },
                },
            };
        private static readonly global::G.EndPointSecurityRequirement[] s_SessionControllerFindAllPaginatedSecurityRequirements =
            new global::G.EndPointSecurityRequirement[]
            {                s_SessionControllerFindAllPaginatedSecurityRequirement0,
            };
        partial void PrepareSessionControllerFindAllPaginatedArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? id,
            ref string? name,
            ref string? assistantId,
            ref string? assistantIdAny,
            ref string? squadId,
            ref string? workflowId,
            ref bool? numberE164CheckEnabled,
            ref string? extension,
            object? assistantOverrides,
            ref string? number,
            ref string? sipUri,
            ref string? customerName,
            ref string? email,
            ref string? externalId,
            ref string? customerNumberAny,
            ref string? phoneNumberId,
            global::System.Collections.Generic.IList<string>? phoneNumberIdAny,
            ref double? page,
            ref global::G.SessionControllerFindAllPaginatedSortOrder? sortOrder,
            ref double? limit,
            ref global::System.DateTime? createdAtGt,
            ref global::System.DateTime? createdAtLt,
            ref global::System.DateTime? createdAtGe,
            ref global::System.DateTime? createdAtLe,
            ref global::System.DateTime? updatedAtGt,
            ref global::System.DateTime? updatedAtLt,
            ref global::System.DateTime? updatedAtGe,
            ref global::System.DateTime? updatedAtLe);
        partial void PrepareSessionControllerFindAllPaginatedRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? id,
            string? name,
            string? assistantId,
            string? assistantIdAny,
            string? squadId,
            string? workflowId,
            bool? numberE164CheckEnabled,
            string? extension,
            object? assistantOverrides,
            string? number,
            string? sipUri,
            string? customerName,
            string? email,
            string? externalId,
            string? customerNumberAny,
            string? phoneNumberId,
            global::System.Collections.Generic.IList<string>? phoneNumberIdAny,
            double? page,
            global::G.SessionControllerFindAllPaginatedSortOrder? sortOrder,
            double? limit,
            global::System.DateTime? createdAtGt,
            global::System.DateTime? createdAtLt,
            global::System.DateTime? createdAtGe,
            global::System.DateTime? createdAtLe,
            global::System.DateTime? updatedAtGt,
            global::System.DateTime? updatedAtLt,
            global::System.DateTime? updatedAtGe,
            global::System.DateTime? updatedAtLe);
        partial void ProcessSessionControllerFindAllPaginatedResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessSessionControllerFindAllPaginatedResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List Sessions
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="assistantId"></param>
        /// <param name="assistantIdAny">
        /// Example: assistant-1,assistant-2,assistant-3
        /// </param>
        /// <param name="squadId"></param>
        /// <param name="workflowId"></param>
        /// <param name="numberE164CheckEnabled">
        /// Default Value: true
        /// </param>
        /// <param name="extension">
        /// Example: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="assistantOverrides"></param>
        /// <param name="number"></param>
        /// <param name="sipUri"></param>
        /// <param name="customerName"></param>
        /// <param name="email"></param>
        /// <param name="externalId"></param>
        /// <param name="customerNumberAny">
        /// Example: +1234567890,+0987654321
        /// </param>
        /// <param name="phoneNumberId"></param>
        /// <param name="phoneNumberIdAny"></param>
        /// <param name="page"></param>
        /// <param name="sortOrder"></param>
        /// <param name="limit"></param>
        /// <param name="createdAtGt"></param>
        /// <param name="createdAtLt"></param>
        /// <param name="createdAtGe"></param>
        /// <param name="createdAtLe"></param>
        /// <param name="updatedAtGt"></param>
        /// <param name="updatedAtLt"></param>
        /// <param name="updatedAtGe"></param>
        /// <param name="updatedAtLe"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.SessionPaginatedResponse> SessionControllerFindAllPaginatedAsync(
            string? id = default,
            string? name = default,
            string? assistantId = default,
            string? assistantIdAny = default,
            string? squadId = default,
            string? workflowId = default,
            bool? numberE164CheckEnabled = default,
            string? extension = default,
            object? assistantOverrides = default,
            string? number = default,
            string? sipUri = default,
            string? customerName = default,
            string? email = default,
            string? externalId = default,
            string? customerNumberAny = default,
            string? phoneNumberId = default,
            global::System.Collections.Generic.IList<string>? phoneNumberIdAny = default,
            double? page = default,
            global::G.SessionControllerFindAllPaginatedSortOrder? sortOrder = default,
            double? limit = default,
            global::System.DateTime? createdAtGt = default,
            global::System.DateTime? createdAtLt = default,
            global::System.DateTime? createdAtGe = default,
            global::System.DateTime? createdAtLe = default,
            global::System.DateTime? updatedAtGt = default,
            global::System.DateTime? updatedAtLt = default,
            global::System.DateTime? updatedAtGe = default,
            global::System.DateTime? updatedAtLe = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareSessionControllerFindAllPaginatedArguments(
                httpClient: HttpClient,
                id: ref id,
                name: ref name,
                assistantId: ref assistantId,
                assistantIdAny: ref assistantIdAny,
                squadId: ref squadId,
                workflowId: ref workflowId,
                numberE164CheckEnabled: ref numberE164CheckEnabled,
                extension: ref extension,
                assistantOverrides: assistantOverrides,
                number: ref number,
                sipUri: ref sipUri,
                customerName: ref customerName,
                email: ref email,
                externalId: ref externalId,
                customerNumberAny: ref customerNumberAny,
                phoneNumberId: ref phoneNumberId,
                phoneNumberIdAny: phoneNumberIdAny,
                page: ref page,
                sortOrder: ref sortOrder,
                limit: ref limit,
                createdAtGt: ref createdAtGt,
                createdAtLt: ref createdAtLt,
                createdAtGe: ref createdAtGe,
                createdAtLe: ref createdAtLe,
                updatedAtGt: ref updatedAtGt,
                updatedAtLt: ref updatedAtLt,
                updatedAtGe: ref updatedAtGe,
                updatedAtLe: ref updatedAtLe);


            var __authorizations = global::G.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_SessionControllerFindAllPaginatedSecurityRequirements,
                operationName: "SessionControllerFindAllPaginatedAsync");

            var sortOrderValue = sortOrder switch
            {
                global::G.SessionControllerFindAllPaginatedSortOrder.Asc => "ASC",
                global::G.SessionControllerFindAllPaginatedSortOrder.Desc => "DESC",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            using var __timeoutCancellationTokenSource = global::G.AutoSDKRequestOptionsSupport.CreateTimeoutCancellationTokenSource(
                clientOptions: Options,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken);
            var __effectiveCancellationToken = __timeoutCancellationTokenSource?.Token ?? cancellationToken;
            var __effectiveReadResponseAsString = global::G.AutoSDKRequestOptionsSupport.GetReadResponseAsString(
                clientOptions: Options,
                requestOptions: requestOptions,
                fallbackValue: ReadResponseAsString);
            var __maxAttempts = global::G.AutoSDKRequestOptionsSupport.GetMaxAttempts(
                clientOptions: Options,
                requestOptions: requestOptions,
                supportsRetry: true);

            global::System.Net.Http.HttpRequestMessage __CreateHttpRequest()
            {
                            var __pathBuilder = new global::G.PathBuilder(
                                path: "/session",
                                baseUri: HttpClient.BaseAddress); 
                            __pathBuilder
                                .AddOptionalParameter("id", id)
                                .AddOptionalParameter("name", name)
                                .AddOptionalParameter("assistantId", assistantId)
                                .AddOptionalParameter("assistantIdAny", assistantIdAny)
                                .AddOptionalParameter("squadId", squadId)
                                .AddOptionalParameter("workflowId", workflowId)
                                .AddOptionalParameter("numberE164CheckEnabled", numberE164CheckEnabled?.ToString().ToLowerInvariant())
                                .AddOptionalParameter("extension", extension)
                                .AddOptionalParameter("assistantOverrides", assistantOverrides?.ToString())
                                .AddOptionalParameter("number", number)
                                .AddOptionalParameter("sipUri", sipUri)
                                .AddOptionalParameter("customerName", customerName)
                                .AddOptionalParameter("email", email)
                                .AddOptionalParameter("externalId", externalId)
                                .AddOptionalParameter("customerNumberAny", customerNumberAny)
                                .AddOptionalParameter("phoneNumberId", phoneNumberId)
                                .AddOptionalParameter("phoneNumberIdAny", phoneNumberIdAny, delimiter: ",", explode: true)
                                .AddOptionalParameter("page", page?.ToString())
                                .AddOptionalParameter("sortOrder", sortOrder?.ToValueString())
                                .AddOptionalParameter("limit", limit?.ToString())
                                .AddOptionalParameter("createdAtGt", createdAtGt?.ToString("yyyy-MM-ddTHH:mm:ssZ"))
                                .AddOptionalParameter("createdAtLt", createdAtLt?.ToString("yyyy-MM-ddTHH:mm:ssZ"))
                                .AddOptionalParameter("createdAtGe", createdAtGe?.ToString("yyyy-MM-ddTHH:mm:ssZ"))
                                .AddOptionalParameter("createdAtLe", createdAtLe?.ToString("yyyy-MM-ddTHH:mm:ssZ"))
                                .AddOptionalParameter("updatedAtGt", updatedAtGt?.ToString("yyyy-MM-ddTHH:mm:ssZ"))
                                .AddOptionalParameter("updatedAtLt", updatedAtLt?.ToString("yyyy-MM-ddTHH:mm:ssZ"))
                                .AddOptionalParameter("updatedAtGe", updatedAtGe?.ToString("yyyy-MM-ddTHH:mm:ssZ"))
                                .AddOptionalParameter("updatedAtLe", updatedAtLe?.ToString("yyyy-MM-ddTHH:mm:ssZ")) 
                                ;
                            var __path = __pathBuilder.ToString();
                __path = global::G.AutoSDKRequestOptionsSupport.AppendQueryParameters(
                    path: __path,
                    clientParameters: Options.QueryParameters,
                    requestParameters: requestOptions?.QueryParameters);
                var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                    method: global::System.Net.Http.HttpMethod.Get,
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
                global::G.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PrepareSessionControllerFindAllPaginatedRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    id: id,
                    name: name,
                    assistantId: assistantId,
                    assistantIdAny: assistantIdAny,
                    squadId: squadId,
                    workflowId: workflowId,
                    numberE164CheckEnabled: numberE164CheckEnabled,
                    extension: extension,
                    assistantOverrides: assistantOverrides,
                    number: number,
                    sipUri: sipUri,
                    customerName: customerName,
                    email: email,
                    externalId: externalId,
                    customerNumberAny: customerNumberAny,
                    phoneNumberId: phoneNumberId,
                    phoneNumberIdAny: phoneNumberIdAny,
                    page: page,
                    sortOrder: sortOrder,
                    limit: limit,
                    createdAtGt: createdAtGt,
                    createdAtLt: createdAtLt,
                    createdAtGe: createdAtGe,
                    createdAtLe: createdAtLe,
                    updatedAtGt: updatedAtGt,
                    updatedAtLt: updatedAtLt,
                    updatedAtGe: updatedAtGe,
                    updatedAtLe: updatedAtLe);

                return __httpRequest;
            }

            global::System.Net.Http.HttpRequestMessage? __httpRequest = null;
            global::System.Net.Http.HttpResponseMessage? __response = null;
            var __attemptNumber = 0;
            try
            {
                for (var __attempt = 1; __attempt <= __maxAttempts; __attempt++)
                {
                    __attemptNumber = __attempt;
                    __httpRequest = __CreateHttpRequest();
                    await global::G.AutoSDKRequestOptionsSupport.OnBeforeRequestAsync(
                            clientOptions: Options,
                            context: global::G.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "SessionControllerFindAllPaginated",
                                methodName: "SessionControllerFindAllPaginatedAsync",
                                pathTemplate: "\"/session\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                    try
                    {
                        __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                    }
                    catch (global::System.Net.Http.HttpRequestException __exception)
                    {
                        var __willRetry = __attempt < __maxAttempts && !__effectiveCancellationToken.IsCancellationRequested;
                        await global::G.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::G.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "SessionControllerFindAllPaginated",
                                methodName: "SessionControllerFindAllPaginatedAsync",
                                pathTemplate: "\"/session\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: __exception,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: __willRetry,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        if (!__willRetry)
                        {
                            throw;
                        }

                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::G.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    if (__response != null &&
                        __attempt < __maxAttempts &&
                        global::G.AutoSDKRequestOptionsSupport.ShouldRetryStatusCode(__response.StatusCode))
                    {
                        await global::G.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::G.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "SessionControllerFindAllPaginated",
                                methodName: "SessionControllerFindAllPaginatedAsync",
                                pathTemplate: "\"/session\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: true,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        __response.Dispose();
                        __response = null;
                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::G.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    break;
                }

                if (__response == null)
                {
                    throw new global::System.InvalidOperationException("No response received.");
                }

                using (__response)
                {

                ProcessResponse(
                    client: HttpClient,
                    response: __response);
                ProcessSessionControllerFindAllPaginatedResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::G.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::G.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "SessionControllerFindAllPaginated",
                                methodName: "SessionControllerFindAllPaginatedAsync",
                                pathTemplate: "\"/session\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                else
                {
                    await global::G.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::G.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "SessionControllerFindAllPaginated",
                                methodName: "SessionControllerFindAllPaginatedAsync",
                                pathTemplate: "\"/session\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }

                            if (__effectiveReadResponseAsString)
                            {
                                var __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                    __effectiveCancellationToken
                #endif
                                ).ConfigureAwait(false);

                                ProcessResponseContent(
                                    client: HttpClient,
                                    response: __response,
                                    content: ref __content);
                                ProcessSessionControllerFindAllPaginatedResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    return
                                        global::G.SessionPaginatedResponse.FromJson(__content, JsonSerializerOptions) ??
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
                                        __effectiveCancellationToken
                #endif
                                    ).ConfigureAwait(false);

                                    return
                                        await global::G.SessionPaginatedResponse.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                }
                                catch (global::System.Exception __ex)
                                {
                                    string? __content = null;
                                    try
                                    {
                                        __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                            __effectiveCancellationToken
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
            finally
            {
                __httpRequest?.Dispose();
            }
        }
    }
}