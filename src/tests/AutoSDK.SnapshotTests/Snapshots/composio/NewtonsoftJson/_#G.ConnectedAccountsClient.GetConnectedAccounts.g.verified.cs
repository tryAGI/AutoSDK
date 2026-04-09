//HintName: G.ConnectedAccountsClient.GetConnectedAccounts.g.cs

#nullable enable

namespace G
{
    public partial class ConnectedAccountsClient
    {


        private static readonly global::G.EndPointSecurityRequirement s_GetConnectedAccountsSecurityRequirement0 =
            new global::G.EndPointSecurityRequirement
            {
                Authorizations = new global::G.EndPointAuthorizationRequirement[]
                {                    new global::G.EndPointAuthorizationRequirement
                    {
                        Type = "ApiKey",
                        Location = "Header",
                        Name = "x-api-key",
                        FriendlyName = "ApiKeyAuth",
                    },
                },
            };

        private static readonly global::G.EndPointSecurityRequirement s_GetConnectedAccountsSecurityRequirement1 =
            new global::G.EndPointSecurityRequirement
            {
                Authorizations = new global::G.EndPointAuthorizationRequirement[]
                {                    new global::G.EndPointAuthorizationRequirement
                    {
                        Type = "ApiKey",
                        Location = "Header",
                        Name = "x-user-api-key",
                        FriendlyName = "UserApiKeyAuth",
                    },
                },
            };

        private static readonly global::G.EndPointSecurityRequirement s_GetConnectedAccountsSecurityRequirement2 =
            new global::G.EndPointSecurityRequirement
            {
                Authorizations = new global::G.EndPointAuthorizationRequirement[]
                {                    new global::G.EndPointAuthorizationRequirement
                    {
                        Type = "ApiKey",
                        Location = "Cookie",
                        Name = "authToken",
                        FriendlyName = "ApiKeyInCookie",
                    },
                },
            };
        private static readonly global::G.EndPointSecurityRequirement[] s_GetConnectedAccountsSecurityRequirements =
            new global::G.EndPointSecurityRequirement[]
            {                s_GetConnectedAccountsSecurityRequirement0,
                s_GetConnectedAccountsSecurityRequirement1,
                s_GetConnectedAccountsSecurityRequirement2,
            };
        partial void PrepareGetConnectedAccountsArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Collections.Generic.IList<string>? toolkitSlugs,
            global::System.Collections.Generic.IList<global::G.GetConnectedAccountsStatuse>? statuses,
            ref string? cursor,
            ref double? limit,
            global::System.Collections.Generic.IList<string>? userIds,
            global::System.Collections.Generic.IList<string>? authConfigIds,
            global::System.Collections.Generic.IList<string>? connectedAccountIds,
            ref global::G.GetConnectedAccountsOrderBy? orderBy,
            ref global::G.GetConnectedAccountsOrderDirection? orderDirection);
        partial void PrepareGetConnectedAccountsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::System.Collections.Generic.IList<string>? toolkitSlugs,
            global::System.Collections.Generic.IList<global::G.GetConnectedAccountsStatuse>? statuses,
            string? cursor,
            double? limit,
            global::System.Collections.Generic.IList<string>? userIds,
            global::System.Collections.Generic.IList<string>? authConfigIds,
            global::System.Collections.Generic.IList<string>? connectedAccountIds,
            global::G.GetConnectedAccountsOrderBy? orderBy,
            global::G.GetConnectedAccountsOrderDirection? orderDirection);
        partial void ProcessGetConnectedAccountsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGetConnectedAccountsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List connected accounts with optional filters<br/>
        /// Retrieves all connected accounts for your project. Connected accounts represent authenticated user connections to external services (e.g., a user's Gmail account, Slack workspace). Filter by toolkit, status, user ID, or auth config to find specific connections.
        /// </summary>
        /// <param name="toolkitSlugs">
        /// The toolkit slugs of the connected accounts
        /// </param>
        /// <param name="statuses">
        /// The status of the connected account
        /// </param>
        /// <param name="cursor">
        /// The cursor to paginate through the connected accounts
        /// </param>
        /// <param name="limit">
        /// The limit of the connected accounts to return
        /// </param>
        /// <param name="userIds">
        /// The user ids of the connected accounts
        /// </param>
        /// <param name="authConfigIds">
        /// The auth config ids of the connected accounts
        /// </param>
        /// <param name="connectedAccountIds">
        /// The connected account ids to filter by
        /// </param>
        /// <param name="orderBy">
        /// The order by of the connected accounts<br/>
        /// Default Value: created_at
        /// </param>
        /// <param name="orderDirection">
        /// The order direction of the connected accounts<br/>
        /// Default Value: desc
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.GetConnectedAccountsResponse> GetConnectedAccountsAsync(
            global::System.Collections.Generic.IList<string>? toolkitSlugs = default,
            global::System.Collections.Generic.IList<global::G.GetConnectedAccountsStatuse>? statuses = default,
            string? cursor = default,
            double? limit = default,
            global::System.Collections.Generic.IList<string>? userIds = default,
            global::System.Collections.Generic.IList<string>? authConfigIds = default,
            global::System.Collections.Generic.IList<string>? connectedAccountIds = default,
            global::G.GetConnectedAccountsOrderBy? orderBy = default,
            global::G.GetConnectedAccountsOrderDirection? orderDirection = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareGetConnectedAccountsArguments(
                httpClient: HttpClient,
                toolkitSlugs: toolkitSlugs,
                statuses: statuses,
                cursor: ref cursor,
                limit: ref limit,
                userIds: userIds,
                authConfigIds: authConfigIds,
                connectedAccountIds: connectedAccountIds,
                orderBy: ref orderBy,
                orderDirection: ref orderDirection);


            var __authorizations = global::G.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_GetConnectedAccountsSecurityRequirements,
                operationName: "GetConnectedAccountsAsync");

            var orderByValue = orderBy switch
            {
                global::G.GetConnectedAccountsOrderBy.CreatedAt => "created_at",
                global::G.GetConnectedAccountsOrderBy.UpdatedAt => "updated_at",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var orderDirectionValue = orderDirection switch
            {
                global::G.GetConnectedAccountsOrderDirection.Asc => "asc",
                global::G.GetConnectedAccountsOrderDirection.Desc => "desc",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var __pathBuilder = new global::G.PathBuilder(
                path: "/api/v3/connected_accounts",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddOptionalParameter("toolkit_slugs", toolkitSlugs, delimiter: ",", explode: true)
                .AddOptionalParameter("statuses", statuses, selector: static x => x.ToValueString(), delimiter: ",", explode: true)
                .AddOptionalParameter("cursor", cursor)
                .AddOptionalParameter("limit", limit?.ToString())
                .AddOptionalParameter("user_ids", userIds, delimiter: ",", explode: true)
                .AddOptionalParameter("auth_config_ids", authConfigIds, delimiter: ",", explode: true)
                .AddOptionalParameter("connected_account_ids", connectedAccountIds, delimiter: ",", explode: true)
                .AddOptionalParameter("order_by", orderBy?.ToValueString())
                .AddOptionalParameter("order_direction", orderDirection?.ToValueString()) 
                ; 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
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

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareGetConnectedAccountsRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                toolkitSlugs: toolkitSlugs,
                statuses: statuses,
                cursor: cursor,
                limit: limit,
                userIds: userIds,
                authConfigIds: authConfigIds,
                connectedAccountIds: connectedAccountIds,
                orderBy: orderBy,
                orderDirection: orderDirection);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessGetConnectedAccountsResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // Bad request
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
            // Unauthorized
            if ((int)__response.StatusCode == 401)
            {
                string? __content_401 = null;
                global::System.Exception? __exception_401 = null;
                global::G.Error? __value_401 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_401 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_401 = global::G.Error.FromJson(__content_401, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_401 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_401 = global::G.Error.FromJson(__content_401, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_401 = __ex;
                }

                throw new global::G.ApiException<global::G.Error>(
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
            // Not found
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
            // Unprocessable entity
            if ((int)__response.StatusCode == 422)
            {
                string? __content_422 = null;
                global::System.Exception? __exception_422 = null;
                global::G.Error? __value_422 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_422 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_422 = global::G.Error.FromJson(__content_422, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_422 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_422 = global::G.Error.FromJson(__content_422, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_422 = __ex;
                }

                throw new global::G.ApiException<global::G.Error>(
                    message: __content_422 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_422,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_422,
                    ResponseObject = __value_422,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // Internal server error
            if ((int)__response.StatusCode == 500)
            {
                string? __content_500 = null;
                global::System.Exception? __exception_500 = null;
                global::G.Error? __value_500 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_500 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_500 = global::G.Error.FromJson(__content_500, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_500 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_500 = global::G.Error.FromJson(__content_500, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_500 = __ex;
                }

                throw new global::G.ApiException<global::G.Error>(
                    message: __content_500 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_500,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_500,
                    ResponseObject = __value_500,
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
                ProcessGetConnectedAccountsResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.GetConnectedAccountsResponse.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::G.GetConnectedAccountsResponse.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
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