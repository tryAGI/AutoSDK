//HintName: G.IApi.CliVersionCliVersionGet.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Cli Version
        /// </summary>
        /// <param name="version"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> CliVersionCliVersionGetAsync(
            string version,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}