//HintName: G.Models.ReposCreateDeploymentRequest.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ReposCreateDeploymentRequest
    {
        /// <summary>
        /// The ref to deploy. This can be a branch, tag, or SHA.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ref", Required = global::Newtonsoft.Json.Required.Always)]
        public string Ref { get; set; } = default!;

        /// <summary>
        /// Specifies a task to execute (e.g., `deploy` or `deploy:migrations`).<br/>
        /// Default Value: deploy
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("task")]
        public string? Task { get; set; } = "deploy";

        /// <summary>
        /// Attempts to automatically merge the default branch into the requested ref, if it's behind the default branch.<br/>
        /// Default Value: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("auto_merge")]
        public bool AutoMerge { get; set; } = true;

        /// <summary>
        /// The [status](https://docs.github.com/rest/commits/statuses) contexts to verify against commit status checks. If you omit this parameter, GitHub verifies all unique contexts before creating a deployment. To bypass checking entirely, pass an empty array. Defaults to all unique contexts.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("required_contexts")]
        public global::System.Collections.Generic.IList<string>? RequiredContexts { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("payload")]
        public global::System.OneOf<global::G.ReposCreateDeploymentRequestPayload?, string?>? Payload { get; set; }

        /// <summary>
        /// Name for the target deployment environment (e.g., `production`, `staging`, `qa`).<br/>
        /// Default Value: production
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("environment")]
        public string? Environment { get; set; } = "production";

        /// <summary>
        /// Short description of the deployment.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Specifies if the given environment is specific to the deployment and will no longer exist at some point in the future. Default: `false`<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("transient_environment")]
        public bool TransientEnvironment { get; set; } = false;

        /// <summary>
        /// Specifies if the given environment is one that end-users directly interact with. Default: `true` when `environment` is `production` and `false` otherwise.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("production_environment")]
        public bool ProductionEnvironment { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}