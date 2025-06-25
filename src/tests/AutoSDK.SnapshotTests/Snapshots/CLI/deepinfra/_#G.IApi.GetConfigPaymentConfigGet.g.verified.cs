//HintName: G.IApi.GetConfigPaymentConfigGet.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Get Config
        /// </summary>
        /// <param name="session"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ConfigOut> GetConfigPaymentConfigGetAsync(
            string? session = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}