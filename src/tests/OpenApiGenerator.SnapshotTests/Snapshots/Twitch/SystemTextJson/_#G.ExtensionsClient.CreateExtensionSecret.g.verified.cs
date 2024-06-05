//HintName: G.ExtensionsClient.CreateExtensionSecret.g.cs

#nullable enable

namespace G
{
    public partial class ExtensionsClient
    {
        /// <summary>
        /// Creates a shared secret used to sign and verify JWT tokens.
        /// </summary>
        /// <param name="extensionId"></param>
        /// <param name="delay"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<CreateExtensionSecretResponse> CreateExtensionSecretAsync(
            string extensionId,
            int delay,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/extensions/jwt/secrets?extension_id={extensionId}&delay={delay}", global::System.UriKind.RelativeOrAbsolute));

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            return
                global::System.Text.Json.JsonSerializer.Deserialize<CreateExtensionSecretResponse?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}