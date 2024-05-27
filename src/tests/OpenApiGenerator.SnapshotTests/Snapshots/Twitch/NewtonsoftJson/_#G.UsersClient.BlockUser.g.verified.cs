﻿//HintName: G.UsersClient.BlockUser.g.cs

#nullable enable

namespace G
{
    public partial class UsersClient
    {
        /// <summary>
        /// Blocks the specified user from interacting with or having contact with the broadcaster.
        /// </summary>
        /// <param name="targetUserId"></param>
        /// <param name="sourceContext"></param>
        /// <param name="reason"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task BlockUserAsync(
            string targetUserId,
            BlockUserSourceContext sourceContext,
            BlockUserReason reason,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var sourceContextValue = sourceContext switch
            {
                BlockUserSourceContext.Chat => "chat",
                BlockUserSourceContext.Whisper => "whisper",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var reasonValue = reason switch
            {
                BlockUserReason.Harassment => "harassment",
                BlockUserReason.Spam => "spam",
                BlockUserReason.Other => "other",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Put,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/users/blocks?target_user_id={targetUserId}&source_context={sourceContextValue}&reason={reasonValue}", global::System.UriKind.RelativeOrAbsolute));

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();
        }
    }
}