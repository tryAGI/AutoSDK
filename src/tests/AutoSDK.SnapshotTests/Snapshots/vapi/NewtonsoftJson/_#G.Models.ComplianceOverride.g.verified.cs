//HintName: G.Models.ComplianceOverride.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ComplianceOverride
    {
        /// <summary>
        /// Force storage for this output under HIPAA. Only enable if output contains no sensitive data.<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::Newtonsoft.Json.JsonProperty("forceStoreOnHipaaEnabled")]
        public bool? ForceStoreOnHipaaEnabled { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ComplianceOverride" /> class.
        /// </summary>
        /// <param name="forceStoreOnHipaaEnabled">
        /// Force storage for this output under HIPAA. Only enable if output contains no sensitive data.<br/>
        /// Example: false
        /// </param>
        public ComplianceOverride(
            bool? forceStoreOnHipaaEnabled)
        {
            this.ForceStoreOnHipaaEnabled = forceStoreOnHipaaEnabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ComplianceOverride" /> class.
        /// </summary>
        public ComplianceOverride()
        {
        }
    }
}