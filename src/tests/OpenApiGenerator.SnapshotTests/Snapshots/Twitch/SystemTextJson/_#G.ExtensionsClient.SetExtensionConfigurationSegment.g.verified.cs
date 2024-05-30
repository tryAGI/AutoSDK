//HintName: G.ExtensionsClient.SetExtensionConfigurationSegment.g.cs

#nullable enable

namespace G
{
    public partial class ExtensionsClient
    {
        /// <summary>
        /// Updates a configuration segment.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task SetExtensionConfigurationSegmentAsync(
            SetExtensionConfigurationSegmentBody request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Put,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + "/extensions/configurations", global::System.UriKind.RelativeOrAbsolute));
            httpRequest.Content = new global::System.Net.Http.StringContent(
                content: global::System.Text.Json.JsonSerializer.Serialize(request),
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();
        }

        /// <summary>
        /// Updates a configuration segment.
        /// </summary>
        /// <param name="extensionId"></param>
        /// <param name="segment"></param>
        /// <param name="broadcasterId"></param>
        /// <param name="content"></param>
        /// <param name="version"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task SetExtensionConfigurationSegmentAsync(
            string extensionId,
            SetExtensionConfigurationSegmentBodySegment segment,
            string? broadcasterId = default,
            string? content = default,
            string? version = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new SetExtensionConfigurationSegmentBody
            {
                ExtensionId = extensionId,
                Segment = segment,
                BroadcasterId = broadcasterId,
                Content = content,
                Version = version,
            };

            await SetExtensionConfigurationSegmentAsync(
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}