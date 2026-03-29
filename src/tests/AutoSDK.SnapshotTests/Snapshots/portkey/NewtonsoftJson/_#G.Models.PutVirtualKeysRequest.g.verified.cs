//HintName: G.Models.PutVirtualKeysRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PutVirtualKeysRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

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
        [global::Newtonsoft.Json.JsonProperty("deploymentConfig")]
        public global::System.Collections.Generic.IList<global::G.PutVirtualKeysRequestDeploymentConfigItem>? DeploymentConfig { get; set; }

        /// <summary>
        /// Example: {"credit_limit":10,"periodic_reset":"monthly","alert_threshold":8}
        /// </summary>
        /// <example>{"credit_limit":10,"periodic_reset":"monthly","alert_threshold":8}</example>
        [global::Newtonsoft.Json.JsonProperty("usage_limits")]
        public global::G.UsageLimits? UsageLimits { get; set; }

        /// <summary>
        /// Dynamically resolve secrets from secret references at runtime. Valid target_field values are "key" or "model_config.&lt;field&gt;" (e.g. "model_config.awsSecretAccessKey"). Each target_field must be unique.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("secret_mappings")]
        public global::System.Collections.Generic.IList<global::G.SecretMapping>? SecretMappings { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PutVirtualKeysRequest" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="key"></param>
        /// <param name="note"></param>
        /// <param name="deploymentConfig"></param>
        /// <param name="usageLimits">
        /// Example: {"credit_limit":10,"periodic_reset":"monthly","alert_threshold":8}
        /// </param>
        /// <param name="secretMappings">
        /// Dynamically resolve secrets from secret references at runtime. Valid target_field values are "key" or "model_config.&lt;field&gt;" (e.g. "model_config.awsSecretAccessKey"). Each target_field must be unique.
        /// </param>
        public PutVirtualKeysRequest(
            string? name,
            string? key,
            string? note,
            global::System.Collections.Generic.IList<global::G.PutVirtualKeysRequestDeploymentConfigItem>? deploymentConfig,
            global::G.UsageLimits? usageLimits,
            global::System.Collections.Generic.IList<global::G.SecretMapping>? secretMappings)
        {
            this.Name = name;
            this.Key = key;
            this.Note = note;
            this.DeploymentConfig = deploymentConfig;
            this.UsageLimits = usageLimits;
            this.SecretMappings = secretMappings;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PutVirtualKeysRequest" /> class.
        /// </summary>
        public PutVirtualKeysRequest()
        {
        }
    }
}