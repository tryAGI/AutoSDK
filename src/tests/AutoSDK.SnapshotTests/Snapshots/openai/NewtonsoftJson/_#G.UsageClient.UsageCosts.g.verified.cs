﻿//HintName: G.UsageClient.UsageCosts.g.cs

#nullable enable

namespace G
{
    public partial class UsageClient
    {
        partial void PrepareUsageCostsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref int startTime,
            ref int? endTime,
            ref global::G.UsageCostsBucketWidth? bucketWidth,
            global::System.Collections.Generic.IList<string>? projectIds,
            global::System.Collections.Generic.IList<global::G.UsageCostsGroupByItem>? groupBy,
            ref int? limit,
            ref string? page);
        partial void PrepareUsageCostsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            int startTime,
            int? endTime,
            global::G.UsageCostsBucketWidth? bucketWidth,
            global::System.Collections.Generic.IList<string>? projectIds,
            global::System.Collections.Generic.IList<global::G.UsageCostsGroupByItem>? groupBy,
            int? limit,
            string? page);
        partial void ProcessUsageCostsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessUsageCostsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Get costs details for the organization.
        /// </summary>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <param name="bucketWidth">
        /// Default Value: 1d
        /// </param>
        /// <param name="projectIds"></param>
        /// <param name="groupBy"></param>
        /// <param name="limit">
        /// Default Value: 7
        /// </param>
        /// <param name="page"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.UsageResponse> UsageCostsAsync(
            int startTime,
            int? endTime = default,
            global::G.UsageCostsBucketWidth? bucketWidth = default,
            global::System.Collections.Generic.IList<string>? projectIds = default,
            global::System.Collections.Generic.IList<global::G.UsageCostsGroupByItem>? groupBy = default,
            int? limit = default,
            string? page = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareUsageCostsArguments(
                httpClient: HttpClient,
                startTime: ref startTime,
                endTime: ref endTime,
                bucketWidth: ref bucketWidth,
                projectIds: projectIds,
                groupBy: groupBy,
                limit: ref limit,
                page: ref page);

            var bucketWidthValue = bucketWidth switch
            {
                global::G.UsageCostsBucketWidth.x1d => "1d",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var __pathBuilder = new global::G.PathBuilder(
                path: "/organization/costs",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder 
                .AddRequiredParameter("start_time", startTime.ToString()) 
                .AddOptionalParameter("end_time", endTime?.ToString()) 
                .AddOptionalParameter("bucket_width", bucketWidth?.ToValueString()) 
                .AddOptionalParameter("project_ids", projectIds, delimiter: ",", explode: true) 
                .AddOptionalParameter("group_by", groupBy, selector: static x => x.ToValueString(), delimiter: ",", explode: true) 
                .AddOptionalParameter("limit", limit?.ToString()) 
                .AddOptionalParameter("page", page) 
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
            PrepareUsageCostsRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                startTime: startTime,
                endTime: endTime,
                bucketWidth: bucketWidth,
                projectIds: projectIds,
                groupBy: groupBy,
                limit: limit,
                page: page);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessUsageCostsResponse(
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
                ProcessUsageCostsResponseContent(
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

                return
                    global::G.UsageResponse.FromJson(__content, JsonSerializerOptions) ??
                    throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
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

                using var __content = await __response.Content.ReadAsStreamAsync(
#if NET5_0_OR_GREATER
                    cancellationToken
#endif
                ).ConfigureAwait(false);

                return
                    await global::G.UsageResponse.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
                    throw new global::System.InvalidOperationException("Response deserialization failed.");
            }
        }
    }
}