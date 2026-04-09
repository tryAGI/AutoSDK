//HintName: G.DataSourcesClient.Oauth2Callback.g.cs

#nullable enable

namespace G
{
    public partial class DataSourcesClient
    {


        private static readonly global::G.EndPointSecurityRequirement s_Oauth2CallbackSecurityRequirement0 =
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
        private static readonly global::G.EndPointSecurityRequirement[] s_Oauth2CallbackSecurityRequirements =
            new global::G.EndPointSecurityRequirement[]
            {                s_Oauth2CallbackSecurityRequirement0,
            };
        partial void PrepareOauth2CallbackArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string state,
            ref string code,
            ref string? error,
            ref string? errorDescription);
        partial void PrepareOauth2CallbackRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string state,
            string code,
            string? error,
            string? errorDescription);
        partial void ProcessOauth2CallbackResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// OAuth2 callback for data source authorization<br/>
        /// OAuth2 callback endpoint for completing data source authorization.<br/>
        /// This endpoint is called by OAuth2 providers after user authorization.<br/>
        /// It exchanges the authorization code for access tokens and stores them<br/>
        /// securely for the data source.<br/>
        /// Args:<br/>
        ///     state: OAuth2 state parameter used for CSRF protection<br/>
        ///     code: Authorization code from the OAuth2 provider<br/>
        ///     error: OAuth2 error code if authorization was denied or failed<br/>
        ///     error_description: Human-readable description of the error<br/>
        /// Returns:<br/>
        ///     Redirect to the data source details page on success<br/>
        /// Raises:<br/>
        ///     OAuth2TokenExchangeError: When OAuth2 provider returns an error<br/>
        ///     InvalidStateError: When state parameter is invalid or expired
        /// </summary>
        /// <param name="state">
        /// OAuth2 state parameter for CSRF protection
        /// </param>
        /// <param name="code">
        /// Authorization code from OAuth2 provider
        /// </param>
        /// <param name="error">
        /// OAuth2 error code if authorization failed
        /// </param>
        /// <param name="errorDescription">
        /// Human-readable error description
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task Oauth2CallbackAsync(
            string state,
            string code,
            string? error = default,
            string? errorDescription = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareOauth2CallbackArguments(
                httpClient: HttpClient,
                state: ref state,
                code: ref code,
                error: ref error,
                errorDescription: ref errorDescription);


            var __authorizations = global::G.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_Oauth2CallbackSecurityRequirements,
                operationName: "Oauth2CallbackAsync");

            var __pathBuilder = new global::G.PathBuilder(
                path: "/v1/data_sources/oauth2/callback",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddRequiredParameter("state", state)
                .AddRequiredParameter("code", code)
                .AddOptionalParameter("error", error)
                .AddOptionalParameter("error_description", errorDescription) 
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
            PrepareOauth2CallbackRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                state: state,
                code: code,
                error: error,
                errorDescription: errorDescription);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessOauth2CallbackResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // Successful authorization, redirect to data source
            if ((int)__response.StatusCode == 307)
            {
                string? __content_307 = null;
                global::System.Exception? __exception_307 = null;
                string? __value_307 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_307 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_307 = global::Newtonsoft.Json.JsonConvert.DeserializeObject<string?>(__content_307, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_307 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_307 = global::Newtonsoft.Json.JsonConvert.DeserializeObject<string?>(__content_307, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_307 = __ex;
                }

                throw new global::G.ApiException<string>(
                    message: __content_307 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_307,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_307,
                    ResponseObject = __value_307,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
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
            // Validation Error
            if ((int)__response.StatusCode == 422)
            {
                string? __content_422 = null;
                global::System.Exception? __exception_422 = null;
                global::G.HTTPValidationError? __value_422 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_422 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_422 = global::G.HTTPValidationError.FromJson(__content_422, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_422 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_422 = global::G.HTTPValidationError.FromJson(__content_422, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_422 = __ex;
                }

                throw new global::G.ApiException<global::G.HTTPValidationError>(
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

                try
                {
                    __response.EnsureSuccessStatusCode();

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