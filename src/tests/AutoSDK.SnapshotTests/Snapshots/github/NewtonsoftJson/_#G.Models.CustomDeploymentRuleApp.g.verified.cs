//HintName: G.Models.CustomDeploymentRuleApp.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A GitHub App that is providing a custom deployment protection rule.
    /// </summary>
    public sealed partial class CustomDeploymentRuleApp
    {
        /// <summary>
        /// The unique identifier of the deployment protection rule integration.<br/>
        /// Example: 3515
        /// </summary>
        /// <example>3515</example>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public int Id { get; set; } = default!;

        /// <summary>
        /// The slugified name of the deployment protection rule integration.<br/>
        /// Example: my-custom-app
        /// </summary>
        /// <example>my-custom-app</example>
        [global::Newtonsoft.Json.JsonProperty("slug", Required = global::Newtonsoft.Json.Required.Always)]
        public string Slug { get; set; } = default!;

        /// <summary>
        /// The URL for the endpoint to get details about the app.<br/>
        /// Example: https://api.github.com/apps/custom-app-slug
        /// </summary>
        /// <example>https://api.github.com/apps/custom-app-slug</example>
        [global::Newtonsoft.Json.JsonProperty("integration_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string IntegrationUrl { get; set; } = default!;

        /// <summary>
        /// The node ID for the deployment protection rule integration.<br/>
        /// Example: MDQ6R2F0ZTM1MTU=
        /// </summary>
        /// <example>MDQ6R2F0ZTM1MTU=</example>
        [global::Newtonsoft.Json.JsonProperty("node_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string NodeId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomDeploymentRuleApp" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique identifier of the deployment protection rule integration.<br/>
        /// Example: 3515
        /// </param>
        /// <param name="slug">
        /// The slugified name of the deployment protection rule integration.<br/>
        /// Example: my-custom-app
        /// </param>
        /// <param name="integrationUrl">
        /// The URL for the endpoint to get details about the app.<br/>
        /// Example: https://api.github.com/apps/custom-app-slug
        /// </param>
        /// <param name="nodeId">
        /// The node ID for the deployment protection rule integration.<br/>
        /// Example: MDQ6R2F0ZTM1MTU=
        /// </param>
        public CustomDeploymentRuleApp(
            int id,
            string slug,
            string integrationUrl,
            string nodeId)
        {
            this.Id = id;
            this.Slug = slug ?? throw new global::System.ArgumentNullException(nameof(slug));
            this.IntegrationUrl = integrationUrl ?? throw new global::System.ArgumentNullException(nameof(integrationUrl));
            this.NodeId = nodeId ?? throw new global::System.ArgumentNullException(nameof(nodeId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomDeploymentRuleApp" /> class.
        /// </summary>
        public CustomDeploymentRuleApp()
        {
        }
    }
}