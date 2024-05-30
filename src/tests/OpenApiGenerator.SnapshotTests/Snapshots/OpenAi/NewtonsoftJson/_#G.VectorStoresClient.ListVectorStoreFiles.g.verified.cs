//HintName: G.VectorStoresClient.ListVectorStoreFiles.g.cs

#nullable enable

namespace G
{
    public partial class VectorStoresClient
    {
        /// <summary>
        /// Returns a list of vector store files.
        /// </summary>
        /// <param name="vectorStoreId"></param>
        /// <param name="limit"></param>
        /// <param name="order"></param>
        /// <param name="after"></param>
        /// <param name="before"></param>
        /// <param name="filter"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<ListVectorStoreFilesResponse> ListVectorStoreFilesAsync(
            string vectorStoreId,
            int limit,
            ListVectorStoreFilesOrder order,
            string after,
            string before,
            ListVectorStoreFilesFilter filter,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var orderValue = order switch
            {
                ListVectorStoreFilesOrder.Asc => "asc",
                ListVectorStoreFilesOrder.Desc => "desc",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var filterValue = filter switch
            {
                ListVectorStoreFilesFilter.InProgress => "in_progress",
                ListVectorStoreFilesFilter.Completed => "completed",
                ListVectorStoreFilesFilter.Failed => "failed",
                ListVectorStoreFilesFilter.Cancelled => "cancelled",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/vector_stores/{vectorStoreId}/files?limit={limit}&order={orderValue}&after={after}&before={before}&filter={filterValue}", global::System.UriKind.RelativeOrAbsolute));

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            return
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<ListVectorStoreFilesResponse?>(content) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{content}\" ");
        }
    }
}