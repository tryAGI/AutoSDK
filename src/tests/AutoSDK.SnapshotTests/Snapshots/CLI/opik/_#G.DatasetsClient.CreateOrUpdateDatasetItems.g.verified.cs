//HintName: G.DatasetsClient.CreateOrUpdateDatasetItems.g.cs

#nullable enable

namespace G
{
    public partial class DatasetsClient
    {
        partial void PrepareCreateOrUpdateDatasetItemsArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::G.DatasetItemBatchWrite request);
        partial void PrepareCreateOrUpdateDatasetItemsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::G.DatasetItemBatchWrite request);
        partial void ProcessCreateOrUpdateDatasetItemsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// Create/update dataset items<br/>
        /// Create/update dataset items based on dataset item id.<br/>
        /// Each item's 'id' field is the stable identifier and upsert key.<br/>
        /// Provide it to update an existing item, or omit it to create a new one.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task CreateOrUpdateDatasetItemsAsync(

            global::G.DatasetItemBatchWrite request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareCreateOrUpdateDatasetItemsArguments(
                httpClient: HttpClient,
                request: request);

            var __pathBuilder = new global::G.PathBuilder(
                path: "/v1/private/datasets/items",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Put,
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
            PrepareCreateOrUpdateDatasetItemsRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessCreateOrUpdateDatasetItemsResponse(
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

                    using var __content = await __response.Content.ReadAsStreamAsync(
#if NET5_0_OR_GREATER
                        cancellationToken
#endif
                    ).ConfigureAwait(false);

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
        /// Create/update dataset items<br/>
        /// Create/update dataset items based on dataset item id.<br/>
        /// Each item's 'id' field is the stable identifier and upsert key.<br/>
        /// Provide it to update an existing item, or omit it to create a new one.
        /// </summary>
        /// <param name="datasetName">
        /// If null, dataset_id must be provided
        /// </param>
        /// <param name="datasetId">
        /// If null, dataset_name must be provided
        /// </param>
        /// <param name="projectName">
        /// Optional. Associates the batch with a project by name. Ignored if project_id is provided.
        /// </param>
        /// <param name="projectId">
        /// Optional. Associates the batch with a project by ID. Takes precedence over project_name.
        /// </param>
        /// <param name="items"></param>
        /// <param name="batchGroupId">
        /// Optional batch group ID to group multiple batches into a single dataset version. If null, mutates the latest version instead of creating a new one.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task CreateOrUpdateDatasetItemsAsync(
            global::System.Collections.Generic.IList<global::G.DatasetItemWrite> items,
            string? datasetName = default,
            global::System.Guid? datasetId = default,
            string? projectName = default,
            global::System.Guid? projectId = default,
            global::System.Guid? batchGroupId = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {

            var __request = new global::G.DatasetItemBatchWrite
            {
                DatasetName = datasetName,
                DatasetId = datasetId,
                ProjectName = projectName,
                ProjectId = projectId,
                Items = items,
                BatchGroupId = batchGroupId,
            };

            await CreateOrUpdateDatasetItemsAsync(
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}