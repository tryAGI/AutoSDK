//HintName: G.ExcerptClient.ExcerptUpdateExcerptText.g.cs

#nullable enable

namespace G
{
    public partial class ExcerptClient
    {
        /// <summary>
        /// UpdateExcerptText.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="projectIDL"></param>
        /// <param name="excerptId"></param>
        /// <param name="text"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<Excerpt> ExcerptUpdateExcerptTextAsync(
            string token,
            string projectIDL,
            string excerptId,
            string text,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/api/v1/excerpt/updateexcerpttext?projectIDL={projectIDL}&excerptId={excerptId}&text={text}", global::System.UriKind.RelativeOrAbsolute));

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            return
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<Excerpt>(content) ??
                throw new global::System.InvalidOperationException("Response deserialization failed for \"{content}\" ");
        }
    }
}