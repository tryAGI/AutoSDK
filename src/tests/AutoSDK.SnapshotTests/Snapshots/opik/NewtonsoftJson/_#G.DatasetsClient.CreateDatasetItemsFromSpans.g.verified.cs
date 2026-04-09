//HintName: G.DatasetsClient.CreateDatasetItemsFromSpans.g.cs

#nullable enable

namespace G
{
    public partial class DatasetsClient
    {
        partial void PrepareCreateDatasetItemsFromSpansArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::System.Guid datasetId,
            global::G.CreateDatasetItemsFromSpansRequest request);
        partial void PrepareCreateDatasetItemsFromSpansRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::System.Guid datasetId,
            global::G.CreateDatasetItemsFromSpansRequest request);
        partial void ProcessCreateDatasetItemsFromSpansResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// Create dataset items from spans<br/>
        /// Create dataset items from spans with enriched metadata
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task CreateDatasetItemsFromSpansAsync(
            global::System.Guid datasetId,

            global::G.CreateDatasetItemsFromSpansRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareCreateDatasetItemsFromSpansArguments(
                httpClient: HttpClient,
                datasetId: ref datasetId,
                request: request);

            var __pathBuilder = new global::G.PathBuilder(
                path: $"/v1/private/datasets/{datasetId}/items/from-spans",
                baseUri: HttpClient.BaseAddress);
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif
            var __httpRequestContentBody = request.ToJson(JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareCreateDatasetItemsFromSpansRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                datasetId: datasetId,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessCreateDatasetItemsFromSpansResponse(
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
        /// <summary>
        /// Create dataset items from spans<br/>
        /// Create dataset items from spans with enriched metadata
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="spanIds">
        /// Set of span IDs to add to the dataset
        /// </param>
        /// <param name="enrichmentOptions">
        /// Options for enriching span data
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task CreateDatasetItemsFromSpansAsync(
            global::System.Guid datasetId,
            global::System.Collections.Generic.IList<global::System.Guid> spanIds,
            global::G.SpanEnrichmentOptions enrichmentOptions,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.CreateDatasetItemsFromSpansRequest
            {
                SpanIds = spanIds,
                EnrichmentOptions = enrichmentOptions,
            };

            await CreateDatasetItemsFromSpansAsync(
                datasetId: datasetId,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}