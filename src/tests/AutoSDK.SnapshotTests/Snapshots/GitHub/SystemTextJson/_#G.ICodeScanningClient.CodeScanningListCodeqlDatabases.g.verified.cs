//HintName: G.ICodeScanningClient.CodeScanningListCodeqlDatabases.g.cs
#nullable enable

namespace G
{
    public partial interface ICodeScanningClient
    {
        /// <summary>
        /// List CodeQL databases for a repository<br/>
        /// Lists the CodeQL databases that are available in a repository.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `security_events` scope to use this endpoint with private or public repositories, or the `public_repo` scope to use this endpoint with only public repositories.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.CodeScanningCodeqlDatabase>> CodeScanningListCodeqlDatabasesAsync(
            string owner,
            string repo,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}