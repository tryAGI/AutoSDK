//HintName: G.SchemaClient.SchemaRetrieve.g.cs

#nullable enable

namespace G
{
    public partial class SchemaClient
    {
        partial void PrepareSchemaRetrieveArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::G.SchemaRetrieveFormat? format,
            ref global::G.SchemaRetrieveLang? lang);
        partial void PrepareSchemaRetrieveRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::G.SchemaRetrieveFormat? format,
            global::G.SchemaRetrieveLang? lang);
        partial void ProcessSchemaRetrieveResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessSchemaRetrieveResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// OpenApi3 schema for this API. Format can be selected via content negotiation.<br/>
        /// - YAML: application/vnd.oai.openapi<br/>
        /// - JSON: application/vnd.oai.openapi+json
        /// </summary>
        /// <param name="format"></param>
        /// <param name="lang"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<string> SchemaRetrieveAsync(
            global::G.SchemaRetrieveFormat? format = default,
            global::G.SchemaRetrieveLang? lang = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareSchemaRetrieveArguments(
                httpClient: HttpClient,
                format: ref format,
                lang: ref lang);

            var formatValue = format switch
            {
                global::G.SchemaRetrieveFormat.Json => "json",
                global::G.SchemaRetrieveFormat.Yaml => "yaml",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var langValue = lang switch
            {
                global::G.SchemaRetrieveLang.Af => "af",
                global::G.SchemaRetrieveLang.Ar => "ar",
                global::G.SchemaRetrieveLang.ArDz => "ar-dz",
                global::G.SchemaRetrieveLang.Ast => "ast",
                global::G.SchemaRetrieveLang.Az => "az",
                global::G.SchemaRetrieveLang.Be => "be",
                global::G.SchemaRetrieveLang.Bg => "bg",
                global::G.SchemaRetrieveLang.Bn => "bn",
                global::G.SchemaRetrieveLang.Br => "br",
                global::G.SchemaRetrieveLang.Bs => "bs",
                global::G.SchemaRetrieveLang.Ca => "ca",
                global::G.SchemaRetrieveLang.Ckb => "ckb",
                global::G.SchemaRetrieveLang.Cs => "cs",
                global::G.SchemaRetrieveLang.Cy => "cy",
                global::G.SchemaRetrieveLang.Da => "da",
                global::G.SchemaRetrieveLang.De => "de",
                global::G.SchemaRetrieveLang.Dsb => "dsb",
                global::G.SchemaRetrieveLang.El => "el",
                global::G.SchemaRetrieveLang.En => "en",
                global::G.SchemaRetrieveLang.EnAu => "en-au",
                global::G.SchemaRetrieveLang.EnGb => "en-gb",
                global::G.SchemaRetrieveLang.Eo => "eo",
                global::G.SchemaRetrieveLang.Es => "es",
                global::G.SchemaRetrieveLang.EsAr => "es-ar",
                global::G.SchemaRetrieveLang.EsCo => "es-co",
                global::G.SchemaRetrieveLang.EsMx => "es-mx",
                global::G.SchemaRetrieveLang.EsNi => "es-ni",
                global::G.SchemaRetrieveLang.EsVe => "es-ve",
                global::G.SchemaRetrieveLang.Et => "et",
                global::G.SchemaRetrieveLang.Eu => "eu",
                global::G.SchemaRetrieveLang.Fa => "fa",
                global::G.SchemaRetrieveLang.Fi => "fi",
                global::G.SchemaRetrieveLang.Fr => "fr",
                global::G.SchemaRetrieveLang.Fy => "fy",
                global::G.SchemaRetrieveLang.Ga => "ga",
                global::G.SchemaRetrieveLang.Gd => "gd",
                global::G.SchemaRetrieveLang.Gl => "gl",
                global::G.SchemaRetrieveLang.He => "he",
                global::G.SchemaRetrieveLang.Hi => "hi",
                global::G.SchemaRetrieveLang.Hr => "hr",
                global::G.SchemaRetrieveLang.Hsb => "hsb",
                global::G.SchemaRetrieveLang.Hu => "hu",
                global::G.SchemaRetrieveLang.Hy => "hy",
                global::G.SchemaRetrieveLang.Ia => "ia",
                global::G.SchemaRetrieveLang.Id => "id",
                global::G.SchemaRetrieveLang.Ig => "ig",
                global::G.SchemaRetrieveLang.Io => "io",
                global::G.SchemaRetrieveLang.Is => "is",
                global::G.SchemaRetrieveLang.It => "it",
                global::G.SchemaRetrieveLang.Ja => "ja",
                global::G.SchemaRetrieveLang.Ka => "ka",
                global::G.SchemaRetrieveLang.Kab => "kab",
                global::G.SchemaRetrieveLang.Kk => "kk",
                global::G.SchemaRetrieveLang.Km => "km",
                global::G.SchemaRetrieveLang.Kn => "kn",
                global::G.SchemaRetrieveLang.Ko => "ko",
                global::G.SchemaRetrieveLang.Ky => "ky",
                global::G.SchemaRetrieveLang.Lb => "lb",
                global::G.SchemaRetrieveLang.Lt => "lt",
                global::G.SchemaRetrieveLang.Lv => "lv",
                global::G.SchemaRetrieveLang.Mk => "mk",
                global::G.SchemaRetrieveLang.Ml => "ml",
                global::G.SchemaRetrieveLang.Mn => "mn",
                global::G.SchemaRetrieveLang.Mr => "mr",
                global::G.SchemaRetrieveLang.Ms => "ms",
                global::G.SchemaRetrieveLang.My => "my",
                global::G.SchemaRetrieveLang.Nb => "nb",
                global::G.SchemaRetrieveLang.Ne => "ne",
                global::G.SchemaRetrieveLang.Nl => "nl",
                global::G.SchemaRetrieveLang.Nn => "nn",
                global::G.SchemaRetrieveLang.Os => "os",
                global::G.SchemaRetrieveLang.Pa => "pa",
                global::G.SchemaRetrieveLang.Pl => "pl",
                global::G.SchemaRetrieveLang.Pt => "pt",
                global::G.SchemaRetrieveLang.PtBr => "pt-br",
                global::G.SchemaRetrieveLang.Ro => "ro",
                global::G.SchemaRetrieveLang.Ru => "ru",
                global::G.SchemaRetrieveLang.Sk => "sk",
                global::G.SchemaRetrieveLang.Sl => "sl",
                global::G.SchemaRetrieveLang.Sq => "sq",
                global::G.SchemaRetrieveLang.Sr => "sr",
                global::G.SchemaRetrieveLang.SrLatn => "sr-latn",
                global::G.SchemaRetrieveLang.Sv => "sv",
                global::G.SchemaRetrieveLang.Sw => "sw",
                global::G.SchemaRetrieveLang.Ta => "ta",
                global::G.SchemaRetrieveLang.Te => "te",
                global::G.SchemaRetrieveLang.Tg => "tg",
                global::G.SchemaRetrieveLang.Th => "th",
                global::G.SchemaRetrieveLang.Tk => "tk",
                global::G.SchemaRetrieveLang.Tr => "tr",
                global::G.SchemaRetrieveLang.Tt => "tt",
                global::G.SchemaRetrieveLang.Udm => "udm",
                global::G.SchemaRetrieveLang.Ug => "ug",
                global::G.SchemaRetrieveLang.Uk => "uk",
                global::G.SchemaRetrieveLang.Ur => "ur",
                global::G.SchemaRetrieveLang.Uz => "uz",
                global::G.SchemaRetrieveLang.Vi => "vi",
                global::G.SchemaRetrieveLang.ZhHans => "zh-hans",
                global::G.SchemaRetrieveLang.ZhHant => "zh-hant",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var __pathBuilder = new global::G.PathBuilder(
                path: "/api/schema/",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("format", formatValue?.ToString()) 
                .AddOptionalParameter("lang", langValue?.ToString()) 
                ; 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareSchemaRetrieveRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                format: format,
                lang: lang);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessSchemaRetrieveResponse(
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
                ProcessSchemaRetrieveResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();
                }
                catch (global::System.Net.Http.HttpRequestException __ex)
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

                return __content;
            }
            else
            {
                try
                {
                    __response.EnsureSuccessStatusCode();
                }
                catch (global::System.Net.Http.HttpRequestException __ex)
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

                var __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                    cancellationToken
#endif
                ).ConfigureAwait(false);

                return __content;
            }
        }
    }
}