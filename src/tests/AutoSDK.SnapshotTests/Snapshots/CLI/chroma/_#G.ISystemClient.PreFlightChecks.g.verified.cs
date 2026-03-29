//HintName: G.ISystemClient.PreFlightChecks.g.cs
#nullable enable

namespace G
{
    public partial interface ISystemClient
    {
        /// <summary>
        /// Pre-flight checks<br/>
        /// Returns basic readiness information.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ChecklistResponse> PreFlightChecksAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}