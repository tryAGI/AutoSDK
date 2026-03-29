//HintName: G.IEnvironmentsClient.EnvironmentsGetConnection.g.cs
#nullable enable

namespace G
{
    public partial interface IEnvironmentsClient
    {
        /// <summary>
        /// Get Environment Connection<br/>
        /// Get a specific environment connection by deviceId
        /// </summary>
        /// <param name="deviceId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.EnvironmentsGetConnectionResponse> EnvironmentsGetConnectionAsync(
            string deviceId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}