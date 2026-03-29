//HintName: G.IApi.FunctionsListVersions.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// List Function Versions
        /// </summary>
        /// <param name="offset">
        /// Default Value: 0
        /// </param>
        /// <param name="limit">
        /// Default Value: 20
        /// </param>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.FunctionsListVersionsResponse> FunctionsListVersionsAsync(
            global::System.Guid id,
            int? offset = default,
            int? limit = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}