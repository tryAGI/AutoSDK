//HintName: G.Models.CreateVirtualKeysRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateVirtualKeysRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("provider")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.CreateVirtualKeysRequestProviderJsonConverter))]
        public global::G.CreateVirtualKeysRequestProvider? Provider { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("key")]
        public string? Key { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("note")]
        public string? Note { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("apiVersion")]
        public string? ApiVersion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("resourceName")]
        public string? ResourceName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("deploymentName")]
        public string? DeploymentName { get; set; }

        /// <summary>
        /// optional, needed when using organisation admin API keys
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("workspace_id")]
        public global::System.Guid? WorkspaceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("deploymentConfig")]
        public global::System.Collections.Generic.IList<global::G.CreateVirtualKeysRequestDeploymentConfigItem>? DeploymentConfig { get; set; }

        /// <summary>
        /// Example: {"credit_limit":10,"periodic_reset":"monthly","alert_threshold":8}
        /// </summary>
        /// <example>{"credit_limit":10,"periodic_reset":"monthly","alert_threshold":8}</example>
        [global::Newtonsoft.Json.JsonProperty("usage_limits")]
        public global::G.UsageLimits? UsageLimits { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("rate_limits")]
        public global::G.RateLimits? RateLimits { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("expires_at")]
        public global::System.DateTime? ExpiresAt { get; set; }

        /// <summary>
        /// Dynamically resolve secrets from secret references at runtime. Valid target_field values are "key" or "model_config.&lt;field&gt;" (e.g. "model_config.awsSecretAccessKey"). Each target_field must be unique. When "key" is mapped, the key field becomes optional.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("secret_mappings")]
        public global::System.Collections.Generic.IList<global::G.SecretMapping>? SecretMappings { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVirtualKeysRequest" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="provider"></param>
        /// <param name="key"></param>
        /// <param name="note"></param>
        /// <param name="apiVersion"></param>
        /// <param name="resourceName"></param>
        /// <param name="deploymentName"></param>
        /// <param name="workspaceId">
        /// optional, needed when using organisation admin API keys
        /// </param>
        /// <param name="deploymentConfig"></param>
        /// <param name="usageLimits">
        /// Example: {"credit_limit":10,"periodic_reset":"monthly","alert_threshold":8}
        /// </param>
        /// <param name="rateLimits"></param>
        /// <param name="expiresAt"></param>
        /// <param name="secretMappings">
        /// Dynamically resolve secrets from secret references at runtime. Valid target_field values are "key" or "model_config.&lt;field&gt;" (e.g. "model_config.awsSecretAccessKey"). Each target_field must be unique. When "key" is mapped, the key field becomes optional.
        /// </param>
        public CreateVirtualKeysRequest(
            string? name,
            global::G.CreateVirtualKeysRequestProvider? provider,
            string? key,
            string? note,
            string? apiVersion,
            string? resourceName,
            string? deploymentName,
            global::System.Guid? workspaceId,
            global::System.Collections.Generic.IList<global::G.CreateVirtualKeysRequestDeploymentConfigItem>? deploymentConfig,
            global::G.UsageLimits? usageLimits,
            global::G.RateLimits? rateLimits,
            global::System.DateTime? expiresAt,
            global::System.Collections.Generic.IList<global::G.SecretMapping>? secretMappings)
        {
            this.Name = name;
            this.Provider = provider;
            this.Key = key;
            this.Note = note;
            this.ApiVersion = apiVersion;
            this.ResourceName = resourceName;
            this.DeploymentName = deploymentName;
            this.WorkspaceId = workspaceId;
            this.DeploymentConfig = deploymentConfig;
            this.UsageLimits = usageLimits;
            this.RateLimits = rateLimits;
            this.ExpiresAt = expiresAt;
            this.SecretMappings = secretMappings;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVirtualKeysRequest" /> class.
        /// </summary>
        public CreateVirtualKeysRequest()
        {
        }
    }
}