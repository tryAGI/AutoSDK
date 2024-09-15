//HintName: G.IGeneralClient.GetCurrentInformation.g.cs
#nullable enable

namespace G
{
    public partial interface IGeneralClient
    {
        /// <summary>
        /// Returns information about the current IP.<br/>
        /// Returns information about the current IP.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.FullResponse> GetCurrentInformationAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}