//HintName: G.DatasetsClient.ReadDatasets.g.cs

#nullable enable

namespace G
{
    public partial class DatasetsClient
    {
        partial void PrepareReadDatasetsArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Collections.Generic.IList<global::System.Guid>? id,
            ref global::G.AnyOf<global::System.Collections.Generic.IList<global::G.DataType>, global::G.DataType?>? dataType,
            ref string? name,
            ref string? nameContains,
            ref string? metadata,
            ref int? offset,
            ref int? limit,
            ref global::G.SortByDatasetColumn? sortBy,
            ref bool? sortByDesc,
            global::System.Collections.Generic.IList<global::System.Guid>? tagValueId);
        partial void PrepareReadDatasetsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::System.Collections.Generic.IList<global::System.Guid>? id,
            global::G.AnyOf<global::System.Collections.Generic.IList<global::G.DataType>, global::G.DataType?>? dataType,
            string? name,
            string? nameContains,
            string? metadata,
            int? offset,
            int? limit,
            global::G.SortByDatasetColumn? sortBy,
            bool? sortByDesc,
            global::System.Collections.Generic.IList<global::System.Guid>? tagValueId);
        partial void ProcessReadDatasetsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessReadDatasetsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Read Datasets<br/>
        /// Get all datasets by query params and owner.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="dataType"></param>
        /// <param name="name"></param>
        /// <param name="nameContains"></param>
        /// <param name="metadata"></param>
        /// <param name="offset">
        /// Default Value: 0
        /// </param>
        /// <param name="limit">
        /// Default Value: 100
        /// </param>
        /// <param name="sortBy">
        /// Enum for available dataset columns to sort by.
        /// </param>
        /// <param name="sortByDesc">
        /// Default Value: true
        /// </param>
        /// <param name="tagValueId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.Dataset>> ReadDatasetsAsync(
            global::System.Collections.Generic.IList<global::System.Guid>? id = default,
            global::G.AnyOf<global::System.Collections.Generic.IList<global::G.DataType>, global::G.DataType?>? dataType = default,
            string? name = default,
            string? nameContains = default,
            string? metadata = default,
            int? offset = default,
            int? limit = default,
            global::G.SortByDatasetColumn? sortBy = default,
            bool? sortByDesc = default,
            global::System.Collections.Generic.IList<global::System.Guid>? tagValueId = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareReadDatasetsArguments(
                httpClient: HttpClient,
                id: id,
                dataType: ref dataType,
                name: ref name,
                nameContains: ref nameContains,
                metadata: ref metadata,
                offset: ref offset,
                limit: ref limit,
                sortBy: ref sortBy,
                sortByDesc: ref sortByDesc,
                tagValueId: tagValueId);

            var __pathBuilder = new PathBuilder(
                path: "/api/v1/datasets",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("id", id, selector: static x => x.ToString(), delimiter: ",", explode: true) 
                .AddOptionalParameter("data_type", dataType?.ToString() ?? string.Empty) 
                .AddOptionalParameter("name", name) 
                .AddOptionalParameter("name_contains", nameContains) 
                .AddOptionalParameter("metadata", metadata) 
                .AddOptionalParameter("offset", offset?.ToString()) 
                .AddOptionalParameter("limit", limit?.ToString()) 
                .AddOptionalParameter("sort_by", sortBy?.ToValueString()) 
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
            PrepareReadDatasetsRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                id: id,
                dataType: dataType,
                name: name,
                nameContains: nameContains,
                metadata: metadata,
                offset: offset,
                limit: limit,
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
            ProcessReadDatasetsResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            var __content = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: HttpClient,
                response: __response,
                content: ref __content);
            ProcessReadDatasetsResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize<global::System.Collections.Generic.IList<global::G.Dataset>?>(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}