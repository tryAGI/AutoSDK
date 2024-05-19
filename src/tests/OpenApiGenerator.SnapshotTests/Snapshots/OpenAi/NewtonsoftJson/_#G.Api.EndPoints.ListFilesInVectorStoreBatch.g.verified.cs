//HintName: G.Api.EndPoints.ListFilesInVectorStoreBatch.g.cs

#nullable enable

namespace G
{
    public partial class Api
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
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<ListVectorStoreFilesResponse> ListFilesInVectorStoreBatchAsync(
            string vectorStoreId,
            string batchId,
            int limit,
            ListFilesInVectorStoreBatchOrder order,
            string after,
            string before,
            ListFilesInVectorStoreBatchFilter filter,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var orderValue = order switch
            {
                ListFilesInVectorStoreBatchOrder.Asc => "asc",
                ListFilesInVectorStoreBatchOrder.Desc => "desc",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var filterValue = filter switch
            {
                ListFilesInVectorStoreBatchFilter.InProgress => "in_progress",
                ListFilesInVectorStoreBatchFilter.Completed => "completed",
                ListFilesInVectorStoreBatchFilter.Failed => "failed",
                ListFilesInVectorStoreBatchFilter.Cancelled => "cancelled",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: $"/vector_stores/{vectorStoreId}/file_batches/{batchId}/files?limit={limit}&order={orderValue}&after={after}&before={before}&filter={filterValue}");

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            return
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<ListVectorStoreFilesResponse>(content) ??
                throw new global::System.InvalidOperationException("Response deserialization failed for \"{content}\" ");
        }
    }
}