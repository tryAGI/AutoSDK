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
        [global::Newtonsoft.Json.JsonProperty("artifact_id")]
        public double ArtifactId { get; set; }

        /// <summary>
        /// The URL of an artifact that contains the .zip or .tar of static assets to deploy. The artifact belongs to the repository. Either `artifact_id` or `artifact_url` are required.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("artifact_url")]
        public string? ArtifactUrl { get; set; }

        /// <summary>
        /// The target environment for this GitHub Pages deployment.
        /// <br/>Default Value: github-pages
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("environment")]
        public string? Environment { get; set; } = "github-pages";

        /// <summary>
        /// A unique string that represents the version of the build for this deployment.
        /// <br/>Default Value: GITHUB_SHA
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pages_build_version", Required = global::Newtonsoft.Json.Required.Always)]
        public string PagesBuildVersion { get; set; } = default!;

        /// <summary>
        /// The OIDC token issued by GitHub Actions certifying the origin of the deployment.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("oidc_token", Required = global::Newtonsoft.Json.Required.Always)]
        public string OidcToken { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}