//HintName: G.ReposClient.ReposListForAuthenticatedUser.g.cs

#nullable enable

namespace G
{
    public partial class ReposClient
    {
        /// <summary>
        /// List repositories for the authenticated user
        /// </summary>
        /// <param name="visibility"></param>
        /// <param name="affiliation"></param>
        /// <param name="type"></param>
        /// <param name="sort"></param>
        /// <param name="direction"></param>
        /// <param name="perPage"></param>
        /// <param name="page"></param>
        /// <param name="since"></param>
        /// <param name="before"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<Repository>> ReposListForAuthenticatedUserAsync(
            ReposListForAuthenticatedUserVisibility visibility,
            string affiliation,
            ReposListForAuthenticatedUserType type,
            ReposListForAuthenticatedUserSort sort,
            ReposListForAuthenticatedUserDirection direction,
            int perPage,
            int page,
            global::System.DateTime since,
            global::System.DateTime before,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/user/repos?visibility={visibility}&affiliation={affiliation}&type={type}&sort={sort}&direction={direction}&per_page={perPage}&page={page}&since={since}&before={before}", global::System.UriKind.RelativeOrAbsolute));

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            return
                global::System.Text.Json.JsonSerializer.Deserialize<global::System.Collections.Generic.IList<Repository>?>(__content) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}