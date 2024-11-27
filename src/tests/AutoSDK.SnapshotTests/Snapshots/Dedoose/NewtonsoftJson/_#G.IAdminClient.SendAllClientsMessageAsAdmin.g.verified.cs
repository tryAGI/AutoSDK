//HintName: G.IAdminClient.SendAllClientsMessageAsAdmin.g.cs
#nullable enable

namespace G
{
    public partial interface IAdminClient
    {
        /// <summary>
        /// SendAllClientsMessage<br/>
        /// SendAllClientsMessage
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> SendAllClientsMessageAsAdminAsync(
            global::G.SendAllClientsMessageRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// SendAllClientsMessage<br/>
        /// SendAllClientsMessage
        /// </summary>
        /// <param name="title"></param>
        /// <param name="message"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> SendAllClientsMessageAsAdminAsync(
            string title,
            string message,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}