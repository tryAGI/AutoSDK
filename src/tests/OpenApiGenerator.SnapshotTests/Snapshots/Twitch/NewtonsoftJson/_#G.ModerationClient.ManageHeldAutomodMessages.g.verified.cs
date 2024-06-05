//HintName: G.ModerationClient.ManageHeldAutomodMessages.g.cs

#nullable enable

namespace G
{
    public partial class ModerationClient
    {
        /// <summary>
        /// Allow or deny the message that AutoMod flagged for review.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task ManageHeldAutomodMessagesAsync(
            ManageHeldAutoModMessagesBody request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + "/moderation/automod/message", global::System.UriKind.RelativeOrAbsolute));
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
        /// Allow or deny the message that AutoMod flagged for review.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="msgId"></param>
        /// <param name="action"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task ManageHeldAutomodMessagesAsync(
            string userId,
            string msgId,
            ManageHeldAutoModMessagesBodyAction action,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new ManageHeldAutoModMessagesBody
            {
                UserId = userId,
                MsgId = msgId,
                Action = action,
            };

            await ManageHeldAutomodMessagesAsync(
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}