//HintName: G.Api.EndPoints.ModifyMessage.g.cs

#nullable enable

namespace G
{
    public partial class Api
    {
        /// <summary>
        /// Modifies a message.
        /// </summary>
        /// <param name="threadId"></param>
        /// <param name="messageId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<MessageObject> ModifyMessageAsync(
            string threadId,
            string messageId,
            ModifyMessageRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: $"/threads/{threadId}/messages/{messageId}");
            httpRequest.Content = new global::System.Net.Http.StringContent(
                content: global::Newtonsoft.Json.JsonConvert.SerializeObject(request),
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            return
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<MessageObject>(content) ??
                throw new global::System.InvalidOperationException("Response deserialization failed for \"{content}\" ");
        }

        /// <summary>
        /// Modifies a message.
        /// </summary>
        /// <param name="threadId"></param>
        /// <param name="messageId"></param>
        /// <param name="metadata"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<MessageObject> ModifyMessageAsync(
            string threadId,
            string messageId,
            ModifyMessageRequestMetadata? metadata = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new ModifyMessageRequest
            {
                Metadata = metadata,
            };

            return await ModifyMessageAsync(
                threadId: threadId,
                messageId: messageId,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}