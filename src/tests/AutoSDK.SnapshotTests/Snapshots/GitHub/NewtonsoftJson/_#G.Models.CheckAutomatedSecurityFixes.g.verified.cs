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
        /// <example>true</example>
        [global::Newtonsoft.Json.JsonProperty("enabled", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Enabled { get; set; } = default!;

        /// <summary>
        /// Whether automated security fixes are paused for the repository.<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::Newtonsoft.Json.JsonProperty("paused", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Paused { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CheckAutomatedSecurityFixes" /> class.
        /// </summary>
        /// <param name="enabled">
        /// Whether automated security fixes are enabled for the repository.<br/>
        /// Example: true
        /// </param>
        /// <param name="paused">
        /// Whether automated security fixes are paused for the repository.<br/>
        /// Example: false
        /// </param>
        public CheckAutomatedSecurityFixes(
            bool enabled,
            bool paused)
        {
            this.Enabled = enabled;
            this.Paused = paused;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CheckAutomatedSecurityFixes" /> class.
        /// </summary>
        public CheckAutomatedSecurityFixes()
        {
        }
    }
}