//HintName: G.MemoriesClient.MemoriesCreate.g.cs

#nullable enable

namespace G
{
    public partial class MemoriesClient
    {


        private static readonly global::G.EndPointSecurityRequirement s_MemoriesCreateSecurityRequirement0 =
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
        private static readonly global::G.EndPointSecurityRequirement[] s_MemoriesCreateSecurityRequirements =
            new global::G.EndPointSecurityRequirement[]
            {                s_MemoriesCreateSecurityRequirement0,
            };
        partial void PrepareMemoriesCreateArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::G.MemoryInput request);
        partial void PrepareMemoriesCreateRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::G.MemoryInput request);
        partial void ProcessMemoriesCreateResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessMemoriesCreateResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Add memories.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.MemoriesCreateResponseItem>> MemoriesCreateAsync(

            global::G.MemoryInput request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareMemoriesCreateArguments(
                httpClient: HttpClient,
                request: request);


            var __authorizations = global::G.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_MemoriesCreateSecurityRequirements,
                operationName: "MemoriesCreateAsync");

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
                                path: "/v1/memories/",
                                baseUri: HttpClient.BaseAddress);
                            var __path = __pathBuilder.ToString();
                __path = global::G.AutoSDKRequestOptionsSupport.AppendQueryParameters(
                    path: __path,
                    clientParameters: Options.QueryParameters,
                    requestParameters: requestOptions?.QueryParameters);
                var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
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
                global::G.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PrepareMemoriesCreateRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    request: request);

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
                                operationId: "MemoriesCreate",
                                methodName: "MemoriesCreateAsync",
                                pathTemplate: "\"/v1/memories/\"",
                                httpMethod: "POST",
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
                                operationId: "MemoriesCreate",
                                methodName: "MemoriesCreateAsync",
                                pathTemplate: "\"/v1/memories/\"",
                                httpMethod: "POST",
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
                                operationId: "MemoriesCreate",
                                methodName: "MemoriesCreateAsync",
                                pathTemplate: "\"/v1/memories/\"",
                                httpMethod: "POST",
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
                ProcessMemoriesCreateResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::G.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::G.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "MemoriesCreate",
                                methodName: "MemoriesCreateAsync",
                                pathTemplate: "\"/v1/memories/\"",
                                httpMethod: "POST",
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
                                operationId: "MemoriesCreate",
                                methodName: "MemoriesCreateAsync",
                                pathTemplate: "\"/v1/memories/\"",
                                httpMethod: "POST",
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
                            // Bad Request. Invalid input data. Please refer to the memory creation documentation at https://docs.mem0.ai/platform/quickstart#4-1-create-memories for correct formatting and required fields.
                            if ((int)__response.StatusCode == 400)
                            {
                                string? __content_400 = null;
                                global::System.Exception? __exception_400 = null;
                                string? __value_400 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_400 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_400 = global::System.Text.Json.JsonSerializer.Deserialize<string?>(__content_400, JsonSerializerOptions);
                                    }
                                    else
                                    {
                                        __content_400 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_400 = global::System.Text.Json.JsonSerializer.Deserialize<string?>(__content_400, JsonSerializerOptions);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_400 = __ex;
                                }

                                throw new global::G.ApiException<string>(
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
                                ProcessMemoriesCreateResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    return
                                        global::System.Text.Json.JsonSerializer.Deserialize<global::System.Collections.Generic.IList<global::G.MemoriesCreateResponseItem>?>(__content, JsonSerializerOptions) ??
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
                                        await global::System.Text.Json.JsonSerializer.DeserializeAsync<global::System.Collections.Generic.IList<global::G.MemoriesCreateResponseItem>?>(__content, JsonSerializerOptions).ConfigureAwait(false) ??
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
        /// <summary>
        /// Add memories.
        /// </summary>
        /// <param name="messages">
        /// An array of message objects representing the content of the memory. Each message object typically contains 'role' and 'content' fields, where 'role' indicates the sender either 'user' or 'assistant' and 'content' contains the actual message text. This structure allows for the representation of conversations or multi-part memories.
        /// </param>
        /// <param name="agentId">
        /// The unique identifier of the agent associated with this memory.
        /// </param>
        /// <param name="userId">
        /// The unique identifier of the user associated with this memory.
        /// </param>
        /// <param name="appId">
        /// The unique identifier of the application associated with this memory.
        /// </param>
        /// <param name="runId">
        /// The unique identifier of the run associated with this memory.
        /// </param>
        /// <param name="metadata">
        /// Additional metadata associated with the memory, which can be used to store any additional information or context about the memory. Best practice for incorporating additional information is through metadata (e.g. location, time, ids, etc.). During retrieval, you can either use these metadata alongside the query to fetch relevant memories or retrieve memories based on the query first and then refine the results using metadata during post-processing.
        /// </param>
        /// <param name="includes">
        /// String to include the specific preferences in the memory.
        /// </param>
        /// <param name="excludes">
        /// String to exclude the specific preferences in the memory.
        /// </param>
        /// <param name="infer">
        /// Whether to infer the memories or directly store the messages.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="outputFormat">
        /// Controls the response format structure. `v1.0` (deprecated) returns a direct array of memory objects: `[{...}, {...}]`. `v1.1` (recommended) returns an object with a 'results' key containing the array: `{"results": [...]}`. The `v1.0` format will be removed in future versions.<br/>
        /// Default Value: v1.1
        /// </param>
        /// <param name="customCategories">
        /// A list of categories with category name and its description.
        /// </param>
        /// <param name="customInstructions">
        /// Defines project-specific guidelines for handling and organizing memories. When set at the project level, they apply to all new memories in that project.
        /// </param>
        /// <param name="immutable">
        /// Whether the memory is immutable.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="asyncMode">
        /// Whether to add the memory completely asynchronously.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="timestamp">
        /// The timestamp of the memory. Format: Unix timestamp
        /// </param>
        /// <param name="expirationDate">
        /// The date and time when the memory will expire. Format: YYYY-MM-DD
        /// </param>
        /// <param name="orgId">
        /// The unique identifier of the organization associated with this memory.
        /// </param>
        /// <param name="projectId">
        /// The unique identifier of the project associated with this memory.
        /// </param>
        /// <param name="version">
        /// The version of the memory to use. The default version is v1, which is deprecated. We recommend using v2 for new applications.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.MemoriesCreateResponseItem>> MemoriesCreateAsync(
            global::System.Collections.Generic.IList<global::System.Collections.Generic.Dictionary<string, string?>>? messages = default,
            string? agentId = default,
            string? userId = default,
            string? appId = default,
            string? runId = default,
            object? metadata = default,
            string? includes = default,
            string? excludes = default,
            bool? infer = default,
            string? outputFormat = default,
            object? customCategories = default,
            string? customInstructions = default,
            bool? immutable = default,
            bool? asyncMode = default,
            global::System.DateTimeOffset? timestamp = default,
            string? expirationDate = default,
            string? orgId = default,
            string? projectId = default,
            string? version = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.MemoryInput
            {
                Messages = messages,
                AgentId = agentId,
                UserId = userId,
                AppId = appId,
                RunId = runId,
                Metadata = metadata,
                Includes = includes,
                Excludes = excludes,
                Infer = infer,
                OutputFormat = outputFormat,
                CustomCategories = customCategories,
                CustomInstructions = customInstructions,
                Immutable = immutable,
                AsyncMode = asyncMode,
                Timestamp = timestamp,
                ExpirationDate = expirationDate,
                OrgId = orgId,
                ProjectId = projectId,
                Version = version,
            };

            return await MemoriesCreateAsync(
                request: __request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}