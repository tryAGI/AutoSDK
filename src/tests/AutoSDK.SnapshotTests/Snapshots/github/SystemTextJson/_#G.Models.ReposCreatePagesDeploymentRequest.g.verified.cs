//HintName: G.Models.ReposCreatePagesDeploymentRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The object used to create GitHub Pages deployment
    /// </summary>
    public sealed partial class ReposCreatePagesDeploymentRequest
    {
        /// <summary>
        /// The ID of an artifact that contains the .zip or .tar of static assets to deploy. The artifact belongs to the repository. Either `artifact_id` or `artifact_url` are required.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("artifact_id")]
        public double? ArtifactId { get; set; }

        /// <summary>
        /// The URL of an artifact that contains the .zip or .tar of static assets to deploy. The artifact belongs to the repository. Either `artifact_id` or `artifact_url` are required.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("artifact_url")]
        public string? ArtifactUrl { get; set; }

        /// <summary>
        /// The target environment for this GitHub Pages deployment.<br/>
        /// Default Value: github-pages
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environment")]
        public string? Environment { get; set; }

        /// <summary>
        /// A unique string that represents the version of the build for this deployment.<br/>
        /// Default Value: GITHUB_SHA
        /// </summary>
        /// <default>"GITHUB_SHA"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("pages_build_version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PagesBuildVersion { get; set; } = "GITHUB_SHA";

        /// <summary>
        /// The OIDC token issued by GitHub Actions certifying the origin of the deployment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("oidc_token")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OidcToken { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReposCreatePagesDeploymentRequest" /> class.
        /// </summary>
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReposCreatePagesDeploymentRequest(
            string pagesBuildVersion,
            string oidcToken,
            double? artifactId,
            string? artifactUrl,
            string? environment)
        {
            this.PagesBuildVersion = pagesBuildVersion ?? throw new global::System.ArgumentNullException(nameof(pagesBuildVersion));
            this.OidcToken = oidcToken ?? throw new global::System.ArgumentNullException(nameof(oidcToken));
            this.ArtifactId = artifactId;
            this.ArtifactUrl = artifactUrl;
            this.Environment = environment;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReposCreatePagesDeploymentRequest" /> class.
        /// </summary>
        public ReposCreatePagesDeploymentRequest()
        {
        }
    }
}