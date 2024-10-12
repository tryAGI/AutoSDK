//HintName: G.ExamplesClient.ReadExamples.g.cs

#nullable enable

namespace G
{
    public partial class ExamplesClient
    {
        partial void PrepareReadExamplesArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::G.AnyOf<global::System.Collections.Generic.IList<global::System.Guid>, object>? id,
            ref global::G.AnyOf<global::System.DateTime?, string>? asOf,
            ref global::G.AnyOf<string, object>? metadata,
            ref global::G.AnyOf<global::System.Collections.Generic.IList<string>, object>? fullTextContains,
            ref global::G.AnyOf<global::System.Collections.Generic.IList<string>, object>? splits,
            ref global::G.AnyOf<global::System.Guid?, object>? dataset,
            ref int? offset,
            ref int? limit,
            ref global::G.ExampleListOrder? order,
            ref global::G.AnyOf<double?, object>? randomSeed,
            global::System.Collections.Generic.IList<global::G.ExampleSelect>? select,
            ref global::G.AnyOf<string, object>? filter);
        partial void PrepareReadExamplesRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::G.AnyOf<global::System.Collections.Generic.IList<global::System.Guid>, object>? id,
            global::G.AnyOf<global::System.DateTime?, string>? asOf,
            global::G.AnyOf<string, object>? metadata,
            global::G.AnyOf<global::System.Collections.Generic.IList<string>, object>? fullTextContains,
            global::G.AnyOf<global::System.Collections.Generic.IList<string>, object>? splits,
            global::G.AnyOf<global::System.Guid?, object>? dataset,
            int? offset,
            int? limit,
            global::G.ExampleListOrder? order,
            global::G.AnyOf<double?, object>? randomSeed,
            global::System.Collections.Generic.IList<global::G.ExampleSelect>? select,
            global::G.AnyOf<string, object>? filter);
        partial void ProcessReadExamplesResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessReadExamplesResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Read Examples<br/>
        /// Get all examples by query params
        /// </summary>
        /// <param name="id"></param>
        /// <param name="asOf">
        /// Only modifications made on or before this time are included. If None, the latest version of the dataset is used.<br/>
        /// Default Value: latest
        /// </param>
        /// <param name="metadata"></param>
        /// <param name="fullTextContains"></param>
        /// <param name="splits"></param>
        /// <param name="dataset"></param>
        /// <param name="offset">
        /// Default Value: 0
        /// </param>
        /// <param name="limit">
        /// Default Value: 100
        /// </param>
        /// <param name="order"></param>
        /// <param name="randomSeed"></param>
        /// <param name="select">
        /// Default Value: [id, created_at, modified_at, name, dataset_id, source_run_id, metadata, inputs, outputs]
        /// </param>
        /// <param name="filter"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.Example>> ReadExamplesAsync(
            global::G.AnyOf<global::System.Collections.Generic.IList<global::System.Guid>, object>? id = default,
            global::G.AnyOf<global::System.DateTime?, string>? asOf = default,
            global::G.AnyOf<string, object>? metadata = default,
            global::G.AnyOf<global::System.Collections.Generic.IList<string>, object>? fullTextContains = default,
            global::G.AnyOf<global::System.Collections.Generic.IList<string>, object>? splits = default,
            global::G.AnyOf<global::System.Guid?, object>? dataset = default,
            int? offset = 0,
            int? limit = 100,
            global::G.ExampleListOrder? order = default,
            global::G.AnyOf<double?, object>? randomSeed = default,
            global::System.Collections.Generic.IList<global::G.ExampleSelect>? select = default,
            global::G.AnyOf<string, object>? filter = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareReadExamplesArguments(
                httpClient: _httpClient,
                id: ref id,
                asOf: ref asOf,
                metadata: ref metadata,
                fullTextContains: ref fullTextContains,
                splits: ref splits,
                dataset: ref dataset,
                offset: ref offset,
                limit: ref limit,
                order: ref order,
                randomSeed: ref randomSeed,
                select: select,
                filter: ref filter);

            var orderValue = order switch
            {
                global::G.ExampleListOrder.Recent => "recent",
                global::G.ExampleListOrder.Random => "random",
                global::G.ExampleListOrder.RecentlyCreated => "recently_created",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var __pathBuilder = new PathBuilder(
                path: "/api/v1/examples",
                baseUri: _httpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("id", id?.ToString() ?? string.Empty) 
                .AddOptionalParameter("as_of", asOf?.ToString() ?? string.Empty) 
                .AddOptionalParameter("metadata", metadata?.ToString() ?? string.Empty) 
                .AddOptionalParameter("full_text_contains", fullTextContains?.ToString() ?? string.Empty) 
                .AddOptionalParameter("splits", splits?.ToString() ?? string.Empty) 
                .AddOptionalParameter("dataset", dataset?.ToString() ?? string.Empty) 
                .AddOptionalParameter("offset", offset?.ToString()) 
                .AddOptionalParameter("limit", limit?.ToString()) 
                .AddOptionalParameter("order", orderValue?.ToString()) 
                .AddOptionalParameter("random_seed", randomSeed?.ToString() ?? string.Empty) 
                .AddOptionalParameter("filter", filter?.ToString() ?? string.Empty) 
                ; 
            var __path = __pathBuilder.ToString();
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            foreach (var _authorization in _authorizations)
            {
                if (_authorization.Type == "Http" ||
                    _authorization.Type == "OAuth2")
                {
                    httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: _authorization.Name,
                        parameter: _authorization.Value);
                }
                else if (_authorization.Type == "ApiKey" &&
                         _authorization.Location == "Header")
                {
                    httpRequest.Headers.Add(_authorization.Name, _authorization.Value);
                }
            }

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareReadExamplesRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                id: id,
                asOf: asOf,
                metadata: metadata,
                fullTextContains: fullTextContains,
                splits: splits,
                dataset: dataset,
                offset: offset,
                limit: limit,
                order: order,
                randomSeed: randomSeed,
                select: select,
                filter: filter);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessReadExamplesResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessReadExamplesResponseContent(
                httpClient: _httpClient,
                httpResponseMessage: response,
                content: ref __content);

            try
            {
                response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException ex)
            {
                throw new global::System.InvalidOperationException(__content, ex);
            }

            return
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::System.Collections.Generic.IList<global::G.Example>?>(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}