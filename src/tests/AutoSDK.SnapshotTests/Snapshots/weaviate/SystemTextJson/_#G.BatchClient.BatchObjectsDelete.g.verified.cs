//HintName: G.BatchClient.BatchObjectsDelete.g.cs

#nullable enable

namespace G
{
    public partial class BatchClient
    {
        partial void PrepareBatchObjectsDeleteArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::G.BatchObjectsDeleteConsistencyLevel? consistencyLevel,
            ref string? tenant,
            global::G.BatchDelete request);
        partial void PrepareBatchObjectsDeleteRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::G.BatchObjectsDeleteConsistencyLevel? consistencyLevel,
            string? tenant,
            global::G.BatchDelete request);
        partial void ProcessBatchObjectsDeleteResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessBatchObjectsDeleteResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Batch delete objects.<br/>
        /// Batch delete objects that match a particular filter. &lt;br/&gt;&lt;br/&gt;The request body takes a single `where` filter and will delete all objects matched. &lt;br/&gt;&lt;br/&gt;Note that there is a limit to the number of objects to be deleted at once using this filter, in order to protect against unexpected memory surges and very-long-running requests. The default limit is 10,000 and may be configured by setting the `QUERY_MAXIMUM_RESULTS` environment variable. &lt;br/&gt;&lt;br/&gt;Objects are deleted in the same order that they would be returned in an equivalent Get query. To delete more objects than the limit, run the same query multiple times.
        /// </summary>
        /// <param name="consistencyLevel">
        /// Default Value: QUORUM
        /// </param>
        /// <param name="tenant"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.BatchDeleteResponse> BatchObjectsDeleteAsync(
            global::G.BatchDelete request,
            global::G.BatchObjectsDeleteConsistencyLevel? consistencyLevel = global::G.BatchObjectsDeleteConsistencyLevel.QUORUM,
            string? tenant = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareBatchObjectsDeleteArguments(
                httpClient: _httpClient,
                consistencyLevel: ref consistencyLevel,
                tenant: ref tenant,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: "/batch/objects",
                baseUri: _httpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("consistency_level", consistencyLevel?.ToValueString()) 
                .AddOptionalParameter("tenant", tenant) 
                ; 
            var __path = __pathBuilder.ToString();
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Delete,
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
            var __httpRequestContentBody = global::System.Text.Json.JsonSerializer.Serialize(request, JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareBatchObjectsDeleteRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                consistencyLevel: consistencyLevel,
                tenant: tenant,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessBatchObjectsDeleteResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessBatchObjectsDeleteResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize<global::G.BatchDeleteResponse?>(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Batch delete objects.<br/>
        /// Batch delete objects that match a particular filter. &lt;br/&gt;&lt;br/&gt;The request body takes a single `where` filter and will delete all objects matched. &lt;br/&gt;&lt;br/&gt;Note that there is a limit to the number of objects to be deleted at once using this filter, in order to protect against unexpected memory surges and very-long-running requests. The default limit is 10,000 and may be configured by setting the `QUERY_MAXIMUM_RESULTS` environment variable. &lt;br/&gt;&lt;br/&gt;Objects are deleted in the same order that they would be returned in an equivalent Get query. To delete more objects than the limit, run the same query multiple times.
        /// </summary>
        /// <param name="consistencyLevel">
        /// Default Value: QUORUM
        /// </param>
        /// <param name="tenant"></param>
        /// <param name="match">
        /// Outlines how to find the objects to be deleted.
        /// </param>
        /// <param name="output">
        /// Controls the verbosity of the output.<br/>
        /// Default Value: minimal
        /// </param>
        /// <param name="dryRun">
        /// If true, the call will show which objects would be matched using the specified filter without deleting any objects. &lt;br/&gt;&lt;br/&gt;Depending on the configured verbosity, you will either receive a count of affected objects, or a list of IDs.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.BatchDeleteResponse> BatchObjectsDeleteAsync(
            global::G.BatchObjectsDeleteConsistencyLevel? consistencyLevel = global::G.BatchObjectsDeleteConsistencyLevel.QUORUM,
            string? tenant = default,
            global::G.BatchDeleteMatch? match = default,
            global::G.BatchDeleteOutput? output = global::G.BatchDeleteOutput.Minimal,
            bool? dryRun = false,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.BatchDelete
            {
                Match = match,
                Output = output,
                DryRun = dryRun,
            };

            return await BatchObjectsDeleteAsync(
                consistencyLevel: consistencyLevel,
                tenant: tenant,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}