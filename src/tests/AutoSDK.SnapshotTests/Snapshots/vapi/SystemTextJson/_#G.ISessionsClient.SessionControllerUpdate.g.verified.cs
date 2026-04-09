//HintName: G.ISessionsClient.SessionControllerUpdate.g.cs
#nullable enable

namespace G
{
    public partial interface ISessionsClient
    {
        /// <summary>
        /// Update Session
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Session> SessionControllerUpdateAsync(
            string id,

            global::G.UpdateSessionDTO request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Session
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name">
        /// This is the new name for the session. Maximum length is 40 characters.
        /// </param>
        /// <param name="status">
        /// This is the new status for the session.
        /// </param>
        /// <param name="expirationSeconds">
        /// Session expiration time in seconds. Defaults to 24 hours (86400 seconds) if not set.<br/>
        /// Example: 86400
        /// </param>
        /// <param name="messages">
        /// This is the updated array of chat messages.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.Session> SessionControllerUpdateAsync(
            string id,
            string? name = default,
            global::G.UpdateSessionDTOStatus? status = default,
            double? expirationSeconds = default,
            global::System.Collections.Generic.IList<global::G.OneOf<global::G.SystemMessage, global::G.UserMessage, global::G.AssistantMessage, global::G.ToolMessage, global::G.DeveloperMessage>>? messages = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}