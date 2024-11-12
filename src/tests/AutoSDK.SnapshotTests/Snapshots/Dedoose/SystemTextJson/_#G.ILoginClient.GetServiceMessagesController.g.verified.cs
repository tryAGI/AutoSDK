//HintName: G.ILoginClient.GetServiceMessagesController.g.cs
#nullable enable

namespace G
{
    public partial interface ILoginClient
    {
        /// <summary>
        /// Returns service messages.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.ServiceMessage>> GetServiceMessagesControllerAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}