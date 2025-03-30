//HintName: G.IInfoClient.GetHealthInfo.g.cs
#nullable enable

namespace G
{
    public partial interface IInfoClient
    {
        /// <summary>
        /// Get Health Info<br/>
        /// Get health information about the current deployment of LangSmith.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.HealthInfoGetResponse> GetHealthInfoAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}