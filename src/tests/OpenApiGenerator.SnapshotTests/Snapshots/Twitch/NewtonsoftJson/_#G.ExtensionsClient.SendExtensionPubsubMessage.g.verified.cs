//HintName: G.ExtensionsClient.SendExtensionPubsubMessage.g.cs

#nullable enable

namespace G
{
    public partial class ExtensionsClient
    {
        /// <summary>
        /// Sends a message to one or more viewers.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task SendExtensionPubsubMessageAsync(
            SendExtensionPubSubMessageBody request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + "/extensions/pubsub", global::System.UriKind.RelativeOrAbsolute));
            httpRequest.Content = new global::System.Net.Http.StringContent(
                content: global::Newtonsoft.Json.JsonConvert.SerializeObject(request),
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();
        }

        /// <summary>
        /// Sends a message to one or more viewers.
        /// </summary>
        /// <param name="target"></param>
        /// <param name="broadcasterId"></param>
        /// <param name="isGlobalBroadcast"></param>
        /// <param name="message"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task SendExtensionPubsubMessageAsync(
            global::System.Collections.Generic.IList<SendExtensionPubSubMessageBodyTarget> target,
            string broadcasterId,
            string message,
            bool isGlobalBroadcast = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new SendExtensionPubSubMessageBody
            {
                Target = target,
                BroadcasterId = broadcasterId,
                IsGlobalBroadcast = isGlobalBroadcast,
                Message = message,
            };

            await SendExtensionPubsubMessageAsync(
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}