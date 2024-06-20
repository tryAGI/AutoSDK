//HintName: G.VectorStoresClient.ListVectorStores.g.cs

#nullable enable

namespace G
{
    public partial class VectorStoresClient
    {
        /// <summary>
        /// Returns a list of vector stores.
        /// </summary>
        /// <param name="limit"></param>
        /// <param name="order"></param>
        /// <param name="after"></param>
        /// <param name="before"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.ListVectorStoresResponse> ListVectorStoresAsync(
            int limit,
            global::G.ListVectorStoresOrder order,
            string after,
            string before,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var orderValue = order switch
            {
                global::G.ListVectorStoresOrder.Asc => "asc",
                global::G.ListVectorStoresOrder.Desc => "desc",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/vector_stores?limit={limit}&order={orderValue}&after={after}&before={before}", global::System.UriKind.RelativeOrAbsolute));

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
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.ListVectorStoresResponse?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}