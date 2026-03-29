//HintName: G.IStatusClient.GetAllProviderStatus.g.cs
#nullable enable

namespace G
{
    public partial interface IStatusClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ResultProviderMetricsArrayString> GetAllProviderStatusAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}