//HintName: G.IInformationClient.GetServiceMessages.g.cs
#nullable enable

namespace G
{
    public partial interface IInformationClient
    {
        /// <summary>
        /// Get Service Messages<br/>
        /// Returns the service messages from an XML source.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.ServiceMessage>> GetServiceMessagesAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}