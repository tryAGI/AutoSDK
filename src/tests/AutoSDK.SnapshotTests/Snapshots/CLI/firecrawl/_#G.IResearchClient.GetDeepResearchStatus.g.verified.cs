//HintName: G.IResearchClient.GetDeepResearchStatus.g.cs
#nullable enable

namespace G
{
    public partial interface IResearchClient
    {
        /// <summary>
        /// Get the status and results of a deep research operation
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetDeepResearchStatusResponse> GetDeepResearchStatusAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}