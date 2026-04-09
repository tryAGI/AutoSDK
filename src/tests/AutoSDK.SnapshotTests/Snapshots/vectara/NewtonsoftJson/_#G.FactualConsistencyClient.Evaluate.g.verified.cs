//HintName: G.FactualConsistencyClient.Evaluate.g.cs

#nullable enable

namespace G
{
    public partial class FactualConsistencyClient
    {


        private static readonly global::G.EndPointSecurityRequirement s_EvaluateSecurityRequirement0 =
            new global::G.EndPointSecurityRequirement
            {
                Authorizations = new global::G.EndPointAuthorizationRequirement[]
                {                    new global::G.EndPointAuthorizationRequirement
                    {
                        Type = "ApiKey",
                        Location = "Header",
                        Name = "x-api-key",
                        FriendlyName = "ApiKeyInHeader",
                    },
                },
            };

        private static readonly global::G.EndPointSecurityRequirement s_EvaluateSecurityRequirement1 =
            new global::G.EndPointSecurityRequirement
            {
                Authorizations = new global::G.EndPointAuthorizationRequirement[]
                {                    new global::G.EndPointAuthorizationRequirement
                    {
                        Type = "OAuth2",
                        Location = "Header",
                        Name = "",
                        FriendlyName = "OAuth2",
                    },
                },
            };
        private static readonly global::G.EndPointSecurityRequirement[] s_EvaluateSecurityRequirements =
            new global::G.EndPointSecurityRequirement[]
            {                s_EvaluateSecurityRequirement0,
                s_EvaluateSecurityRequirement1,
            };
        partial void PrepareEvaluateArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref int? requestTimeout,
            ref int? requestTimeoutMillis,
            global::G.EvaluateFactualConsistencyRequest request);
        partial void PrepareEvaluateRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            int? requestTimeout,
            int? requestTimeoutMillis,
            global::G.EvaluateFactualConsistencyRequest request);
        partial void ProcessEvaluateResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessEvaluateResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Evaluate factual consistency<br/>
        /// Evaluate the factual consistency of a generated text (like a summary) against source documents. This determines how accurately the generated text reflects the information in the source documents, helping identify potential hallucinations or misrepresentations.<br/>
        /// Use this API to programmatically validate generated content against trusted source materials—an essential capability for applications in high-integrity environments such as legal, healthcare, scientific publishing, and enterprise knowledge systems.<br/>
        /// The request body must include the following parameters:<br/>
        /// * `model_parameters:` Optionally specifies the evaluation model to use. Default is `hhem_v2.2`.<br/>
        /// * `generated_text`: The output text you want to evaluate, such as a model-generated summary, answer, or response.<br/>
        /// * `source_texts`: An array of source documents or passages used to verify the accuracy of the generated text.<br/>
        /// * `language`: The ISO 639-3 code representing the language of the provided texts (`eng` for English, `fra` for French).<br/>
        /// ### Example request<br/>
        /// This example evaluates whether a generated statement about the Eiffel Tower is factually accurate based on two reference documents.<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "generated_text": "The Eiffel Tower is located in Berlin.",<br/>
        ///   "source_texts": [<br/>
        ///     "The Eiffel Tower is a famous landmark located in Paris, France.",<br/>
        ///     "It was built in 1889 and remains one of the most visited monuments in the world."<br/>
        ///   ],<br/>
        ///   "language": "eng"<br/>
        /// }<br/>
        /// ```<br/>
        /// ### Example response<br/>
        /// The response includes a factual consistency score and probability estimates.<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "score": 0.23,<br/>
        ///   "p_consistent": 0.12,<br/>
        ///   "p_inconsistent": 0.88<br/>
        /// }<br/>
        /// ```<br/>
        /// * `score`: A normalized value between `0.0` and `1.0` that reflects the overall factual alignment between the generated text and the source texts. Higher scores indicate stronger consistency.<br/>
        /// * `p_consistent`: The estimated probability that the generated text is factually consistent with the sources.<br/>
        /// * `p_inconsistent`: The estimated probability that the generated text contains factual inaccuracies relative to the source documents.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.EvaluateFactualConsistencyResponse> EvaluateAsync(

            global::G.EvaluateFactualConsistencyRequest request,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareEvaluateArguments(
                httpClient: HttpClient,
                requestTimeout: ref requestTimeout,
                requestTimeoutMillis: ref requestTimeoutMillis,
                request: request);


            var __authorizations = global::G.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_EvaluateSecurityRequirements,
                operationName: "EvaluateAsync");

            var __pathBuilder = new global::G.PathBuilder(
                path: "/v2/evaluate_factual_consistency",
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
            PrepareEvaluateRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                requestTimeout: requestTimeout,
                requestTimeoutMillis: requestTimeoutMillis,
                request: request);

            using var __response = await global::G.Api.AutoSDKOAuth2Helpers.SendAsync(
                httpClient: HttpClient,
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                authorizations: __authorizations,
                oAuth2Coordinator: AutoSDKOAuth2State,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessEvaluateResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // Invalid request body.
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
                        __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_400 = global::G.BadRequestError.FromJson(__content_400, JsonSerializerOptions);
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
            // Permissions do not allow factual consistency evaluation.
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
            // Language not supported by the factual consistency service.
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
                ProcessEvaluateResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.EvaluateFactualConsistencyResponse.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::G.EvaluateFactualConsistencyResponse.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
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
        /// Evaluate factual consistency<br/>
        /// Evaluate the factual consistency of a generated text (like a summary) against source documents. This determines how accurately the generated text reflects the information in the source documents, helping identify potential hallucinations or misrepresentations.<br/>
        /// Use this API to programmatically validate generated content against trusted source materials—an essential capability for applications in high-integrity environments such as legal, healthcare, scientific publishing, and enterprise knowledge systems.<br/>
        /// The request body must include the following parameters:<br/>
        /// * `model_parameters:` Optionally specifies the evaluation model to use. Default is `hhem_v2.2`.<br/>
        /// * `generated_text`: The output text you want to evaluate, such as a model-generated summary, answer, or response.<br/>
        /// * `source_texts`: An array of source documents or passages used to verify the accuracy of the generated text.<br/>
        /// * `language`: The ISO 639-3 code representing the language of the provided texts (`eng` for English, `fra` for French).<br/>
        /// ### Example request<br/>
        /// This example evaluates whether a generated statement about the Eiffel Tower is factually accurate based on two reference documents.<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "generated_text": "The Eiffel Tower is located in Berlin.",<br/>
        ///   "source_texts": [<br/>
        ///     "The Eiffel Tower is a famous landmark located in Paris, France.",<br/>
        ///     "It was built in 1889 and remains one of the most visited monuments in the world."<br/>
        ///   ],<br/>
        ///   "language": "eng"<br/>
        /// }<br/>
        /// ```<br/>
        /// ### Example response<br/>
        /// The response includes a factual consistency score and probability estimates.<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "score": 0.23,<br/>
        ///   "p_consistent": 0.12,<br/>
        ///   "p_inconsistent": 0.88<br/>
        /// }<br/>
        /// ```<br/>
        /// * `score`: A normalized value between `0.0` and `1.0` that reflects the overall factual alignment between the generated text and the source texts. Higher scores indicate stronger consistency.<br/>
        /// * `p_consistent`: The estimated probability that the generated text is factually consistent with the sources.<br/>
        /// * `p_inconsistent`: The estimated probability that the generated text contains factual inaccuracies relative to the source documents.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="modelParameters">
        /// The model parameters for the evaluation.
        /// </param>
        /// <param name="generatedText">
        /// The generated text (e.g., summary or answer) to evaluate for factual consistency.
        /// </param>
        /// <param name="sourceTexts">
        /// The source documents or text snippets against which to evaluate factual consistency.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.EvaluateFactualConsistencyResponse> EvaluateAsync(
            string generatedText,
            global::System.Collections.Generic.IList<string> sourceTexts,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::G.EvaluateFactualConsistencyRequestModelParameters? modelParameters = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.EvaluateFactualConsistencyRequest
            {
                ModelParameters = modelParameters,
                GeneratedText = generatedText,
                SourceTexts = sourceTexts,
            };

            return await EvaluateAsync(
                requestTimeout: requestTimeout,
                requestTimeoutMillis: requestTimeoutMillis,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}