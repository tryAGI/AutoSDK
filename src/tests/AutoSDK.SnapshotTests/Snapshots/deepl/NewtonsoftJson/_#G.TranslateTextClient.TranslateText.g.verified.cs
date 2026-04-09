//HintName: G.TranslateTextClient.TranslateText.g.cs

#nullable enable

namespace G
{
    public partial class TranslateTextClient
    {


        private static readonly global::G.EndPointSecurityRequirement s_TranslateTextSecurityRequirement0 =
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
        private static readonly global::G.EndPointSecurityRequirement[] s_TranslateTextSecurityRequirements =
            new global::G.EndPointSecurityRequirement[]
            {                s_TranslateTextSecurityRequirement0,
            };
        partial void PrepareTranslateTextArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::G.TranslateTextRequest request);
        partial void PrepareTranslateTextRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::G.TranslateTextRequest request);
        partial void ProcessTranslateTextResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessTranslateTextResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Request Translation<br/>
        /// The translate function.<br/>
        /// The total request body size must not exceed 128 KiB (128 · 1024 bytes). Please split up your text into multiple<br/>
        /// calls if it exceeds this limit.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.TranslateTextResponse> TranslateTextAsync(

            global::G.TranslateTextRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await TranslateTextAsResponseAsync(

                request: request,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
        /// <summary>
        /// Request Translation<br/>
        /// The translate function.<br/>
        /// The total request body size must not exceed 128 KiB (128 · 1024 bytes). Please split up your text into multiple<br/>
        /// calls if it exceeds this limit.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.AutoSDKHttpResponse<global::G.TranslateTextResponse>> TranslateTextAsResponseAsync(

            global::G.TranslateTextRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareTranslateTextArguments(
                httpClient: HttpClient,
                request: request);


            var __authorizations = global::G.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_TranslateTextSecurityRequirements,
                operationName: "TranslateTextAsync");

            var __pathBuilder = new global::G.PathBuilder(
                path: "/v2/translate",
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
            PrepareTranslateTextRequest(
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
            ProcessTranslateTextResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // 
            if ((int)__response.StatusCode == 400)
            {
                string? __content_400 = null;
                global::System.Exception? __exception_400 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    }
                    else
                    {
                        __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_400 = __ex;
                }

                throw new global::G.ApiException(
                    message: __content_400 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_400,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_400,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // 
            if ((int)__response.StatusCode == 403)
            {
                string? __content_403 = null;
                global::System.Exception? __exception_403 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_403 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    }
                    else
                    {
                        __content_403 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_403 = __ex;
                }

                throw new global::G.ApiException(
                    message: __content_403 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_403,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_403,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // 
            if ((int)__response.StatusCode == 404)
            {
                string? __content_404 = null;
                global::System.Exception? __exception_404 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_404 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    }
                    else
                    {
                        __content_404 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_404 = __ex;
                }

                throw new global::G.ApiException(
                    message: __content_404 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_404,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_404,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // 
            if ((int)__response.StatusCode == 413)
            {
                string? __content_413 = null;
                global::System.Exception? __exception_413 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_413 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    }
                    else
                    {
                        __content_413 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_413 = __ex;
                }

                throw new global::G.ApiException(
                    message: __content_413 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_413,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_413,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // 
            if ((int)__response.StatusCode == 414)
            {
                string? __content_414 = null;
                global::System.Exception? __exception_414 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_414 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    }
                    else
                    {
                        __content_414 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_414 = __ex;
                }

                throw new global::G.ApiException(
                    message: __content_414 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_414,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_414,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // 
            if ((int)__response.StatusCode == 429)
            {
                string? __content_429 = null;
                global::System.Exception? __exception_429 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_429 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    }
                    else
                    {
                        __content_429 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_429 = __ex;
                }

                throw new global::G.ApiException(
                    message: __content_429 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_429,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_429,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // 
            if ((int)__response.StatusCode == 456)
            {
                string? __content_456 = null;
                global::System.Exception? __exception_456 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_456 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    }
                    else
                    {
                        __content_456 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_456 = __ex;
                }

                throw new global::G.ApiException(
                    message: __content_456 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_456,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_456,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // 
            if ((int)__response.StatusCode == 500)
            {
                string? __content_500 = null;
                global::System.Exception? __exception_500 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_500 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    }
                    else
                    {
                        __content_500 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_500 = __ex;
                }

                throw new global::G.ApiException(
                    message: __content_500 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_500,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_500,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // 
            if ((int)__response.StatusCode == 504)
            {
                string? __content_504 = null;
                global::System.Exception? __exception_504 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_504 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    }
                    else
                    {
                        __content_504 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_504 = __ex;
                }

                throw new global::G.ApiException(
                    message: __content_504 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_504,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_504,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // 
            if ((int)__response.StatusCode == 529)
            {
                string? __content_529 = null;
                global::System.Exception? __exception_529 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_529 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    }
                    else
                    {
                        __content_529 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_529 = __ex;
                }

                throw new global::G.ApiException(
                    message: __content_529 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_529,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_529,
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
                ProcessTranslateTextResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    var __value = global::G.TranslateTextResponse.FromJson(__content, JsonSerializerOptions) ??
                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                    return new global::G.AutoSDKHttpResponse<global::G.TranslateTextResponse>(
                        statusCode: __response.StatusCode,
                        headers: global::G.AutoSDKHttpResponse.CreateHeaders(__response),
                        body: __value);
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

                    var __value = await global::G.TranslateTextResponse.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                    return new global::G.AutoSDKHttpResponse<global::G.TranslateTextResponse>(
                        statusCode: __response.StatusCode,
                        headers: global::G.AutoSDKHttpResponse.CreateHeaders(__response),
                        body: __value);
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
        /// Request Translation<br/>
        /// The translate function.<br/>
        /// The total request body size must not exceed 128 KiB (128 · 1024 bytes). Please split up your text into multiple<br/>
        /// calls if it exceeds this limit.
        /// </summary>
        /// <param name="text">
        /// Text to be translated. Only UTF-8-encoded plain text is supported. The parameter may be specified<br/>
        /// multiple times and translations are returned in the same order as they are requested. Each of the<br/>
        /// parameter values may contain multiple sentences.
        /// </param>
        /// <param name="sourceLang">
        /// Language of the text to be translated. If this parameter is omitted, the API will attempt to detect the language of the text and translate it.<br/>
        /// **Note:** Some languages only work with `model_type` set to `quality_optimized`. See [supported languages](https://developers.deepl.com/docs/getting-started/supported-languages) for more details.<br/>
        /// Example: EN
        /// </param>
        /// <param name="targetLang">
        /// The language into which the text should be translated.<br/>
        /// **Note:** Some languages only work with `model_type` set to `quality_optimized`. See [supported languages](https://developers.deepl.com/docs/getting-started/supported-languages) for more details.<br/>
        /// Example: DE
        /// </param>
        /// <param name="context">
        /// The `context` parameter makes it possible to include additional context that can influence a translation but is not translated itself. <br/>
        /// This additional context can potentially improve translation quality when translating short, low-context source texts such <br/>
        /// as product names on an e-commerce website, article headlines on a news website, or UI elements.<br/>
        /// For example...<br/>
        ///   - When translating a product name, you might pass the product description as context. <br/>
        ///   - When translating a news article headline, you might pass the first few sentences or a summary of the article as context.<br/>
        /// For best results, we recommend sending a few complete sentences of context in the same language as the source text. <br/>
        /// There is no size limit for the `context` parameter itself, but the request body size limit of 128 KiB still applies to <br/>
        /// all text translation requests. <br/>
        /// If you send a request with multiple `text` parameters, the `context` parameter will be applied to each one. <br/>
        /// Characters included in the `context` parameter will not be counted toward billing (i.e. there is no additional <br/>
        /// cost for using the `context` parameter, and only characters sent in the text parameter(s) will be counted toward <br/>
        /// billing for text translation even when the `context` parameter is included in a request).
        /// </param>
        /// <param name="showBilledCharacters">
        /// When true, the response will include the billed_characters parameter, giving the <br/>
        /// number of characters from the request that will be counted by DeepL for billing purposes.<br/>
        /// Note: for requests sent as URL-encoded forms, boolean values should be specified as "1" or "0".
        /// </param>
        /// <param name="splitSentences">
        /// Sets whether the translation engine should first split the input into sentences. For text translations where <br/>
        /// `tag_handling` is not set to `html`, the default value is `1`, meaning the engine splits on punctuation and on newlines.<br/>
        /// For text translations where `tag_handling=html`, the default value is `nonewlines`, meaning the engine splits on punctuation only, ignoring newlines.  <br/>
        /// The use of `nonewlines` as the default value for text translations where `tag_handling=html` is new behavior that was implemented in November 2022, <br/>
        /// when HTML handling was moved out of beta. <br/>
        /// Possible values are: <br/>
        ///  * `0` - no splitting at all, whole input is treated as one sentence<br/>
        ///  * `1` (default when `tag_handling` is not set to `html`) - splits on punctuation and on newlines<br/>
        ///  * `nonewlines` (default when `tag_handling=html`) - splits on punctuation only, ignoring newlines<br/>
        /// For applications that send one sentence per text parameter, we recommend setting `split_sentences` to `0`, in order to prevent the engine from splitting the sentence unintentionally.<br/>
        /// Please note that newlines will split sentences when `split_sentences=1`. We recommend cleaning files so they don't contain breaking sentences or setting the parameter `split_sentences` to `nonewlines`.<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="preserveFormatting">
        /// Sets whether the translation engine should respect the original formatting, even if it would usually correct some aspects.<br/>
        /// The formatting aspects affected by this setting include:<br/>
        ///  * Punctuation at the beginning and end of the sentence<br/>
        ///  * Upper/lower case at the beginning of the sentence<br/>
        /// Note: for requests sent as URL-encoded forms, boolean values should be specified as "1" or "0".<br/>
        /// Default Value: false
        /// </param>
        /// <param name="formality">
        /// Sets whether the translated text should lean towards formal or informal language.<br/>
        /// This feature currently only works for target languages<br/>
        /// `DE` (German),<br/>
        /// `FR` (French),<br/>
        /// `IT` (Italian),<br/>
        /// `ES` (Spanish),<br/>
        /// `ES-419` (Latin American Spanish),<br/>
        /// `NL` (Dutch),<br/>
        /// `PL` (Polish),<br/>
        /// `PT-BR` and `PT-PT` (Portuguese),<br/>
        /// `JA` (Japanese),<br/>
        /// and `RU` (Russian).<br/>
        /// Learn more about the plain/polite feature for Japanese [here](https://support.deepl.com/hc/en-us/articles/6306700061852-About-the-plain-polite-feature-in-Japanese).<br/>
        /// Setting this parameter with a target language that does not support formality will fail,<br/>
        /// unless one of the `prefer_...` options are used.<br/>
        /// Possible options are:<br/>
        ///   * `default` (default)<br/>
        ///   * `more` - for a more formal language<br/>
        ///   * `less` - for a more informal language<br/>
        ///   * `prefer_more` - for a more formal language if available, otherwise fallback to default formality<br/>
        ///   * `prefer_less` - for a more informal language if available, otherwise fallback to default formality<br/>
        /// Default Value: default
        /// </param>
        /// <param name="modelType">
        /// Specifies which DeepL model should be used for translation.<br/>
        /// Possible values are:<br/>
        /// * `latency_optimized` (default) - uses lower latency “classic” translation models, which support all language pairs;<br/>
        ///   default value<br/>
        /// * `quality_optimized` - uses higher latency, improved quality “next-gen” translation models, which support only a<br/>
        ///   subset of language pairs; if a language pair that is not supported by next-gen models is included in the<br/>
        ///   request, it will fail. Consider using prefer_quality_optimized instead.<br/>
        /// * `prefer_quality_optimized` - prioritizes use of higher latency, improved quality “next-gen” translation models,<br/>
        ///   which support only a subset of DeepL languages; if a request includes a language pair not supported by<br/>
        ///   next-gen models, the request will fall back to latency_optimized classic models.
        /// </param>
        /// <param name="glossaryId"></param>
        /// <param name="customInstructions">
        /// Specify a list of instructions to customize the translation behavior. Up to 10 custom instructions can be specified, each with a maximum of 300 characters.<br/>
        /// **Important:**  The target language must be `de`, `en`, `es`, `fr`, `it`, `ja`, `ko`, `zh` or any variants of these languages.<br/>
        /// **Note:** Any request with the `custom_instructions` parameter enabled will default to use the `quality_optimized` model type. Requests combining `custom_instructions` and `model_type: latency_optimized` will be rejected.
        /// </param>
        /// <param name="enableBetaLanguages">
        /// Enables 81 additional beta languages. See the full list at https://developers.deepl.com/docs/getting-started/supported-languages#beta-languages. **Note:** Any request with the `enable_beta_languages` parameter enabled will use `quality_optimized` models. Requests combining `enable_beta_languages: true` and `model_type: latency_optimized` will be rejected. Beta languages do not support formality or glossaries.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="tagHandling">
        /// Sets which kind of tags should be handled. Options currently available:<br/>
        ///  * `xml`: Enable XML tag handling; see [XML Handling](https://www.deepl.com/docs-api/xml).<br/>
        ///  * `html`: Enable HTML tag handling; see [HTML Handling](https://www.deepl.com/docs-api/html).
        /// </param>
        /// <param name="outlineDetection">
        /// The automatic detection of the XML structure won't yield best results in all XML files. You can disable this automatic mechanism altogether by setting the `outline_detection` parameter to `false` and selecting the tags that should be considered structure tags. This will split sentences using the `splitting_tags` parameter.<br/>
        /// In the example below, we achieve the same results as the automatic engine by disabling automatic detection with `outline_detection=0` and setting the parameters manually to `tag_handling=xml`, `split_sentences=nonewlines`,  and `splitting_tags=par,title`.<br/>
        ///  * Example request:<br/>
        ///    ```<br/>
        ///    &lt;document&gt;<br/>
        ///      &lt;meta&gt;<br/>
        ///        &lt;title&gt;A document's title&lt;/title&gt;<br/>
        ///      &lt;/meta&gt;<br/>
        ///      &lt;content&gt;<br/>
        ///        &lt;par&gt;This is the first sentence. Followed by a second one.&lt;/par&gt;<br/>
        ///        &lt;par&gt;This is the third sentence.&lt;/par&gt;<br/>
        ///      &lt;/content&gt;<br/>
        ///    &lt;/document&gt;<br/>
        ///    ```<br/>
        ///  * Example response:<br/>
        ///    ```<br/>
        ///    &lt;document&gt;<br/>
        ///      &lt;meta&gt;<br/>
        ///        &lt;title&gt;Der Titel eines Dokuments&lt;/title&gt;<br/>
        ///      &lt;/meta&gt;<br/>
        ///      &lt;content&gt;<br/>
        ///        &lt;par&gt;Das ist der erste Satz. Gefolgt von einem zweiten.&lt;/par&gt;<br/>
        ///        &lt;par&gt;Dies ist der dritte Satz.&lt;/par&gt;<br/>
        ///      &lt;/content&gt;<br/>
        ///    &lt;/document&gt;<br/>
        ///    ```<br/>
        /// While this approach is slightly more complicated, it allows for greater control over the structure of the translation output.<br/>
        /// Note: for requests sent as URL-encoded forms, boolean values should be specified as "1" or "0".<br/>
        /// Default Value: true
        /// </param>
        /// <param name="nonSplittingTags">
        /// List of XML tags which never cause splits.
        /// </param>
        /// <param name="splittingTags">
        /// List of XML tags which always cause splits.
        /// </param>
        /// <param name="ignoreTags">
        /// List of XML tags that indicate text not to be translated.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.TranslateTextResponse> TranslateTextAsync(
            global::System.Collections.Generic.IList<string> text,
            global::G.TargetLanguage targetLang,
            global::G.SourceLanguage? sourceLang = default,
            string? context = default,
            bool? showBilledCharacters = default,
            global::G.SplitSentencesOption? splitSentences = default,
            bool? preserveFormatting = default,
            global::G.Formality? formality = default,
            global::G.ModelType? modelType = default,
            string? glossaryId = default,
            global::System.Collections.Generic.IList<string>? customInstructions = default,
            bool? enableBetaLanguages = default,
            global::G.TagHandlingOption? tagHandling = default,
            bool? outlineDetection = default,
            global::System.Collections.Generic.IList<string>? nonSplittingTags = default,
            global::System.Collections.Generic.IList<string>? splittingTags = default,
            global::System.Collections.Generic.IList<string>? ignoreTags = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.TranslateTextRequest
            {
                Text = text,
                SourceLang = sourceLang,
                TargetLang = targetLang,
                Context = context,
                ShowBilledCharacters = showBilledCharacters,
                SplitSentences = splitSentences,
                PreserveFormatting = preserveFormatting,
                Formality = formality,
                ModelType = modelType,
                GlossaryId = glossaryId,
                CustomInstructions = customInstructions,
                EnableBetaLanguages = enableBetaLanguages,
                TagHandling = tagHandling,
                OutlineDetection = outlineDetection,
                NonSplittingTags = nonSplittingTags,
                SplittingTags = splittingTags,
                IgnoreTags = ignoreTags,
            };

            return await TranslateTextAsync(
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}