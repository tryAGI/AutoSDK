//HintName: G.ExtensionsClient.SetExtensionRequiredConfiguration.g.cs

#nullable enable

namespace G
{
    public partial class ExtensionsClient
    {
        /// <summary>
        /// Updates the extension’s required_configuration string.
        /// </summary>
        /// <param name="broadcasterId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task SetExtensionRequiredConfigurationAsync(
            string broadcasterId,
            global::G.SetExtensionRequiredConfigurationBody request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Put,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/extensions/required_configuration?broadcaster_id={broadcasterId}", global::System.UriKind.RelativeOrAbsolute));
            httpRequest.Content = new global::System.Net.Http.StringContent(
                content: global::System.Text.Json.JsonSerializer.Serialize(request, _jsonSerializerOptions),
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();
        }

        /// <summary>
        /// Updates the extension’s required_configuration string.
        /// </summary>
        /// <param name="broadcasterId"></param>
        /// <param name="extensionId"></param>
        /// <param name="extensionVersion"></param>
        /// <param name="requiredConfiguration"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task SetExtensionRequiredConfigurationAsync(
            string broadcasterId,
            string extensionId,
            string extensionVersion,
            string requiredConfiguration,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.SetExtensionRequiredConfigurationBody
            {
                ExtensionId = extensionId,
                ExtensionVersion = extensionVersion,
                RequiredConfiguration = requiredConfiguration,
            };

            await SetExtensionRequiredConfigurationAsync(
                broadcasterId: broadcasterId,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}