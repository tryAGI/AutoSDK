//HintName: G.IAdminClient.AdminSendAllClientsMessage.g.cs
#nullable enable

namespace G
{
    public partial interface IAdminClient
    {
        /// <summary>
        /// SendAllClientsMessage.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="title"></param>
        /// <param name="message"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> AdminSendAllClientsMessageAsync(
            string? token = default,
            string? title = default,
            string? message = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}