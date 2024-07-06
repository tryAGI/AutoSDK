//HintName: G.VectorStoresClient.ListFilesInVectorStoreBatch.g.cs

#nullable enable

namespace G
{
    public partial class VectorStoresClient
    {
        /// <summary>
        /// Returns a list of vector store files in a batch.
        /// </summary>
        /// <param name="vectorStoreId"></param>
        /// <param name="batchId"></param>
        /// <param name="limit"></param>
        /// <param name="order"></param>
        /// <param name="after"></param>
        /// <param name="before"></param>
        /// <param name="filter"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.ListVectorStoreFilesResponse> ListFilesInVectorStoreBatchAsync(
            string vectorStoreId,
            string batchId,
            int limit,
            global::G.ListFilesInVectorStoreBatchOrder order,
            string after,
            string before,
            global::G.ListFilesInVectorStoreBatchFilter filter,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var orderValue = order switch
            {
                global::G.ListFilesInVectorStoreBatchOrder.Asc => "asc",
                global::G.ListFilesInVectorStoreBatchOrder.Desc => "desc",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var filterValue = filter switch
            {
                global::G.ListFilesInVectorStoreBatchFilter.InProgress => "in_progress",
                global::G.ListFilesInVectorStoreBatchFilter.Completed => "completed",
                global::G.ListFilesInVectorStoreBatchFilter.Failed => "failed",
                global::G.ListFilesInVectorStoreBatchFilter.Cancelled => "cancelled",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/vector_stores/{vectorStoreId}/file_batches/{batchId}/files?limit={limit}&order={orderValue}&after={after}&before={before}&filter={filterValue}", global::System.UriKind.RelativeOrAbsolute));

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            try
            {
                response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException ex)
            {
                throw new global::System.InvalidOperationException(__content, ex);
            }

            return
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.ListVectorStoreFilesResponse?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}