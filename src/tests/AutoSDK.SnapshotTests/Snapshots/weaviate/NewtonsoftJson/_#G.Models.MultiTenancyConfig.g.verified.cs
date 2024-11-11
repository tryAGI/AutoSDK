//HintName: G.Models.MultiTenancyConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Configuration related to multi-tenancy within a class
    /// </summary>
    public sealed partial class MultiTenancyConfig
    {
        /// <summary>
        /// Whether or not multi-tenancy is enabled for this class<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Nonexistent tenants should (not) be created implicitly
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("autoTenantCreation")]
        public bool? AutoTenantCreation { get; set; }

        /// <summary>
        /// Existing tenants should (not) be turned HOT implicitly when they are accessed and in another activity status
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("autoTenantActivation")]
        public bool? AutoTenantActivation { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MultiTenancyConfig" /> class.
        /// </summary>
        /// <param name="enabled">
        /// Whether or not multi-tenancy is enabled for this class<br/>
        /// Default Value: false
        /// </param>
        /// <param name="autoTenantCreation">
        /// Nonexistent tenants should (not) be created implicitly
        /// </param>
        /// <param name="autoTenantActivation">
        /// Existing tenants should (not) be turned HOT implicitly when they are accessed and in another activity status
        /// </param>
        public MultiTenancyConfig(
            bool? enabled,
            bool? autoTenantCreation,
            bool? autoTenantActivation)
        {
            this.Enabled = enabled;
            this.AutoTenantCreation = autoTenantCreation;
            this.AutoTenantActivation = autoTenantActivation;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MultiTenancyConfig" /> class.
        /// </summary>
        public MultiTenancyConfig()
        {
        }
    }
}