//HintName: G.PromptsClient.CallPrompt.g.cs

#nullable enable

namespace G
{
    public partial class PromptsClient
    {


        private static readonly global::G.EndPointSecurityRequirement s_CallPromptSecurityRequirement0 =
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
        private static readonly global::G.EndPointSecurityRequirement[] s_CallPromptSecurityRequirements =
            new global::G.EndPointSecurityRequirement[]
            {                s_CallPromptSecurityRequirement0,
            };
        partial void PrepareCallPromptArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::G.PromptCallRequest request);
        partial void PrepareCallPromptRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::G.PromptCallRequest request);
        partial void ProcessCallPromptResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCallPromptResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Call Prompt<br/>
        /// Call a Prompt with proxied LLM call and automatic logging.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.PromptCallResponse> CallPromptAsync(

            global::G.PromptCallRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareCallPromptArguments(
                httpClient: HttpClient,
                request: request);


            var __authorizations = global::G.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_CallPromptSecurityRequirements,
                operationName: "CallPromptAsync");

            var __pathBuilder = new global::G.PathBuilder(
                path: "/prompts/call",
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
            PrepareCallPromptRequest(
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
            ProcessCallPromptResponse(
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
                ProcessCallPromptResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.PromptCallResponse.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::G.PromptCallResponse.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
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
        /// Call Prompt<br/>
        /// Call a Prompt with proxied LLM call and automatic logging.
        /// </summary>
        /// <param name="versionId">
        /// A specific Version ID of the Prompt to call.
        /// </param>
        /// <param name="environment">
        /// Name of the Environment identifying a deployed version.
        /// </param>
        /// <param name="path">
        /// Path of the Prompt.
        /// </param>
        /// <param name="id">
        /// ID for an existing Prompt.
        /// </param>
        /// <param name="messages">
        /// The messages passed to the provider.
        /// </param>
        /// <param name="prompt">
        /// Request to create or update a Prompt.
        /// </param>
        /// <param name="inputs">
        /// The inputs passed to the prompt template.
        /// </param>
        /// <param name="source">
        /// Identifies where the model was called from.
        /// </param>
        /// <param name="metadata"></param>
        /// <param name="save">
        /// Whether the request/response payloads will be stored.
        /// </param>
        /// <param name="logId">
        /// Custom Log ID.
        /// </param>
        /// <param name="numSamples">
        /// The number of generations.
        /// </param>
        /// <param name="returnInputs">
        /// Whether to return the inputs in the response.
        /// </param>
        /// <param name="traceParentId">
        /// The ID of the parent Log to nest this Log under.
        /// </param>
        /// <param name="user">
        /// End-user ID related to the Log.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.PromptCallResponse> CallPromptAsync(
            string? versionId = default,
            string? environment = default,
            string? path = default,
            string? id = default,
            global::System.Collections.Generic.IList<global::G.ChatMessage>? messages = default,
            global::G.PromptRequest? prompt = default,
            object? inputs = default,
            string? source = default,
            object? metadata = default,
            bool? save = default,
            string? logId = default,
            int? numSamples = default,
            bool? returnInputs = default,
            string? traceParentId = default,
            string? user = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.PromptCallRequest
            {
                VersionId = versionId,
                Environment = environment,
                Path = path,
                Id = id,
                Messages = messages,
                Prompt = prompt,
                Inputs = inputs,
                Source = source,
                Metadata = metadata,
                Save = save,
                LogId = logId,
                NumSamples = numSamples,
                ReturnInputs = returnInputs,
                TraceParentId = traceParentId,
                User = user,
            };

            return await CallPromptAsync(
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}