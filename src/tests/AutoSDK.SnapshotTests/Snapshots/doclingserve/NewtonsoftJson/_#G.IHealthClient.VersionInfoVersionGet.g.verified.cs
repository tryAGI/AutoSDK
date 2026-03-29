//HintName: G.IHealthClient.VersionInfoVersionGet.g.cs
#nullable enable

namespace G
{
    public partial interface IHealthClient
    {
        /// <summary>
        /// Version Info
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> VersionInfoVersionGetAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}