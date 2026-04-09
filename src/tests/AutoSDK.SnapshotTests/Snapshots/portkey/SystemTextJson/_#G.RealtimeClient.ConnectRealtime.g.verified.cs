//HintName: G.RealtimeClient.ConnectRealtime.g.cs

#nullable enable

namespace G
{
    public partial class RealtimeClient
    {


        private static readonly global::G.EndPointSecurityRequirement s_ConnectRealtimeSecurityRequirement0 =
            new global::G.EndPointSecurityRequirement
            {
                Authorizations = new global::G.EndPointAuthorizationRequirement[]
                {                    new global::G.EndPointAuthorizationRequirement
                    {
                        Type = "ApiKey",
                        SchemeId = "PortkeyKey",
                        Location = "Header",
                        Name = "x-portkey-api-key",
                        FriendlyName = "PortkeyKey",
                    },
                    new global::G.EndPointAuthorizationRequirement
                    {
                        Type = "ApiKey",
                        SchemeId = "VirtualKey",
                        Location = "Header",
                        Name = "x-portkey-virtual-key",
                        FriendlyName = "VirtualKey",
                    },
                },
            };

        private static readonly global::G.EndPointSecurityRequirement s_ConnectRealtimeSecurityRequirement1 =
            new global::G.EndPointSecurityRequirement
            {
                Authorizations = new global::G.EndPointAuthorizationRequirement[]
                {                    new global::G.EndPointAuthorizationRequirement
                    {
                        Type = "ApiKey",
                        SchemeId = "PortkeyKey",
                        Location = "Header",
                        Name = "x-portkey-api-key",
                        FriendlyName = "PortkeyKey",
                    },
                    new global::G.EndPointAuthorizationRequirement
                    {
                        Type = "ApiKey",
                        SchemeId = "ProviderName",
                        Location = "Header",
                        Name = "x-portkey-provider",
                        FriendlyName = "ProviderName",
                    },
                    new global::G.EndPointAuthorizationRequirement
                    {
                        Type = "Http",
                        SchemeId = "ProviderAuth",
                        Location = "Header",
                        Name = "Bearer",
                        FriendlyName = "Bearer",
                    },
                },
            };

        private static readonly global::G.EndPointSecurityRequirement s_ConnectRealtimeSecurityRequirement2 =
            new global::G.EndPointSecurityRequirement
            {
                Authorizations = new global::G.EndPointAuthorizationRequirement[]
                {                    new global::G.EndPointAuthorizationRequirement
                    {
                        Type = "ApiKey",
                        SchemeId = "PortkeyKey",
                        Location = "Header",
                        Name = "x-portkey-api-key",
                        FriendlyName = "PortkeyKey",
                    },
                    new global::G.EndPointAuthorizationRequirement
                    {
                        Type = "ApiKey",
                        SchemeId = "Config",
                        Location = "Header",
                        Name = "x-portkey-config",
                        FriendlyName = "Config",
                    },
                },
            };

        private static readonly global::G.EndPointSecurityRequirement s_ConnectRealtimeSecurityRequirement3 =
            new global::G.EndPointSecurityRequirement
            {
                Authorizations = new global::G.EndPointAuthorizationRequirement[]
                {                    new global::G.EndPointAuthorizationRequirement
                    {
                        Type = "ApiKey",
                        SchemeId = "PortkeyKey",
                        Location = "Header",
                        Name = "x-portkey-api-key",
                        FriendlyName = "PortkeyKey",
                    },
                    new global::G.EndPointAuthorizationRequirement
                    {
                        Type = "ApiKey",
                        SchemeId = "CustomHost",
                        Location = "Header",
                        Name = "x-portkey-custom-host",
                        FriendlyName = "CustomHost",
                    },
                    new global::G.EndPointAuthorizationRequirement
                    {
                        Type = "ApiKey",
                        SchemeId = "ProviderName",
                        Location = "Header",
                        Name = "x-portkey-provider",
                        FriendlyName = "ProviderName",
                    },
                    new global::G.EndPointAuthorizationRequirement
                    {
                        Type = "Http",
                        SchemeId = "ProviderAuth",
                        Location = "Header",
                        Name = "Bearer",
                        FriendlyName = "Bearer",
                    },
                },
            };
        private static readonly global::G.EndPointSecurityRequirement[] s_ConnectRealtimeSecurityRequirements =
            new global::G.EndPointSecurityRequirement[]
            {                s_ConnectRealtimeSecurityRequirement0,
                s_ConnectRealtimeSecurityRequirement1,
                s_ConnectRealtimeSecurityRequirement2,
                s_ConnectRealtimeSecurityRequirement3,
            };
        partial void PrepareConnectRealtimeArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? xPortkeyTraceId,
            ref string? xPortkeySpanId,
            ref string? xPortkeyParentSpanId,
            ref string? xPortkeySpanName,
            object? xPortkeyMetadata,
            ref string? xPortkeyCacheNamespace,
            ref bool? xPortkeyCacheForceRefresh,
            ref string? model);
        partial void PrepareConnectRealtimeRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? xPortkeyTraceId,
            string? xPortkeySpanId,
            string? xPortkeyParentSpanId,
            string? xPortkeySpanName,
            object? xPortkeyMetadata,
            string? xPortkeyCacheNamespace,
            bool? xPortkeyCacheForceRefresh,
            string? model);
        partial void ProcessConnectRealtimeResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// Realtime<br/>
        /// Connect to the Realtime API endpoint.
        /// </summary>
        /// <param name="xPortkeyTraceId"></param>
        /// <param name="xPortkeySpanId"></param>
        /// <param name="xPortkeyParentSpanId"></param>
        /// <param name="xPortkeySpanName"></param>
        /// <param name="xPortkeyMetadata"></param>
        /// <param name="xPortkeyCacheNamespace"></param>
        /// <param name="xPortkeyCacheForceRefresh"></param>
        /// <param name="model"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task ConnectRealtimeAsync(
            string? xPortkeyTraceId = default,
            string? xPortkeySpanId = default,
            string? xPortkeyParentSpanId = default,
            string? xPortkeySpanName = default,
            object? xPortkeyMetadata = default,
            string? xPortkeyCacheNamespace = default,
            bool? xPortkeyCacheForceRefresh = default,
            string? model = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareConnectRealtimeArguments(
                httpClient: HttpClient,
                xPortkeyTraceId: ref xPortkeyTraceId,
                xPortkeySpanId: ref xPortkeySpanId,
                xPortkeyParentSpanId: ref xPortkeyParentSpanId,
                xPortkeySpanName: ref xPortkeySpanName,
                xPortkeyMetadata: xPortkeyMetadata,
                xPortkeyCacheNamespace: ref xPortkeyCacheNamespace,
                xPortkeyCacheForceRefresh: ref xPortkeyCacheForceRefresh,
                model: ref model);


            var __authorizations = global::G.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_ConnectRealtimeSecurityRequirements,
                operationName: "ConnectRealtimeAsync");

            var __pathBuilder = new global::G.PathBuilder(
                path: "/realtime",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddOptionalParameter("model", model) 
                ; 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            var __cookies = new global::System.Collections.Generic.List<string>();
            foreach (var __authorization in __authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2" ||
                    __authorization.Type == "OpenIdConnect")
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
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Cookie")
                {
                    var __cookieValue = global::System.Uri.EscapeDataString(__authorization.Value);
                    __cookies.Add($"{__authorization.Name}={__cookieValue}");
                }
            }

            if (__cookies.Count > 0)
            {
                __httpRequest.Headers.TryAddWithoutValidation("Cookie", string.Join("; ", __cookies));
            }

            if (xPortkeyTraceId != default)
            {
                __httpRequest.Headers.TryAddWithoutValidation("x-portkey-trace-id", xPortkeyTraceId.ToString());
            }
            if (xPortkeySpanId != default)
            {
                __httpRequest.Headers.TryAddWithoutValidation("x-portkey-span-id", xPortkeySpanId.ToString());
            }
            if (xPortkeyParentSpanId != default)
            {
                __httpRequest.Headers.TryAddWithoutValidation("x-portkey-parent-span-id", xPortkeyParentSpanId.ToString());
            }
            if (xPortkeySpanName != default)
            {
                __httpRequest.Headers.TryAddWithoutValidation("x-portkey-span-name", xPortkeySpanName.ToString());
            }
            if (xPortkeyMetadata != default)
            {
                __httpRequest.Headers.TryAddWithoutValidation("x-portkey-metadata", xPortkeyMetadata.ToString());
            }
            if (xPortkeyCacheNamespace != default)
            {
                __httpRequest.Headers.TryAddWithoutValidation("x-portkey-cache-namespace", xPortkeyCacheNamespace.ToString());
            }
            if (xPortkeyCacheForceRefresh != default)
            {
                __httpRequest.Headers.TryAddWithoutValidation("x-portkey-cache-force-refresh", xPortkeyCacheForceRefresh.ToString());
            }


            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareConnectRealtimeRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                xPortkeyTraceId: xPortkeyTraceId,
                xPortkeySpanId: xPortkeySpanId,
                xPortkeyParentSpanId: xPortkeyParentSpanId,
                xPortkeySpanName: xPortkeySpanName,
                xPortkeyMetadata: xPortkeyMetadata,
                xPortkeyCacheNamespace: xPortkeyCacheNamespace,
                xPortkeyCacheForceRefresh: xPortkeyCacheForceRefresh,
                model: model);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessConnectRealtimeResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // 
            if ((int)__response.StatusCode == 101)
            {
                string? __content_101 = null;
                global::System.Exception? __exception_101 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_101 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    }
                    else
                    {
                        __content_101 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_101 = __ex;
                }

                throw new global::G.ApiException(
                    message: __content_101 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_101,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_101,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // 
            if (!__response.IsSuccessStatusCode)
            {
                string? __content_default = null;
                global::System.Exception? __exception_default = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_default = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    }
                    else
                    {
                        __content_default = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_default = __ex;
                }

                throw new global::G.ApiException(
                    message: __content_default ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_default,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_default,
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