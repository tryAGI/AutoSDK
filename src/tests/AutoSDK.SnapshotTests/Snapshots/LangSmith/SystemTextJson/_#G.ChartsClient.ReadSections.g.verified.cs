//HintName: G.ChartsClient.ReadSections.g.cs

#nullable enable

namespace G
{
    public partial class ChartsClient
    {
        partial void PrepareReadSectionsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref int? limit,
            ref int? offset,
            ref string? titleContains,
            global::System.Collections.Generic.IList<global::System.Guid>? ids,
            ref string? sortBy,
            ref bool? sortByDesc,
            global::System.Collections.Generic.IList<global::System.Guid>? tagValueId);
        partial void PrepareReadSectionsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            int? limit,
            int? offset,
            string? titleContains,
            global::System.Collections.Generic.IList<global::System.Guid>? ids,
            string? sortBy,
            bool? sortByDesc,
            global::System.Collections.Generic.IList<global::System.Guid>? tagValueId);
        partial void ProcessReadSectionsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessReadSectionsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Read Sections<br/>
        /// Get all sections for the tenant.
        /// </summary>
        /// <param name="limit">
        /// Default Value: 100
        /// </param>
        /// <param name="offset">
        /// Default Value: 0
        /// </param>
        /// <param name="titleContains"></param>
        /// <param name="ids"></param>
        /// <param name="sortBy">
        /// Default Value: created_at
        /// </param>
        /// <param name="sortByDesc">
        /// Default Value: true
        /// </param>
        /// <param name="tagValueId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.CustomChartsSectionResponse>> ReadSectionsAsync(
            int? limit = 100,
            int? offset = 0,
            string? titleContains = default,
            global::System.Collections.Generic.IList<global::System.Guid>? ids = default,
            string? sortBy = "created_at",
            bool? sortByDesc = true,
            global::System.Collections.Generic.IList<global::System.Guid>? tagValueId = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareReadSectionsArguments(
                httpClient: HttpClient,
                limit: ref limit,
                offset: ref offset,
                titleContains: ref titleContains,
                ids: ids,
                sortBy: ref sortBy,
                sortByDesc: ref sortByDesc,
                tagValueId: tagValueId);

            var __pathBuilder = new PathBuilder(
                path: "/api/v1/charts/section",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("limit", limit?.ToString()) 
                .AddOptionalParameter("offset", offset?.ToString()) 
                .AddOptionalParameter("title_contains", titleContains) 
                .AddOptionalParameter("ids", ids, selector: static x => x.ToString(), delimiter: ",", explode: true) 
                .AddOptionalParameter("sort_by", sortBy) 
                .AddOptionalParameter("sort_by_desc", sortByDesc?.ToString()) 
                .AddOptionalParameter("tag_value_id", tagValueId, selector: static x => x.ToString(), delimiter: ",", explode: true) 
                ; 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

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
            PrepareReadSectionsRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                limit: limit,
                offset: offset,
                titleContains: titleContains,
                ids: ids,
                sortBy: sortBy,
                sortByDesc: sortByDesc,
                tagValueId: tagValueId);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessReadSectionsResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            var __content = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: HttpClient,
                response: __response,
                content: ref __content);
            ProcessReadSectionsResponseContent(
                httpClient: HttpClient,
                httpResponseMessage: __response,
                content: ref __content);

            try
            {
                __response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException __ex)
            {
                throw new global::System.InvalidOperationException(__content, __ex);
            }

            return
                global::System.Text.Json.JsonSerializer.Deserialize<global::System.Collections.Generic.IList<global::G.CustomChartsSectionResponse>?>(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}