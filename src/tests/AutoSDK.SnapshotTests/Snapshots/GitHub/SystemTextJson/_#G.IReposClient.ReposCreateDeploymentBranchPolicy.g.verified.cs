//HintName: G.IReposClient.ReposCreateDeploymentBranchPolicy.g.cs
#nullable enable

namespace G
{
    public partial interface IReposClient
    {
        /// <summary>
        /// Create a deployment branch policy<br/>
        /// Creates a deployment branch or tag policy for an environment.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `repo` scope to use this endpoint.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="environmentName"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.DeploymentBranchPolicy> ReposCreateDeploymentBranchPolicyAsync(
            string owner,
            string repo,
            string environmentName,
            global::G.DeploymentBranchPolicyNamePatternWithType request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create a deployment branch policy<br/>
        /// Creates a deployment branch or tag policy for an environment.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `repo` scope to use this endpoint.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="environmentName"></param>
        /// <param name="name">
        /// The name pattern that branches or tags must match in order to deploy to the environment.<br/>
        /// Wildcard characters will not match `/`. For example, to match branches that begin with `release/` and contain an additional single slash, use `release/*/*`.<br/>
        /// For more information about pattern matching syntax, see the [Ruby File.fnmatch documentation](https://ruby-doc.org/core-2.5.1/File.html#method-c-fnmatch).<br/>
        /// Example: release/*
        /// </param>
        /// <param name="type">
        /// Whether this rule targets a branch or tag<br/>
        /// Example: branch
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.DeploymentBranchPolicy> ReposCreateDeploymentBranchPolicyAsync(
            string owner,
            string repo,
            string environmentName,
            string name,
            global::G.DeploymentBranchPolicyNamePatternWithTypeType? type = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}