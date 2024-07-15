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
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Enabled { get; set; }

        /// <summary>
        /// Whether automated security fixes are paused for the repository.<br/>
        /// Example: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("paused")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Paused { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}