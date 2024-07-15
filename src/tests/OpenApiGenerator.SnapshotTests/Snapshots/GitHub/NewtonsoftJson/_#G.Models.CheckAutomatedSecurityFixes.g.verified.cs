//HintName: G.Models.CheckAutomatedSecurityFixes.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Check Automated Security Fixes
    /// </summary>
    public sealed partial class CheckAutomatedSecurityFixes
    {
        /// <summary>
        /// Whether automated security fixes are enabled for the repository.<br/>
        /// Example: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("enabled", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Enabled { get; set; } = default!;

        /// <summary>
        /// Whether automated security fixes are paused for the repository.<br/>
        /// Example: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("paused", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Paused { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}