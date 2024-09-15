//HintName: G.IDependencyGraphClient.DependencyGraphDiffRange.g.cs
#nullable enable

namespace G
{
    public partial interface IDependencyGraphClient
    {
        /// <summary>
        /// Get a diff of the dependencies between commits<br/>
        /// Gets the diff of the dependency changes between two commits of a repository, based on the changes to the dependency manifests made in those commits.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="basehead"></param>
        /// <param name="name"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.DependencyGraphDiffItem>> DependencyGraphDiffRangeAsync(
            string owner,
            string repo,
            string basehead,
            string? name = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}