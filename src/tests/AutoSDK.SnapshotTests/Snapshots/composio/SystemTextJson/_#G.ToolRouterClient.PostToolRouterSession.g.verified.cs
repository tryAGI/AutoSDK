//HintName: G.ToolRouterClient.PostToolRouterSession.g.cs

#nullable enable

namespace G
{
    public partial class ToolRouterClient
    {
        partial void PreparePostToolRouterSessionArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::G.PostToolRouterSessionRequest request);
        partial void PreparePostToolRouterSessionRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::G.PostToolRouterSessionRequest request);
        partial void ProcessPostToolRouterSessionResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessPostToolRouterSessionResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create a new tool router session<br/>
        /// Creates a new session for the tool router feature. This endpoint initializes a new session with specified toolkits and their authentication configurations. The session provides an isolated environment for testing and managing tool routing logic with scoped MCP server access.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.PostToolRouterSessionResponse> PostToolRouterSessionAsync(

            global::G.PostToolRouterSessionRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PreparePostToolRouterSessionArguments(
                httpClient: HttpClient,
                request: request);

            var __pathBuilder = new global::G.PathBuilder(
                path: "/api/v3/tool_router/session",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
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
            var __httpRequestContentBody = request.ToJson(JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PreparePostToolRouterSessionRequest(
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
            ProcessPostToolRouterSessionResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // Bad request. This may occur if the user_id format is invalid, toolkit names are invalid, or auth_config_id IDs are malformed.
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
            // Unauthorized. Authentication is required or the provided credentials are invalid.
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
            // Forbidden. The user is not authorized to create a tool router session.
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
            // Internal server error. An unexpected error occurred while processing the request.
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
                ProcessPostToolRouterSessionResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.PostToolRouterSessionResponse.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::G.PostToolRouterSessionResponse.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
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
        /// <summary>
        /// Create a new tool router session<br/>
        /// Creates a new session for the tool router feature. This endpoint initializes a new session with specified toolkits and their authentication configurations. The session provides an isolated environment for testing and managing tool routing logic with scoped MCP server access.
        /// </summary>
        /// <param name="userId">
        /// The identifier of the user who is initiating the session, ideally a unique identifier from your database like a user ID or email address<br/>
        /// Example: user_123456789
        /// </param>
        /// <param name="toolkits">
        /// Toolkit configuration - specify either enable toolkits (allowlist) or disable toolkits (denylist). Mutually exclusive.
        /// </param>
        /// <param name="authConfigs">
        /// The auth configs to use for the session. This will override the default behavior and use the given auth config when specific toolkits are being executed<br/>
        /// Example: {"gmail":"ac_1223434343","slack":"ac_23343434343434"}
        /// </param>
        /// <param name="connectedAccounts">
        /// The connected accounts to use for the session. This will override the default behaviour and use the given connected account when specific toolkits are being executed<br/>
        /// Example: {"github":"ca_34454545454545"}
        /// </param>
        /// <param name="manageConnections">
        /// Configuration for connection management settings<br/>
        /// Default Value: {"enable":true,"enable_wait_for_connections":false,"enable_connection_removal":true}
        /// </param>
        /// <param name="tools">
        /// Tool-level configuration per toolkit - either specify enable tools (whitelist), disable tools (blacklist), or filter by MCP tags for each toolkit<br/>
        /// Example: {"gmail":{"enable":["GMAIL_SEND_EMAIL","GMAIL_FETCH_EMAILS"]},"slack":{"disable":["SLACK_ADD_EMOJI"]},"slack_bot":{"tags":{"enable":["destructiveHint"],"disable":["openWorldHint"]}}}
        /// </param>
        /// <param name="tags">
        /// Global MCP tool annotation hints for filtering. Array format is treated as enabled list. Object format supports both enabled (tool must have at least one) and disabled (tool must NOT have any) lists. Toolkit-level tags override this. Toolkit enabled/disabled lists take precedence over tag filtering.<br/>
        /// Example: {"enable":["openWorldHint"],"disable":["destructiveHint"]}
        /// </param>
        /// <param name="workbench">
        /// Configuration for workbench behavior<br/>
        /// Default Value: {"enable":true,"enable_proxy_execution":true}
        /// </param>
        /// <param name="experimental">
        /// Experimental features - not stable, may be modified or removed in future versions.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.PostToolRouterSessionResponse> PostToolRouterSessionAsync(
            string userId,
            global::G.AnyOf<global::G.PostToolRouterSessionRequestToolkitsVariant1, global::G.PostToolRouterSessionRequestToolkitsVariant2>? toolkits = default,
            global::System.Collections.Generic.Dictionary<string, string>? authConfigs = default,
            global::System.Collections.Generic.Dictionary<string, string>? connectedAccounts = default,
            global::G.PostToolRouterSessionRequestManageConnections? manageConnections = default,
            object? tools = default,
            global::G.AnyOf<global::System.Collections.Generic.IList<global::G.PostToolRouterSessionRequestTag>, global::G.PostToolRouterSessionRequestTags>? tags = default,
            global::G.PostToolRouterSessionRequestWorkbench? workbench = default,
            global::G.PostToolRouterSessionRequestExperimental? experimental = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.PostToolRouterSessionRequest
            {
                UserId = userId,
                Toolkits = toolkits,
                AuthConfigs = authConfigs,
                ConnectedAccounts = connectedAccounts,
                ManageConnections = manageConnections,
                Tools = tools,
                Tags = tags,
                Workbench = workbench,
                Experimental = experimental,
            };

            return await PostToolRouterSessionAsync(
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}