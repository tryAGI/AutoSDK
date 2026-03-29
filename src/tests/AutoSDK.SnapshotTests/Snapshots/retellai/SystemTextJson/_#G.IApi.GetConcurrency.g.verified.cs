//HintName: G.IApi.GetConcurrency.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Get the current concurrency and concurrency limit of the org
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetConcurrencyResponse> GetConcurrencyAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}