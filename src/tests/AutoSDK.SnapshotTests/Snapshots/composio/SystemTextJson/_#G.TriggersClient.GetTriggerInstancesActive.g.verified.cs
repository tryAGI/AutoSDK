//HintName: G.TriggersClient.GetTriggerInstancesActive.g.cs

#nullable enable

namespace G
{
    public partial class TriggersClient
    {


        private static readonly global::G.EndPointSecurityRequirement s_GetTriggerInstancesActiveSecurityRequirement0 =
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

        private static readonly global::G.EndPointSecurityRequirement s_GetTriggerInstancesActiveSecurityRequirement1 =
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

        private static readonly global::G.EndPointSecurityRequirement s_GetTriggerInstancesActiveSecurityRequirement2 =
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
        private static readonly global::G.EndPointSecurityRequirement[] s_GetTriggerInstancesActiveSecurityRequirements =
            new global::G.EndPointSecurityRequirement[]
            {                s_GetTriggerInstancesActiveSecurityRequirement0,
                s_GetTriggerInstancesActiveSecurityRequirement1,
                s_GetTriggerInstancesActiveSecurityRequirement2,
            };
        partial void PrepareGetTriggerInstancesActiveArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Collections.Generic.IList<string>? userIds,
            global::System.Collections.Generic.IList<string>? connectedAccountIds,
            global::System.Collections.Generic.IList<string>? authConfigIds,
            global::System.Collections.Generic.IList<string>? triggerIds,
            global::System.Collections.Generic.IList<string>? triggerNames,
            ref bool? showDisabled,
            ref double? limit,
            ref string? cursor);
        partial void PrepareGetTriggerInstancesActiveRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::System.Collections.Generic.IList<string>? userIds,
            global::System.Collections.Generic.IList<string>? connectedAccountIds,
            global::System.Collections.Generic.IList<string>? authConfigIds,
            global::System.Collections.Generic.IList<string>? triggerIds,
            global::System.Collections.Generic.IList<string>? triggerNames,
            bool? showDisabled,
            double? limit,
            string? cursor);
        partial void ProcessGetTriggerInstancesActiveResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGetTriggerInstancesActiveResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List active triggers<br/>
        /// Retrieves all active trigger instances for your project. Triggers listen for events from connected accounts (e.g., new emails, Slack messages, GitHub commits) and can invoke webhooks or workflows. Use filters to find triggers for specific users, connected accounts, or trigger types.
        /// </summary>
        /// <param name="userIds">
        /// Array of user IDs to filter triggers by
        /// </param>
        /// <param name="connectedAccountIds">
        /// Array of connected account IDs to filter triggers by
        /// </param>
        /// <param name="authConfigIds">
        /// Array of auth config IDs to filter triggers by
        /// </param>
        /// <param name="triggerIds">
        /// Array of trigger IDs to filter triggers by
        /// </param>
        /// <param name="triggerNames">
        /// Array of trigger names to filter triggers by. Case-insensitive (internally normalized to uppercase).
        /// </param>
        /// <param name="showDisabled">
        /// When set to true, includes disabled triggers in the response.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="limit"></param>
        /// <param name="cursor"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.GetTriggerInstancesActiveResponse> GetTriggerInstancesActiveAsync(
            global::System.Collections.Generic.IList<string>? userIds = default,
            global::System.Collections.Generic.IList<string>? connectedAccountIds = default,
            global::System.Collections.Generic.IList<string>? authConfigIds = default,
            global::System.Collections.Generic.IList<string>? triggerIds = default,
            global::System.Collections.Generic.IList<string>? triggerNames = default,
            bool? showDisabled = default,
            double? limit = default,
            string? cursor = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareGetTriggerInstancesActiveArguments(
                httpClient: HttpClient,
                userIds: userIds,
                connectedAccountIds: connectedAccountIds,
                authConfigIds: authConfigIds,
                triggerIds: triggerIds,
                triggerNames: triggerNames,
                showDisabled: ref showDisabled,
                limit: ref limit,
                cursor: ref cursor);


            var __authorizations = global::G.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_GetTriggerInstancesActiveSecurityRequirements,
                operationName: "GetTriggerInstancesActiveAsync");

            var __pathBuilder = new global::G.PathBuilder(
                path: "/api/v3/trigger_instances/active",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddOptionalParameter("user_ids", userIds, delimiter: ",", explode: true)
                .AddOptionalParameter("connected_account_ids", connectedAccountIds, delimiter: ",", explode: true)
                .AddOptionalParameter("auth_config_ids", authConfigIds, delimiter: ",", explode: true)
                .AddOptionalParameter("trigger_ids", triggerIds, delimiter: ",", explode: true)
                .AddOptionalParameter("trigger_names", triggerNames, delimiter: ",", explode: true)
                .AddOptionalParameter("show_disabled", showDisabled?.ToString().ToLowerInvariant())
                .AddOptionalParameter("limit", limit?.ToString())
                .AddOptionalParameter("cursor", cursor) 
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
            PrepareGetTriggerInstancesActiveRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                userIds: userIds,
                connectedAccountIds: connectedAccountIds,
                authConfigIds: authConfigIds,
                triggerIds: triggerIds,
                triggerNames: triggerNames,
                showDisabled: showDisabled,
                limit: limit,
                cursor: cursor);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessGetTriggerInstancesActiveResponse(
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
                ProcessGetTriggerInstancesActiveResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.GetTriggerInstancesActiveResponse.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::G.GetTriggerInstancesActiveResponse.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
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