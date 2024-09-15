//HintName: G.IDependencyGraphClient.DependencyGraphExportSbom.g.cs
#nullable enable

namespace G
{
    public partial interface IDependencyGraphClient
    {
        /// <summary>
        /// Export a software bill of materials (SBOM) for a repository.<br/>
        /// Exports the software bill of materials (SBOM) for a repository in SPDX JSON format.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.DependencyGraphSpdxSbom> DependencyGraphExportSbomAsync(
            string owner,
            string repo,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}