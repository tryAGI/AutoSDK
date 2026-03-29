//HintName: G.Models.SecurityFilterPlan.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SecurityFilterPlan
    {
        /// <summary>
        /// Whether the security filter is enabled.<br/>
        /// @default false<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Array of security filter types to apply.<br/>
        /// If array is not empty, only those security filters are run.<br/>
        /// Example: [{ type: "sql-injection" }, { type: "xss" }]
        /// </summary>
        /// <example>[{ type: "sql-injection" }, { type: "xss" }]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("filters")]
        public global::System.Collections.Generic.IList<global::G.SecurityFilterBase>? Filters { get; set; }

        /// <summary>
        /// Mode of operation when a security threat is detected.<br/>
        /// - 'sanitize': Remove or replace the threatening content<br/>
        /// - 'reject': Replace the entire transcript with replacement text<br/>
        /// - 'replace': Replace threatening patterns with replacement text<br/>
        /// @default 'sanitize'<br/>
        /// Default Value: sanitize
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.SecurityFilterPlanModeJsonConverter))]
        public global::G.SecurityFilterPlanMode? Mode { get; set; }

        /// <summary>
        /// Text to use when replacing filtered content.<br/>
        /// @default '[FILTERED]'<br/>
        /// Default Value: [FILTERED]
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("replacementText")]
        public string? ReplacementText { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SecurityFilterPlan" /> class.
        /// </summary>
        /// <param name="enabled">
        /// Whether the security filter is enabled.<br/>
        /// @default false<br/>
        /// Default Value: false
        /// </param>
        /// <param name="filters">
        /// Array of security filter types to apply.<br/>
        /// If array is not empty, only those security filters are run.<br/>
        /// Example: [{ type: "sql-injection" }, { type: "xss" }]
        /// </param>
        /// <param name="mode">
        /// Mode of operation when a security threat is detected.<br/>
        /// - 'sanitize': Remove or replace the threatening content<br/>
        /// - 'reject': Replace the entire transcript with replacement text<br/>
        /// - 'replace': Replace threatening patterns with replacement text<br/>
        /// @default 'sanitize'<br/>
        /// Default Value: sanitize
        /// </param>
        /// <param name="replacementText">
        /// Text to use when replacing filtered content.<br/>
        /// @default '[FILTERED]'<br/>
        /// Default Value: [FILTERED]
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SecurityFilterPlan(
            bool? enabled,
            global::System.Collections.Generic.IList<global::G.SecurityFilterBase>? filters,
            global::G.SecurityFilterPlanMode? mode,
            string? replacementText)
        {
            this.Enabled = enabled;
            this.Filters = filters;
            this.Mode = mode;
            this.ReplacementText = replacementText;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SecurityFilterPlan" /> class.
        /// </summary>
        public SecurityFilterPlan()
        {
        }
    }
}