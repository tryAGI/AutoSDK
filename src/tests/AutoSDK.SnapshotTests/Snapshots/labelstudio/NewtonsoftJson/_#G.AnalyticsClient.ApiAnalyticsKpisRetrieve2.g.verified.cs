//HintName: G.AnalyticsClient.ApiAnalyticsKpisRetrieve2.g.cs

#nullable enable

namespace G
{
    public partial class AnalyticsClient
    {
        partial void PrepareApiAnalyticsKpisRetrieve2Arguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::System.DateTime? end,
            ref string kpiKey,
            ref string? members,
            ref string? projects,
            ref bool? segmentByProject,
            ref string? segmentByTime,
            ref bool? segmentByUser,
            ref global::System.DateTime? start,
            ref string tz);
        partial void PrepareApiAnalyticsKpisRetrieve2Request(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::System.DateTime? end,
            string kpiKey,
            string? members,
            string? projects,
            bool? segmentByProject,
            string? segmentByTime,
            bool? segmentByUser,
            global::System.DateTime? start,
            string tz);
        partial void ProcessApiAnalyticsKpisRetrieve2Response(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessApiAnalyticsKpisRetrieve2ResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Get KPI data with optional segmentation<br/>
        /// Retrieve data for a specific KPI with support for filtering and segmentation. Can segment by time (hourly, daily, weekly, monthly, yearly), by user, or both (2D matrix). If no segmentation is specified, returns a single total value. Supports filtering by projects, members, and date range. Date filters are interpreted in the specified timezone (required parameter). Maximum 50 projects allowed per request for performance reasons.
        /// </summary>
        /// <param name="end"></param>
        /// <param name="kpiKey"></param>
        /// <param name="members"></param>
        /// <param name="projects"></param>
        /// <param name="segmentByProject"></param>
        /// <param name="segmentByTime"></param>
        /// <param name="segmentByUser"></param>
        /// <param name="start"></param>
        /// <param name="tz"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.KPIDetailResponse> ApiAnalyticsKpisRetrieve2Async(
            string kpiKey,
            string tz,
            global::System.DateTime? end = default,
            string? members = default,
            string? projects = default,
            bool? segmentByProject = default,
            string? segmentByTime = default,
            bool? segmentByUser = default,
            global::System.DateTime? start = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareApiAnalyticsKpisRetrieve2Arguments(
                httpClient: HttpClient,
                end: ref end,
                kpiKey: ref kpiKey,
                members: ref members,
                projects: ref projects,
                segmentByProject: ref segmentByProject,
                segmentByTime: ref segmentByTime,
                segmentByUser: ref segmentByUser,
                start: ref start,
                tz: ref tz);

            var __pathBuilder = new global::G.PathBuilder(
                path: $"/api/analytics/kpis/{kpiKey}",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddOptionalParameter("end", end?.ToString("yyyy-MM-ddTHH:mm:ssZ"))
                .AddOptionalParameter("members", members)
                .AddOptionalParameter("projects", projects)
                .AddOptionalParameter("segment_by_project", segmentByProject?.ToString().ToLowerInvariant())
                .AddOptionalParameter("segment_by_time", segmentByTime)
                .AddOptionalParameter("segment_by_user", segmentByUser?.ToString().ToLowerInvariant())
                .AddOptionalParameter("start", start?.ToString("yyyy-MM-ddTHH:mm:ssZ"))
                .AddRequiredParameter("tz", tz) 
                ; 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
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

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareApiAnalyticsKpisRetrieve2Request(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                end: end,
                kpiKey: kpiKey,
                members: members,
                projects: projects,
                segmentByProject: segmentByProject,
                segmentByTime: segmentByTime,
                segmentByUser: segmentByUser,
                start: start,
                tz: tz);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessApiAnalyticsKpisRetrieve2Response(
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
                ProcessApiAnalyticsKpisRetrieve2ResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.KPIDetailResponse.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::G.KPIDetailResponse.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
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