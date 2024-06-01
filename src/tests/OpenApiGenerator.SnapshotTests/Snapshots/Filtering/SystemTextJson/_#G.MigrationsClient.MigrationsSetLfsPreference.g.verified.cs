//HintName: G.MigrationsClient.MigrationsSetLfsPreference.g.cs

#nullable enable

namespace G
{
    public partial class MigrationsClient
    {
        /// <summary>
        /// Update Git LFS preference
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<Import> MigrationsSetLfsPreferenceAsync(
            string owner,
            string repo,
            MigrationsSetLfsPreferenceRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Patch,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/repos/{owner}/{repo}/import/lfs", global::System.UriKind.RelativeOrAbsolute));
            httpRequest.Content = new global::System.Net.Http.StringContent(
                content: global::System.Text.Json.JsonSerializer.Serialize(request),
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            return
                global::System.Text.Json.JsonSerializer.Deserialize<Import?>(__content) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Update Git LFS preference
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="useLfs"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<Import> MigrationsSetLfsPreferenceAsync(
            string owner,
            string repo,
            MigrationsSetLfsPreferenceRequestUseLfs useLfs,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new MigrationsSetLfsPreferenceRequest
            {
                UseLfs = useLfs,
            };

            return await MigrationsSetLfsPreferenceAsync(
                owner: owner,
                repo: repo,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}