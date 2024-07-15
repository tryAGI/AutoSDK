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
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public int Id { get; set; } = default!;

        /// <summary>
        /// The slugified name of the deployment protection rule integration.<br/>
        /// Example: my-custom-app
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("slug", Required = global::Newtonsoft.Json.Required.Always)]
        public string Slug { get; set; } = default!;

        /// <summary>
        /// The URL for the endpoint to get details about the app.<br/>
        /// Example: https://api.github.com/apps/custom-app-slug
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("integration_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string IntegrationUrl { get; set; } = default!;

        /// <summary>
        /// The node ID for the deployment protection rule integration.<br/>
        /// Example: MDQ6R2F0ZTM1MTU=
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("node_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string NodeId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}