//HintName: G.WhispersClient.SendWhisper.g.cs

#nullable enable

namespace G
{
    public partial class WhispersClient
    {
        /// <summary>
        /// Sends a whisper message to the specified user.
        /// </summary>
        /// <param name="fromUserId"></param>
        /// <param name="toUserId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task SendWhisperAsync(
            string fromUserId,
            string toUserId,
            SendWhisperBody request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/whispers?from_user_id={fromUserId}&to_user_id={toUserId}", global::System.UriKind.RelativeOrAbsolute));
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
        /// Sends a whisper message to the specified user.
        /// </summary>
        /// <param name="fromUserId"></param>
        /// <param name="toUserId"></param>
        /// <param name="message"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task SendWhisperAsync(
            string fromUserId,
            string toUserId,
            string message,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new SendWhisperBody
            {
                Message = message,
            };

            await SendWhisperAsync(
                fromUserId: fromUserId,
                toUserId: toUserId,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}