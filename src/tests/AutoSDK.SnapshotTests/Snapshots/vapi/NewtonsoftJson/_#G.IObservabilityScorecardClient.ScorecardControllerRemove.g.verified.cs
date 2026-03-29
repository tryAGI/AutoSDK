//HintName: G.IObservabilityScorecardClient.ScorecardControllerRemove.g.cs
#nullable enable

namespace G
{
    public partial interface IObservabilityScorecardClient
    {
        /// <summary>
        /// Delete Scorecard
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Scorecard> ScorecardControllerRemoveAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}