//HintName: G.ManageMultilingualGlossariesClient.GetMultilingualGlossaryEntries.g.cs

#nullable enable

namespace G
{
    public partial class ManageMultilingualGlossariesClient
    {


        private static readonly global::G.EndPointSecurityRequirement s_GetMultilingualGlossaryEntriesSecurityRequirement0 =
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
        private static readonly global::G.EndPointSecurityRequirement[] s_GetMultilingualGlossaryEntriesSecurityRequirements =
            new global::G.EndPointSecurityRequirement[]
            {                s_GetMultilingualGlossaryEntriesSecurityRequirement0,
            };
        partial void PrepareGetMultilingualGlossaryEntriesArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string glossaryId,
            ref global::G.GlossarySourceLanguage sourceLang,
            ref global::G.GlossaryTargetLanguage targetLang);
        partial void PrepareGetMultilingualGlossaryEntriesRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string glossaryId,
            global::G.GlossarySourceLanguage sourceLang,
            global::G.GlossaryTargetLanguage targetLang);
        partial void ProcessGetMultilingualGlossaryEntriesResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGetMultilingualGlossaryEntriesResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Retrieve Glossary Entries<br/>
        /// List the entries of a single glossary in tsv format.
        /// </summary>
        /// <param name="glossaryId"></param>
        /// <param name="sourceLang">
        /// The language in which the source texts in the glossary are specified.<br/>
        /// Example: en
        /// </param>
        /// <param name="targetLang">
        /// The language in which the target texts in the glossary are specified.<br/>
        /// Example: de
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.GlossaryDictionary> GetMultilingualGlossaryEntriesAsync(
            string glossaryId,
            global::G.GlossarySourceLanguage sourceLang,
            global::G.GlossaryTargetLanguage targetLang,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await GetMultilingualGlossaryEntriesAsResponseAsync(
                glossaryId: glossaryId,
                sourceLang: sourceLang,
                targetLang: targetLang,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
        /// <summary>
        /// Retrieve Glossary Entries<br/>
        /// List the entries of a single glossary in tsv format.
        /// </summary>
        /// <param name="glossaryId"></param>
        /// <param name="sourceLang">
        /// The language in which the source texts in the glossary are specified.<br/>
        /// Example: en
        /// </param>
        /// <param name="targetLang">
        /// The language in which the target texts in the glossary are specified.<br/>
        /// Example: de
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.AutoSDKHttpResponse<global::G.GlossaryDictionary>> GetMultilingualGlossaryEntriesAsResponseAsync(
            string glossaryId,
            global::G.GlossarySourceLanguage sourceLang,
            global::G.GlossaryTargetLanguage targetLang,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareGetMultilingualGlossaryEntriesArguments(
                httpClient: HttpClient,
                glossaryId: ref glossaryId,
                sourceLang: ref sourceLang,
                targetLang: ref targetLang);


            var __authorizations = global::G.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_GetMultilingualGlossaryEntriesSecurityRequirements,
                operationName: "GetMultilingualGlossaryEntriesAsync");

            var sourceLangValue = sourceLang switch
            {
                global::G.GlossarySourceLanguage.Ar => "ar",
                global::G.GlossarySourceLanguage.Bg => "bg",
                global::G.GlossarySourceLanguage.Cs => "cs",
                global::G.GlossarySourceLanguage.Da => "da",
                global::G.GlossarySourceLanguage.De => "de",
                global::G.GlossarySourceLanguage.El => "el",
                global::G.GlossarySourceLanguage.En => "en",
                global::G.GlossarySourceLanguage.Es => "es",
                global::G.GlossarySourceLanguage.Et => "et",
                global::G.GlossarySourceLanguage.Fi => "fi",
                global::G.GlossarySourceLanguage.Fr => "fr",
                global::G.GlossarySourceLanguage.He => "he",
                global::G.GlossarySourceLanguage.Hu => "hu",
                global::G.GlossarySourceLanguage.Id => "id",
                global::G.GlossarySourceLanguage.It => "it",
                global::G.GlossarySourceLanguage.Ja => "ja",
                global::G.GlossarySourceLanguage.Ko => "ko",
                global::G.GlossarySourceLanguage.Lt => "lt",
                global::G.GlossarySourceLanguage.Lv => "lv",
                global::G.GlossarySourceLanguage.Nb => "nb",
                global::G.GlossarySourceLanguage.Nl => "nl",
                global::G.GlossarySourceLanguage.Pl => "pl",
                global::G.GlossarySourceLanguage.Pt => "pt",
                global::G.GlossarySourceLanguage.Ro => "ro",
                global::G.GlossarySourceLanguage.Ru => "ru",
                global::G.GlossarySourceLanguage.Sk => "sk",
                global::G.GlossarySourceLanguage.Sl => "sl",
                global::G.GlossarySourceLanguage.Sv => "sv",
                global::G.GlossarySourceLanguage.Th => "th",
                global::G.GlossarySourceLanguage.Tr => "tr",
                global::G.GlossarySourceLanguage.Uk => "uk",
                global::G.GlossarySourceLanguage.Vi => "vi",
                global::G.GlossarySourceLanguage.Zh => "zh",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var targetLangValue = targetLang switch
            {
                global::G.GlossaryTargetLanguage.Ar => "ar",
                global::G.GlossaryTargetLanguage.Bg => "bg",
                global::G.GlossaryTargetLanguage.Cs => "cs",
                global::G.GlossaryTargetLanguage.Da => "da",
                global::G.GlossaryTargetLanguage.De => "de",
                global::G.GlossaryTargetLanguage.El => "el",
                global::G.GlossaryTargetLanguage.En => "en",
                global::G.GlossaryTargetLanguage.Es => "es",
                global::G.GlossaryTargetLanguage.Et => "et",
                global::G.GlossaryTargetLanguage.Fi => "fi",
                global::G.GlossaryTargetLanguage.Fr => "fr",
                global::G.GlossaryTargetLanguage.He => "he",
                global::G.GlossaryTargetLanguage.Hu => "hu",
                global::G.GlossaryTargetLanguage.Id => "id",
                global::G.GlossaryTargetLanguage.It => "it",
                global::G.GlossaryTargetLanguage.Ja => "ja",
                global::G.GlossaryTargetLanguage.Ko => "ko",
                global::G.GlossaryTargetLanguage.Lt => "lt",
                global::G.GlossaryTargetLanguage.Lv => "lv",
                global::G.GlossaryTargetLanguage.Nb => "nb",
                global::G.GlossaryTargetLanguage.Nl => "nl",
                global::G.GlossaryTargetLanguage.Pl => "pl",
                global::G.GlossaryTargetLanguage.Pt => "pt",
                global::G.GlossaryTargetLanguage.Ro => "ro",
                global::G.GlossaryTargetLanguage.Ru => "ru",
                global::G.GlossaryTargetLanguage.Sk => "sk",
                global::G.GlossaryTargetLanguage.Sl => "sl",
                global::G.GlossaryTargetLanguage.Sv => "sv",
                global::G.GlossaryTargetLanguage.Th => "th",
                global::G.GlossaryTargetLanguage.Tr => "tr",
                global::G.GlossaryTargetLanguage.Uk => "uk",
                global::G.GlossaryTargetLanguage.Vi => "vi",
                global::G.GlossaryTargetLanguage.Zh => "zh",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var __pathBuilder = new global::G.PathBuilder(
                path: $"/v3/glossaries/{glossaryId}/entries",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddRequiredParameter("source_lang", sourceLang.ToValueString())
                .AddRequiredParameter("target_lang", targetLang.ToValueString()) 
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
            PrepareGetMultilingualGlossaryEntriesRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                glossaryId: glossaryId,
                sourceLang: sourceLang,
                targetLang: targetLang);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessGetMultilingualGlossaryEntriesResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // Bad request. Please check error message and your parameters.
            if ((int)__response.StatusCode == 400)
            {
                string? __content_400 = null;
                global::System.Exception? __exception_400 = null;
                global::G.GetMultilingualGlossaryEntriesResponse? __value_400 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_400 = global::G.GetMultilingualGlossaryEntriesResponse.FromJson(__content_400, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_400 = global::G.GetMultilingualGlossaryEntriesResponse.FromJson(__content_400, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_400 = __ex;
                }

                throw new global::G.ApiException<global::G.GetMultilingualGlossaryEntriesResponse>(
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
            // 
            if ((int)__response.StatusCode == 401)
            {
                string? __content_401 = null;
                global::System.Exception? __exception_401 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_401 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    }
                    else
                    {
                        __content_401 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_401 = __ex;
                }

                throw new global::G.ApiException(
                    message: __content_401 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_401,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_401,
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
            if ((int)__response.StatusCode == 503)
            {
                string? __content_503 = null;
                global::System.Exception? __exception_503 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_503 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    }
                    else
                    {
                        __content_503 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_503 = __ex;
                }

                throw new global::G.ApiException(
                    message: __content_503 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_503,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_503,
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
                ProcessGetMultilingualGlossaryEntriesResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    var __value = global::G.GlossaryDictionary.FromJson(__content, JsonSerializerOptions) ??
                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                    return new global::G.AutoSDKHttpResponse<global::G.GlossaryDictionary>(
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

                    var __value = await global::G.GlossaryDictionary.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                    return new global::G.AutoSDKHttpResponse<global::G.GlossaryDictionary>(
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
    }
}