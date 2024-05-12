//HintName: G.Api.EndPoints.ListModels.g.cs

#nullable enable

namespace G
{
    public partial class Api
    {
        /// <summary>
        /// List models that are available locally.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<ModelsResponse> ListModelsAsync(
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            using var response = await _httpClient.GetAsync(
                new global::System.Uri("/tags", global::System.UriKind.RelativeOrAbsolute),
                cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            return
                global::System.Text.Json.JsonSerializer.Deserialize<ModelsResponse>(content) ??
                throw new global::System.InvalidOperationException("Response deserialization failed for \"{content}\" ");
        }
    }
}