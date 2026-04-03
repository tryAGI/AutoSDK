//HintName: G.ValidateClient.Validate.g.cs

#nullable enable

namespace G
{
    public partial class ValidateClient
    {
        partial void PrepareValidateArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string guardName,
            ref string? xOpenaiApiKey,
            global::G.ValidatePayload request);
        partial void PrepareValidateRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string guardName,
            string? xOpenaiApiKey,
            global::G.ValidatePayload request);
        partial void ProcessValidateResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessValidateResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Runs the validations specified in a Guard
        /// </summary>
        /// <param name="guardName"></param>
        /// <param name="xOpenaiApiKey"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.ValidationOutcome> ValidateAsync(
            string guardName,

            global::G.ValidatePayload request,
            string? xOpenaiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareValidateArguments(
                httpClient: HttpClient,
                guardName: ref guardName,
                xOpenaiApiKey: ref xOpenaiApiKey,
                request: request);

            var __pathBuilder = new global::G.PathBuilder(
                path: $"/guards/{guardName}/validate",
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

            if (xOpenaiApiKey != default)
            {
                __httpRequest.Headers.TryAddWithoutValidation("x-openai-api-key", xOpenaiApiKey.ToString());
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
            PrepareValidateRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                guardName: guardName,
                xOpenaiApiKey: xOpenaiApiKey,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessValidateResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // Unexpected error
            if (!__response.IsSuccessStatusCode)
            {
                string? __content_default = null;
                global::System.Exception? __exception_default = null;
                global::G.HttpError? __value_default = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_default = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_default = global::G.HttpError.FromJson(__content_default, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_default = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_default = global::G.HttpError.FromJson(__content_default, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_default = __ex;
                }

                throw new global::G.ApiException<global::G.HttpError>(
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
                var __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                    cancellationToken
#endif
                ).ConfigureAwait(false);

                ProcessResponseContent(
                    client: HttpClient,
                    response: __response,
                    content: ref __content);
                ProcessValidateResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.ValidationOutcome.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::G.ValidationOutcome.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
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
        /// Runs the validations specified in a Guard
        /// </summary>
        /// <param name="guardName"></param>
        /// <param name="xOpenaiApiKey"></param>
        /// <param name="llmOutput">
        /// The LLM output as a string or the input prompts for the LLM<br/>
        /// Example: stubbed llm output
        /// </param>
        /// <param name="numReasks">
        /// An override for the number of re-asks to perform
        /// </param>
        /// <param name="promptParams">
        /// Additional params for llm prompts
        /// </param>
        /// <param name="llmApi">
        /// The LLM API to use for validation
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.ValidationOutcome> ValidateAsync(
            string guardName,
            string? xOpenaiApiKey = default,
            string? llmOutput = default,
            int? numReasks = default,
            object? promptParams = default,
            global::G.ValidatePayloadLlmApi? llmApi = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.ValidatePayload
            {
                LlmOutput = llmOutput,
                NumReasks = numReasks,
                PromptParams = promptParams,
                LlmApi = llmApi,
            };

            return await ValidateAsync(
                guardName: guardName,
                xOpenaiApiKey: xOpenaiApiKey,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}