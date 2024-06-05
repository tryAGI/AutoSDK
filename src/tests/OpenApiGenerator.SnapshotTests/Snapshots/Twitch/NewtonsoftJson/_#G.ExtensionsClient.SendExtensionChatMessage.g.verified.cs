//HintName: G.ExtensionsClient.SendExtensionChatMessage.g.cs

#nullable enable

namespace G
{
    public partial class ExtensionsClient
    {
        /// <summary>
        /// Sends a message to the specified broadcaster’s chat room.
        /// </summary>
        /// <param name="broadcasterId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task SendExtensionChatMessageAsync(
            string broadcasterId,
            SendExtensionChatMessageBody request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/extensions/chat?broadcaster_id={broadcasterId}", global::System.UriKind.RelativeOrAbsolute));
            httpRequest.Content = new global::System.Net.Http.StringContent(
                content: global::Newtonsoft.Json.JsonConvert.SerializeObject(request, _jsonSerializerOptions),
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();
        }

        /// <summary>
        /// Sends a message to the specified broadcaster’s chat room.
        /// </summary>
        /// <param name="broadcasterId"></param>
        /// <param name="text"></param>
        /// <param name="extensionId"></param>
        /// <param name="extensionVersion"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task SendExtensionChatMessageAsync(
            string broadcasterId,
            string text,
            string extensionId,
            string extensionVersion,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new SendExtensionChatMessageBody
            {
                Text = text,
                ExtensionId = extensionId,
                ExtensionVersion = extensionVersion,
            };

            await SendExtensionChatMessageAsync(
                broadcasterId: broadcasterId,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}