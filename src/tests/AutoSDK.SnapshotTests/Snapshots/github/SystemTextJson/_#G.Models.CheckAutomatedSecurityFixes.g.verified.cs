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
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Enabled { get; set; }

        /// <summary>
        /// Whether automated security fixes are paused for the repository.<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("paused")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Paused { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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