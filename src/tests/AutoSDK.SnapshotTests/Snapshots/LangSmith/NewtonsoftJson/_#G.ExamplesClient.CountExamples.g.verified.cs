//HintName: G.ExamplesClient.CountExamples.g.cs

#nullable enable

namespace G
{
    public partial class ExamplesClient
    {
        partial void PrepareCountExamplesArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Collections.Generic.IList<global::System.Guid>? id,
            ref global::G.AnyOf<global::System.DateTime?, string>? asOf,
            ref string? metadata,
            global::System.Collections.Generic.IList<string>? fullTextContains,
            global::System.Collections.Generic.IList<string>? splits,
            ref global::System.Guid? dataset,
            ref string? filter);
        partial void PrepareCountExamplesRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::System.Collections.Generic.IList<global::System.Guid>? id,
            global::G.AnyOf<global::System.DateTime?, string>? asOf,
            string? metadata,
            global::System.Collections.Generic.IList<string>? fullTextContains,
            global::System.Collections.Generic.IList<string>? splits,
            global::System.Guid? dataset,
            string? filter);
        partial void ProcessCountExamplesResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCountExamplesResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Count Examples<br/>
        /// Count all examples by query params
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
        /// <param name="filter"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<int> CountExamplesAsync(
            global::System.Collections.Generic.IList<global::System.Guid>? id = default,
            global::G.AnyOf<global::System.DateTime?, string>? asOf = default,
            string? metadata = default,
            global::System.Collections.Generic.IList<string>? fullTextContains = default,
            global::System.Collections.Generic.IList<string>? splits = default,
            global::System.Guid? dataset = default,
            string? filter = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareCountExamplesArguments(
                httpClient: HttpClient,
                id: id,
                asOf: ref asOf,
                metadata: ref metadata,
                fullTextContains: fullTextContains,
                splits: splits,
                dataset: ref dataset,
                filter: ref filter);

            var __pathBuilder = new PathBuilder(
                path: "/api/v1/examples/count",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("id", id, selector: static x => x.ToString(), delimiter: ",", explode: true) 
                .AddOptionalParameter("as_of", asOf?.ToString() ?? string.Empty) 
                .AddOptionalParameter("metadata", metadata) 
                .AddOptionalParameter("full_text_contains", fullTextContains, delimiter: ",", explode: true) 
                .AddOptionalParameter("splits", splits, delimiter: ",", explode: true) 
                .AddOptionalParameter("dataset", dataset?.ToString()) 
                .AddOptionalParameter("filter", filter) 
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
            PrepareCountExamplesRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                id: id,
                asOf: asOf,
                metadata: metadata,
                fullTextContains: fullTextContains,
                splits: splits,
                dataset: dataset,
                filter: filter);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessCountExamplesResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            var __content = await __response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: HttpClient,
                response: __response,
                content: ref __content);
            ProcessCountExamplesResponseContent(
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
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<int?>(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}