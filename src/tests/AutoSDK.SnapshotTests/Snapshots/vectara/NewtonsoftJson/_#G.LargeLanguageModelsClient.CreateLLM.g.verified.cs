//HintName: G.LargeLanguageModelsClient.CreateLLM.g.cs

#nullable enable

namespace G
{
    public partial class LargeLanguageModelsClient
    {
        partial void PrepareCreateLLMArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref int? requestTimeout,
            ref int? requestTimeoutMillis,
            global::G.CreateLLMRequest request);
        partial void PrepareCreateLLMRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            int? requestTimeout,
            int? requestTimeoutMillis,
            global::G.CreateLLMRequest request);
        partial void ProcessCreateLLMResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateLLMResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create an LLM<br/>
        /// Integrate external Large Language Models (LLMs) into Vectara for Retrieval Augmented Generation (RAG) and chat. Connect OpenAI API-compatible models from providers like Anthropic, Azure, Google, or custom-hosted endpoints. Once created, reference your custom LLM by name in query generation parameters.<br/>
        /// - Connect external LLMs using OpenAI-compatible API format<br/>
        /// - Configure multiple LLM providers for different use cases<br/>
        /// - Override Vectara's built-in LLMs with your own models<br/>
        /// - Use custom models for RAG, chat, and document summarization<br/>
        /// **Example providers:**<br/>
        /// ### OpenAI<br/>
        /// **Type:** `openai-compatible`<br/>
        /// **Models:** GPT-4o, GPT-5<br/>
        /// **Auth:** Bearer token<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "type": "openai-compatible",<br/>
        ///   "name": "my-gpt5",<br/>
        ///   "model": "gpt-5",<br/>
        ///   "uri": "https://api.openai.com/v1/chat/completions",<br/>
        ///   "auth": {<br/>
        ///     "type": "bearer",<br/>
        ///     "token": "sk-..."<br/>
        ///   }<br/>
        /// }<br/>
        /// ```<br/>
        /// ### OpenAI Responses API<br/>
        /// **Type**: openai-responses<br/>
        /// **Models**: o1-preview, o1-mini, o3-mini (reasoning models)<br/>
        /// **Auth**: Bearer token<br/>
        /// **Note**: For reasoning models that don't support streaming<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "type": "openai-responses",<br/>
        ///   "name": "my-o1",<br/>
        ///   "model": "o1-preview",<br/>
        ///   "uri": "https://api.openai.com/v1/chat/completions",<br/>
        ///   "auth": {<br/>
        ///     "type": "bearer",<br/>
        ///     "token": "sk-..."<br/>
        ///   }<br/>
        /// }<br/>
        /// ```<br/>
        /// ### Anthropic Claude<br/>
        /// **Type:** `openai-compatible`<br/>
        /// **Models:** claude-4-opus, claude-4-5-haiku, claude-4-5-sonnet<br/>
        /// **Auth:** Bearer token with header<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "type": "openai-compatible",<br/>
        ///   "name": "my-claude",<br/>
        ///   "model": "claude-sonnet-4-5-20250929",<br/>
        ///   "uri": "https://api.anthropic.com/v1/messages",<br/>
        ///   "auth": {<br/>
        ///     "type": "bearer",<br/>
        ///     "token": "sk-ant-..."<br/>
        ///   },<br/>
        ///   "headers": {<br/>
        ///     "anthropic-version": "2023-06-01"<br/>
        ///   }<br/>
        /// }<br/>
        /// ```<br/>
        /// ### Azure OpenAI<br/>
        /// **Type:** `openai-compatible`<br/>
        /// **Models:** GPT-3.5, GPT-4 (Azure-deployed versions)<br/>
        /// **Auth:** Custom header (api-key)<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "type": "openai-compatible",<br/>
        ///   "name": "my-azure-gpt4",<br/>
        ///   "model": "gpt-4",<br/>
        ///   "uri": "https://YOUR-RESOURCE.openai.azure.com/openai/deployments/YOUR-DEPLOYMENT/chat/completions?api-version=2024-02-15-preview",<br/>
        ///   "auth": {<br/>
        ///     "type": "header",<br/>
        ///     "header": "api-key",<br/>
        ///     "value": "your-azure-key"<br/>
        ///   }<br/>
        /// }<br/>
        /// ```<br/>
        /// ### Google Vertex AI (Gemini) — Service Account<br/>
        /// **Type:** `vertex-ai`<br/>
        /// **Models:** gemini-2.5-pro, gemini-2.5-flash<br/>
        /// **Auth:** Service account<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "type": "vertex-ai",<br/>
        ///   "name": "my-gemini",<br/>
        ///   "model": "gemini-2.5-flash",<br/>
        ///   "uri": "https://us-central1-aiplatform.googleapis.com/v1/projects/YOUR-PROJECT/locations/us-central1",<br/>
        ///   "auth": {<br/>
        ///     "type": "service_account",<br/>
        ///     "key_json": "{...service account JSON...}"<br/>
        ///   }<br/>
        /// }<br/>
        /// ```<br/>
        /// ### Google AI Studio (Gemini) — API Key<br/>
        /// **Type:** `vertex-ai`<br/>
        /// **Models:** gemini-2.5-pro, gemini-2.5-flash<br/>
        /// **Auth:** API key<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "type": "vertex-ai",<br/>
        ///   "name": "my-gemini",<br/>
        ///   "model": "gemini-2.5-flash",<br/>
        ///   "uri": "https://generativelanguage.googleapis.com/v1beta",<br/>
        ///   "auth": {<br/>
        ///     "type": "api_key",<br/>
        ///     "api_key": "your-google-api-key"<br/>
        ///   }<br/>
        /// }<br/>
        /// ```<br/>
        /// The `uri` field is flexible — you can provide a base URI or a full URL copied from Google docs<br/>
        /// (including model path and `:generateContent` suffix). The system normalizes it automatically.<br/>
        /// ### Custom OpenAI-Compatible<br/>
        /// **Type:** `openai-compatible`<br/>
        /// **Models:** Any self-hosted or custom LLM, such as OpenRouter.<br/>
        /// **Auth:** Bearer or custom header<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "type": "openai-compatible",<br/>
        ///   "name": "my-custom-llm",<br/>
        ///   "model": "llama-3-70b",<br/>
        ///   "uri": "https://my-llm-endpoint.com/v1/chat/completions",<br/>
        ///   "auth": {<br/>
        ///     "type": "bearer",<br/>
        ///     "token": "custom-token"<br/>
        ///   }<br/>
        /// }<br/>
        /// ```
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.Llm> CreateLLMAsync(

            global::G.CreateLLMRequest request,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareCreateLLMArguments(
                httpClient: HttpClient,
                requestTimeout: ref requestTimeout,
                requestTimeoutMillis: ref requestTimeoutMillis,
                request: request);

            var __pathBuilder = new global::G.PathBuilder(
                path: "/v2/llms",
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

            if (requestTimeout != default)
            {
                __httpRequest.Headers.TryAddWithoutValidation("Request-Timeout", requestTimeout.ToString());
            }
            if (requestTimeoutMillis != default)
            {
                __httpRequest.Headers.TryAddWithoutValidation("Request-Timeout-Millis", requestTimeoutMillis.ToString());
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
            PrepareCreateLLMRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                requestTimeout: requestTimeout,
                requestTimeoutMillis: requestTimeoutMillis,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessCreateLLMResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // Invalid request body
            if ((int)__response.StatusCode == 400)
            {
                string? __content_400 = null;
                global::System.Exception? __exception_400 = null;
                global::G.BadRequestError? __value_400 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_400 = global::G.BadRequestError.FromJson(__content_400, JsonSerializerOptions);
                    }
                    else
                    {
                        var __contentStream_400 = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                        __value_400 = await global::G.BadRequestError.FromJsonStreamAsync(__contentStream_400, JsonSerializerOptions).ConfigureAwait(false);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_400 = __ex;
                }

                throw new global::G.ApiException<global::G.BadRequestError>(
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
            // Permissions do not allow creating an LLM
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
                        var __contentStream_403 = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                        __value_403 = await global::G.Error.FromJsonStreamAsync(__contentStream_403, JsonSerializerOptions).ConfigureAwait(false);
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
                ProcessCreateLLMResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.Llm.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::G.Llm.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
                        throw new global::System.InvalidOperationException("Response deserialization failed.");
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
        }

        /// <summary>
        /// Create an LLM<br/>
        /// Integrate external Large Language Models (LLMs) into Vectara for Retrieval Augmented Generation (RAG) and chat. Connect OpenAI API-compatible models from providers like Anthropic, Azure, Google, or custom-hosted endpoints. Once created, reference your custom LLM by name in query generation parameters.<br/>
        /// - Connect external LLMs using OpenAI-compatible API format<br/>
        /// - Configure multiple LLM providers for different use cases<br/>
        /// - Override Vectara's built-in LLMs with your own models<br/>
        /// - Use custom models for RAG, chat, and document summarization<br/>
        /// **Example providers:**<br/>
        /// ### OpenAI<br/>
        /// **Type:** `openai-compatible`<br/>
        /// **Models:** GPT-4o, GPT-5<br/>
        /// **Auth:** Bearer token<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "type": "openai-compatible",<br/>
        ///   "name": "my-gpt5",<br/>
        ///   "model": "gpt-5",<br/>
        ///   "uri": "https://api.openai.com/v1/chat/completions",<br/>
        ///   "auth": {<br/>
        ///     "type": "bearer",<br/>
        ///     "token": "sk-..."<br/>
        ///   }<br/>
        /// }<br/>
        /// ```<br/>
        /// ### OpenAI Responses API<br/>
        /// **Type**: openai-responses<br/>
        /// **Models**: o1-preview, o1-mini, o3-mini (reasoning models)<br/>
        /// **Auth**: Bearer token<br/>
        /// **Note**: For reasoning models that don't support streaming<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "type": "openai-responses",<br/>
        ///   "name": "my-o1",<br/>
        ///   "model": "o1-preview",<br/>
        ///   "uri": "https://api.openai.com/v1/chat/completions",<br/>
        ///   "auth": {<br/>
        ///     "type": "bearer",<br/>
        ///     "token": "sk-..."<br/>
        ///   }<br/>
        /// }<br/>
        /// ```<br/>
        /// ### Anthropic Claude<br/>
        /// **Type:** `openai-compatible`<br/>
        /// **Models:** claude-4-opus, claude-4-5-haiku, claude-4-5-sonnet<br/>
        /// **Auth:** Bearer token with header<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "type": "openai-compatible",<br/>
        ///   "name": "my-claude",<br/>
        ///   "model": "claude-sonnet-4-5-20250929",<br/>
        ///   "uri": "https://api.anthropic.com/v1/messages",<br/>
        ///   "auth": {<br/>
        ///     "type": "bearer",<br/>
        ///     "token": "sk-ant-..."<br/>
        ///   },<br/>
        ///   "headers": {<br/>
        ///     "anthropic-version": "2023-06-01"<br/>
        ///   }<br/>
        /// }<br/>
        /// ```<br/>
        /// ### Azure OpenAI<br/>
        /// **Type:** `openai-compatible`<br/>
        /// **Models:** GPT-3.5, GPT-4 (Azure-deployed versions)<br/>
        /// **Auth:** Custom header (api-key)<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "type": "openai-compatible",<br/>
        ///   "name": "my-azure-gpt4",<br/>
        ///   "model": "gpt-4",<br/>
        ///   "uri": "https://YOUR-RESOURCE.openai.azure.com/openai/deployments/YOUR-DEPLOYMENT/chat/completions?api-version=2024-02-15-preview",<br/>
        ///   "auth": {<br/>
        ///     "type": "header",<br/>
        ///     "header": "api-key",<br/>
        ///     "value": "your-azure-key"<br/>
        ///   }<br/>
        /// }<br/>
        /// ```<br/>
        /// ### Google Vertex AI (Gemini) — Service Account<br/>
        /// **Type:** `vertex-ai`<br/>
        /// **Models:** gemini-2.5-pro, gemini-2.5-flash<br/>
        /// **Auth:** Service account<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "type": "vertex-ai",<br/>
        ///   "name": "my-gemini",<br/>
        ///   "model": "gemini-2.5-flash",<br/>
        ///   "uri": "https://us-central1-aiplatform.googleapis.com/v1/projects/YOUR-PROJECT/locations/us-central1",<br/>
        ///   "auth": {<br/>
        ///     "type": "service_account",<br/>
        ///     "key_json": "{...service account JSON...}"<br/>
        ///   }<br/>
        /// }<br/>
        /// ```<br/>
        /// ### Google AI Studio (Gemini) — API Key<br/>
        /// **Type:** `vertex-ai`<br/>
        /// **Models:** gemini-2.5-pro, gemini-2.5-flash<br/>
        /// **Auth:** API key<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "type": "vertex-ai",<br/>
        ///   "name": "my-gemini",<br/>
        ///   "model": "gemini-2.5-flash",<br/>
        ///   "uri": "https://generativelanguage.googleapis.com/v1beta",<br/>
        ///   "auth": {<br/>
        ///     "type": "api_key",<br/>
        ///     "api_key": "your-google-api-key"<br/>
        ///   }<br/>
        /// }<br/>
        /// ```<br/>
        /// The `uri` field is flexible — you can provide a base URI or a full URL copied from Google docs<br/>
        /// (including model path and `:generateContent` suffix). The system normalizes it automatically.<br/>
        /// ### Custom OpenAI-Compatible<br/>
        /// **Type:** `openai-compatible`<br/>
        /// **Models:** Any self-hosted or custom LLM, such as OpenRouter.<br/>
        /// **Auth:** Bearer or custom header<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "type": "openai-compatible",<br/>
        ///   "name": "my-custom-llm",<br/>
        ///   "model": "llama-3-70b",<br/>
        ///   "uri": "https://my-llm-endpoint.com/v1/chat/completions",<br/>
        ///   "auth": {<br/>
        ///     "type": "bearer",<br/>
        ///     "token": "custom-token"<br/>
        ///   }<br/>
        /// }<br/>
        /// ```
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.Llm> CreateLLMAsync(
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.CreateLLMRequest
            {
            };

            return await CreateLLMAsync(
                requestTimeout: requestTimeout,
                requestTimeoutMillis: requestTimeoutMillis,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}