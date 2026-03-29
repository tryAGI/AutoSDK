//HintName: G.ISandboxesClient.CreateSandboxesBySandboxIDPause.g.cs
#nullable enable

namespace G
{
    public partial interface ISandboxesClient
    {
        /// <summary>
        /// Pause the sandbox
        /// </summary>
        /// <param name="sandboxID"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task CreateSandboxesBySandboxIDPauseAsync(
            string sandboxID,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}