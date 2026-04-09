//HintName: G.TemplatesClient.GetTemplatesByTemplateIDBuildsByBuildIDLogs.g.cs

#nullable enable

namespace G
{
    public partial class TemplatesClient
    {


        private static readonly global::G.EndPointSecurityRequirement s_GetTemplatesByTemplateIDBuildsByBuildIDLogsSecurityRequirement0 =
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

        private static readonly global::G.EndPointSecurityRequirement s_GetTemplatesByTemplateIDBuildsByBuildIDLogsSecurityRequirement1 =
            new global::G.EndPointSecurityRequirement
            {
                Authorizations = new global::G.EndPointAuthorizationRequirement[]
                {                    new global::G.EndPointAuthorizationRequirement
                    {
                        Type = "ApiKey",
                        Location = "Header",
                        Name = "X-API-Key",
                        FriendlyName = "ApiKeyAuth",
                    },
                },
            };

        private static readonly global::G.EndPointSecurityRequirement s_GetTemplatesByTemplateIDBuildsByBuildIDLogsSecurityRequirement2 =
            new global::G.EndPointSecurityRequirement
            {
                Authorizations = new global::G.EndPointAuthorizationRequirement[]
                {                    new global::G.EndPointAuthorizationRequirement
                    {
                        Type = "ApiKey",
                        Location = "Header",
                        Name = "X-Supabase-Team",
                        FriendlyName = "Supabase2TeamAuth",
                    },
                    new global::G.EndPointAuthorizationRequirement
                    {
                        Type = "ApiKey",
                        Location = "Header",
                        Name = "X-Supabase-Token",
                        FriendlyName = "Supabase1TokenAuth",
                    },
                },
            };
        private static readonly global::G.EndPointSecurityRequirement[] s_GetTemplatesByTemplateIDBuildsByBuildIDLogsSecurityRequirements =
            new global::G.EndPointSecurityRequirement[]
            {                s_GetTemplatesByTemplateIDBuildsByBuildIDLogsSecurityRequirement0,
                s_GetTemplatesByTemplateIDBuildsByBuildIDLogsSecurityRequirement1,
                s_GetTemplatesByTemplateIDBuildsByBuildIDLogsSecurityRequirement2,
            };
        partial void PrepareGetTemplatesByTemplateIDBuildsByBuildIDLogsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string templateID,
            ref string buildID,
            ref long? cursor,
            ref int? limit,
            ref global::G.LogsDirection? direction,
            ref global::G.LogLevel? level,
            ref global::G.LogsSource? source);
        partial void PrepareGetTemplatesByTemplateIDBuildsByBuildIDLogsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string templateID,
            string buildID,
            long? cursor,
            int? limit,
            global::G.LogsDirection? direction,
            global::G.LogLevel? level,
            global::G.LogsSource? source);
        partial void ProcessGetTemplatesByTemplateIDBuildsByBuildIDLogsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGetTemplatesByTemplateIDBuildsByBuildIDLogsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Get template build logs
        /// </summary>
        /// <param name="templateID"></param>
        /// <param name="buildID"></param>
        /// <param name="cursor"></param>
        /// <param name="limit">
        /// Default Value: 100
        /// </param>
        /// <param name="direction">
        /// Direction of the logs that should be returned
        /// </param>
        /// <param name="level">
        /// State of the sandbox
        /// </param>
        /// <param name="source">
        /// Source of the logs that should be returned
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.TemplateBuildLogsResponse> GetTemplatesByTemplateIDBuildsByBuildIDLogsAsync(
            string templateID,
            string buildID,
            long? cursor = default,
            int? limit = default,
            global::G.LogsDirection? direction = default,
            global::G.LogLevel? level = default,
            global::G.LogsSource? source = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareGetTemplatesByTemplateIDBuildsByBuildIDLogsArguments(
                httpClient: HttpClient,
                templateID: ref templateID,
                buildID: ref buildID,
                cursor: ref cursor,
                limit: ref limit,
                direction: ref direction,
                level: ref level,
                source: ref source);


            var __authorizations = global::G.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_GetTemplatesByTemplateIDBuildsByBuildIDLogsSecurityRequirements,
                operationName: "GetTemplatesByTemplateIDBuildsByBuildIDLogsAsync");

            var directionValue = direction switch
            {
                global::G.LogsDirection.LogsDirectionForward => "forward",
                global::G.LogsDirection.LogsDirectionBackward => "backward",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var levelValue = level switch
            {
                global::G.LogLevel.Debug => "debug",
                global::G.LogLevel.Info => "info",
                global::G.LogLevel.Warn => "warn",
                global::G.LogLevel.Error => "error",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var sourceValue = source switch
            {
                global::G.LogsSource.LogsSourceTemporary => "temporary",
                global::G.LogsSource.LogsSourcePersistent => "persistent",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var __pathBuilder = new global::G.PathBuilder(
                path: $"/templates/{templateID}/builds/{buildID}/logs",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddOptionalParameter("cursor", cursor?.ToString())
                .AddOptionalParameter("limit", limit?.ToString())
                .AddOptionalParameter("direction", direction?.ToValueString())
                .AddOptionalParameter("level", level?.ToValueString())
                .AddOptionalParameter("source", source?.ToValueString()) 
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
            PrepareGetTemplatesByTemplateIDBuildsByBuildIDLogsRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                templateID: templateID,
                buildID: buildID,
                cursor: cursor,
                limit: limit,
                direction: direction,
                level: level,
                source: source);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessGetTemplatesByTemplateIDBuildsByBuildIDLogsResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // Authentication error
            if ((int)__response.StatusCode == 401)
            {
                string? __content_401 = null;
                global::System.Exception? __exception_401 = null;
                global::G.Error? __value_401 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_401 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_401 = global::G.Error.FromJson(__content_401, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_401 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_401 = global::G.Error.FromJson(__content_401, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_401 = __ex;
                }

                throw new global::G.ApiException<global::G.Error>(
                    message: __content_401 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_401,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_401,
                    ResponseObject = __value_401,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // Not found
            if ((int)__response.StatusCode == 404)
            {
                string? __content_404 = null;
                global::System.Exception? __exception_404 = null;
                global::G.Error? __value_404 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_404 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_404 = global::G.Error.FromJson(__content_404, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_404 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_404 = global::G.Error.FromJson(__content_404, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_404 = __ex;
                }

                throw new global::G.ApiException<global::G.Error>(
                    message: __content_404 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_404,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_404,
                    ResponseObject = __value_404,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // Server error
            if ((int)__response.StatusCode == 500)
            {
                string? __content_500 = null;
                global::System.Exception? __exception_500 = null;
                global::G.Error? __value_500 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_500 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_500 = global::G.Error.FromJson(__content_500, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_500 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_500 = global::G.Error.FromJson(__content_500, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_500 = __ex;
                }

                throw new global::G.ApiException<global::G.Error>(
                    message: __content_500 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_500,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_500,
                    ResponseObject = __value_500,
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
                ProcessGetTemplatesByTemplateIDBuildsByBuildIDLogsResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.TemplateBuildLogsResponse.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::G.TemplateBuildLogsResponse.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
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
    }
}