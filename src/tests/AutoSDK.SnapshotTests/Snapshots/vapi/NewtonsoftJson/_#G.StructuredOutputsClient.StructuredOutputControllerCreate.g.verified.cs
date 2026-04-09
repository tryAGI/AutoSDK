//HintName: G.StructuredOutputsClient.StructuredOutputControllerCreate.g.cs

#nullable enable

namespace G
{
    public partial class StructuredOutputsClient
    {


        private static readonly global::G.EndPointSecurityRequirement s_StructuredOutputControllerCreateSecurityRequirement0 =
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
        private static readonly global::G.EndPointSecurityRequirement[] s_StructuredOutputControllerCreateSecurityRequirements =
            new global::G.EndPointSecurityRequirement[]
            {                s_StructuredOutputControllerCreateSecurityRequirement0,
            };
        partial void PrepareStructuredOutputControllerCreateArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::G.CreateStructuredOutputDTO request);
        partial void PrepareStructuredOutputControllerCreateRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::G.CreateStructuredOutputDTO request);
        partial void ProcessStructuredOutputControllerCreateResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessStructuredOutputControllerCreateResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create Structured Output
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.StructuredOutput> StructuredOutputControllerCreateAsync(

            global::G.CreateStructuredOutputDTO request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareStructuredOutputControllerCreateArguments(
                httpClient: HttpClient,
                request: request);


            var __authorizations = global::G.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_StructuredOutputControllerCreateSecurityRequirements,
                operationName: "StructuredOutputControllerCreateAsync");

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
                                path: "/structured-output",
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
                PrepareStructuredOutputControllerCreateRequest(
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
                                operationId: "StructuredOutputControllerCreate",
                                methodName: "StructuredOutputControllerCreateAsync",
                                pathTemplate: "\"/structured-output\"",
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
                                operationId: "StructuredOutputControllerCreate",
                                methodName: "StructuredOutputControllerCreateAsync",
                                pathTemplate: "\"/structured-output\"",
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
                                operationId: "StructuredOutputControllerCreate",
                                methodName: "StructuredOutputControllerCreateAsync",
                                pathTemplate: "\"/structured-output\"",
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
                ProcessStructuredOutputControllerCreateResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::G.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::G.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "StructuredOutputControllerCreate",
                                methodName: "StructuredOutputControllerCreateAsync",
                                pathTemplate: "\"/structured-output\"",
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
                                operationId: "StructuredOutputControllerCreate",
                                methodName: "StructuredOutputControllerCreateAsync",
                                pathTemplate: "\"/structured-output\"",
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
                                ProcessStructuredOutputControllerCreateResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    return
                                        global::G.StructuredOutput.FromJson(__content, JsonSerializerOptions) ??
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
                                        await global::G.StructuredOutput.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
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
        /// Create Structured Output
        /// </summary>
        /// <param name="type">
        /// This is the type of structured output.<br/>
        /// - 'ai': Uses an LLM to extract structured data from the conversation (default).<br/>
        /// - 'regex': Uses a regex pattern to extract data from the transcript without an LLM.<br/>
        /// Defaults to 'ai' if not specified.<br/>
        /// Default Value: ai
        /// </param>
        /// <param name="regex">
        /// This is the regex pattern to match against the transcript.<br/>
        /// Only used when type is 'regex'. Supports both raw patterns (e.g. '\d+') and<br/>
        /// regex literal format (e.g. '/\d+/gi'). Uses RE2 syntax for safety.<br/>
        /// The result depends on the schema type:<br/>
        /// - boolean: true if the pattern matches, false otherwise<br/>
        /// - string: the first match or first capture group<br/>
        /// - number/integer: the first match parsed as a number<br/>
        /// - array: all matches
        /// </param>
        /// <param name="model">
        /// This is the model that will be used to extract the structured output.<br/>
        /// To provide your own custom system and user prompts for structured output extraction, populate the messages array with your system and user messages. You can specify liquid templating in your system and user messages.<br/>
        /// Between the system or user messages, you must reference either 'transcript' or 'messages' with the `{{}}` syntax to access the conversation history.<br/>
        /// Between the system or user messages, you must reference a variation of the structured output with the `{{}}` syntax to access the structured output definition.<br/>
        /// i.e.:<br/>
        /// `{{structuredOutput}}`<br/>
        /// `{{structuredOutput.name}}`<br/>
        /// `{{structuredOutput.description}}`<br/>
        /// `{{structuredOutput.schema}}`<br/>
        /// If model is not specified, GPT-4.1 will be used by default for extraction, utilizing default system and user prompts.<br/>
        /// If messages or required fields are not specified, the default system and user prompts will be used.
        /// </param>
        /// <param name="compliancePlan">
        /// Compliance configuration for this output. Only enable overrides if no sensitive data will be stored.<br/>
        /// Example: {"forceStoreOnHipaaEnabled":false}
        /// </param>
        /// <param name="name">
        /// This is the name of the structured output.
        /// </param>
        /// <param name="schema">
        /// This is the JSON Schema definition for the structured output.<br/>
        /// This is required when creating a structured output. Defines the structure and validation rules for the data that will be extracted. Supports all JSON Schema features including:<br/>
        /// - Objects and nested properties<br/>
        /// - Arrays and array validation<br/>
        /// - String, number, boolean, and null types<br/>
        /// - Enums and const values<br/>
        /// - Validation constraints (min/max, patterns, etc.)<br/>
        /// - Composition with allOf, anyOf, oneOf
        /// </param>
        /// <param name="description">
        /// This is the description of what the structured output extracts.<br/>
        /// Use this to provide context about what data will be extracted and how it will be used.
        /// </param>
        /// <param name="assistantIds">
        /// These are the assistant IDs that this structured output is linked to.<br/>
        /// When linked to assistants, this structured output will be available for extraction during those assistant's calls.
        /// </param>
        /// <param name="workflowIds">
        /// These are the workflow IDs that this structured output is linked to.<br/>
        /// When linked to workflows, this structured output will be available for extraction during those workflow's execution.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.StructuredOutput> StructuredOutputControllerCreateAsync(
            string name,
            global::G.JsonSchema schema,
            global::G.CreateStructuredOutputDTOType? type = default,
            string? regex = default,
            global::G.OneOf<global::G.WorkflowOpenAIModel, global::G.WorkflowAnthropicModel, global::G.WorkflowAnthropicBedrockModel, global::G.WorkflowGoogleModel, global::G.WorkflowCustomModel>? model = default,
            global::G.ComplianceOverride? compliancePlan = default,
            string? description = default,
            global::System.Collections.Generic.IList<string>? assistantIds = default,
            global::System.Collections.Generic.IList<string>? workflowIds = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.CreateStructuredOutputDTO
            {
                Type = type,
                Regex = regex,
                Model = model,
                CompliancePlan = compliancePlan,
                Name = name,
                Schema = schema,
                Description = description,
                AssistantIds = assistantIds,
                WorkflowIds = workflowIds,
            };

            return await StructuredOutputControllerCreateAsync(
                request: __request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}