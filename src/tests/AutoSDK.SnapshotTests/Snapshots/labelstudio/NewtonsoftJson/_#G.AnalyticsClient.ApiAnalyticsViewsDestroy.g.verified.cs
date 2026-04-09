//HintName: G.AnalyticsClient.ApiAnalyticsViewsDestroy.g.cs

#nullable enable

namespace G
{
    public partial class AnalyticsClient
    {


        private static readonly global::G.EndPointSecurityRequirement s_ApiAnalyticsViewsDestroySecurityRequirement0 =
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
        private static readonly global::G.EndPointSecurityRequirement[] s_ApiAnalyticsViewsDestroySecurityRequirements =
            new global::G.EndPointSecurityRequirement[]
            {                s_ApiAnalyticsViewsDestroySecurityRequirement0,
            };
        partial void PrepareApiAnalyticsViewsDestroyArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::System.Guid uuid);
        partial void PrepareApiAnalyticsViewsDestroyRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::System.Guid uuid);
        partial void ProcessApiAnalyticsViewsDestroyResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// CRUD endpoints for per-user analytics saved views.<br/>
        /// All routes are gated behind the ``fflag_feat_fit_1424_analytics_saved_views``<br/>
        /// feature flag AND the same ``should_check_analytics_permission`` helper used<br/>
        /// by the KPI endpoints, so a user who cannot access the analytics dashboard<br/>
        /// cannot read view metadata even via a shared link.<br/>
        /// Lookup uses ``uuid`` (not PK) so the primary key is never exposed.<br/>
        /// Access rules<br/>
        /// ------------<br/>
        /// * list / create   — scoped to requesting user + active org<br/>
        /// * retrieve        — any org member who passes the analytics permission check<br/>
        ///                     (enables shared-link UX: ``?view=&lt;uuid&gt;`` in the URL)<br/>
        /// * update / destroy — owner-only
        /// </summary>
        /// <param name="uuid"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task ApiAnalyticsViewsDestroyAsync(
            global::System.Guid uuid,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareApiAnalyticsViewsDestroyArguments(
                httpClient: HttpClient,
                uuid: ref uuid);


            var __authorizations = global::G.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_ApiAnalyticsViewsDestroySecurityRequirements,
                operationName: "ApiAnalyticsViewsDestroyAsync");

            var __pathBuilder = new global::G.PathBuilder(
                path: $"/api/analytics/views/{uuid}/",
                baseUri: HttpClient.BaseAddress);
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Delete,
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
            PrepareApiAnalyticsViewsDestroyRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                uuid: uuid);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessApiAnalyticsViewsDestroyResponse(
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