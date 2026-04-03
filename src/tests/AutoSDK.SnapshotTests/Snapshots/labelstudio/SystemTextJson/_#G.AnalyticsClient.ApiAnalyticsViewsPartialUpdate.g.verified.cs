//HintName: G.AnalyticsClient.ApiAnalyticsViewsPartialUpdate.g.cs

#nullable enable

namespace G
{
    public partial class AnalyticsClient
    {
        partial void PrepareApiAnalyticsViewsPartialUpdateArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::System.Guid uuid,
            global::G.PatchedAnalyticsViewRequest request);
        partial void PrepareApiAnalyticsViewsPartialUpdateRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::System.Guid uuid,
            global::G.PatchedAnalyticsViewRequest request);
        partial void ProcessApiAnalyticsViewsPartialUpdateResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessApiAnalyticsViewsPartialUpdateResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

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
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.AnalyticsView> ApiAnalyticsViewsPartialUpdateAsync(
            global::System.Guid uuid,

            global::G.PatchedAnalyticsViewRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareApiAnalyticsViewsPartialUpdateArguments(
                httpClient: HttpClient,
                uuid: ref uuid,
                request: request);

            var __pathBuilder = new global::G.PathBuilder(
                path: $"/api/analytics/views/{uuid}/",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: new global::System.Net.Http.HttpMethod("PATCH"),
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
            var __httpRequestContentBody = request.ToJson(JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareApiAnalyticsViewsPartialUpdateRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                uuid: uuid,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessApiAnalyticsViewsPartialUpdateResponse(
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
                ProcessApiAnalyticsViewsPartialUpdateResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.AnalyticsView.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::G.AnalyticsView.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
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
        /// <param name="dashboardType">
        /// * `overview` - Overview<br/>
        /// * `member_performance` - Member Performance
        /// </param>
        /// <param name="filters"></param>
        /// <param name="name"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.AnalyticsView> ApiAnalyticsViewsPartialUpdateAsync(
            global::System.Guid uuid,
            global::G.DashboardTypeEnum? dashboardType = default,
            object? filters = default,
            string? name = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.PatchedAnalyticsViewRequest
            {
                DashboardType = dashboardType,
                Filters = filters,
                Name = name,
            };

            return await ApiAnalyticsViewsPartialUpdateAsync(
                uuid: uuid,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}