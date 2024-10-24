//HintName: G.IReposClient.ReposCreatePagesDeployment.g.cs
#nullable enable

namespace G
{
    public partial interface IReposClient
    {
        /// <summary>
        /// Create a GitHub Pages deployment<br/>
        /// Create a GitHub Pages deployment for a repository.<br/>
        /// The authenticated user must have write permission to the repository.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.PageDeployment> ReposCreatePagesDeploymentAsync(
            string owner,
            string repo,
            global::G.ReposCreatePagesDeploymentRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create a GitHub Pages deployment<br/>
        /// Create a GitHub Pages deployment for a repository.<br/>
        /// The authenticated user must have write permission to the repository.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="artifactId">
        /// The ID of an artifact that contains the .zip or .tar of static assets to deploy. The artifact belongs to the repository. Either `artifact_id` or `artifact_url` are required.
        /// </param>
        /// <param name="artifactUrl">
        /// The URL of an artifact that contains the .zip or .tar of static assets to deploy. The artifact belongs to the repository. Either `artifact_id` or `artifact_url` are required.
        /// </param>
        /// <param name="environment">
        /// The target environment for this GitHub Pages deployment.<br/>
        /// Default Value: github-pages
        /// </param>
        /// <param name="pagesBuildVersion">
        /// A unique string that represents the version of the build for this deployment.<br/>
        /// Default Value: GITHUB_SHA
        /// </param>
        /// <param name="oidcToken">
        /// The OIDC token issued by GitHub Actions certifying the origin of the deployment.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.PageDeployment> ReposCreatePagesDeploymentAsync(
            string owner,
            string repo,
            string pagesBuildVersion,
            string oidcToken,
            double? artifactId = default,
            string? artifactUrl = default,
            string? environment = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}