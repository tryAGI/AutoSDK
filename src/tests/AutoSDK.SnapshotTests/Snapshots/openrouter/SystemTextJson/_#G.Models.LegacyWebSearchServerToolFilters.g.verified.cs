//HintName: G.Models.LegacyWebSearchServerToolFilters.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LegacyWebSearchServerToolFilters
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowed_domains")]
        public global::System.Collections.Generic.IList<string>? AllowedDomains { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("excluded_domains")]
        public global::System.Collections.Generic.IList<string>? ExcludedDomains { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LegacyWebSearchServerToolFilters" /> class.
        /// </summary>
        /// <param name="allowedDomains"></param>
        /// <param name="excludedDomains"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LegacyWebSearchServerToolFilters(
            global::System.Collections.Generic.IList<string>? allowedDomains,
            global::System.Collections.Generic.IList<string>? excludedDomains)
        {
            this.AllowedDomains = allowedDomains;
            this.ExcludedDomains = excludedDomains;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LegacyWebSearchServerToolFilters" /> class.
        /// </summary>
        public LegacyWebSearchServerToolFilters()
        {
        }
    }
}