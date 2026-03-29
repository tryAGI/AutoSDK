//HintName: G.Models.McpServerCapabilitiesCountsPrompts.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class McpServerCapabilitiesCountsPrompts
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total")]
        public int? Total { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public int? Enabled { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="McpServerCapabilitiesCountsPrompts" /> class.
        /// </summary>
        /// <param name="total"></param>
        /// <param name="enabled"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public McpServerCapabilitiesCountsPrompts(
            int? total,
            int? enabled)
        {
            this.Total = total;
            this.Enabled = enabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="McpServerCapabilitiesCountsPrompts" /> class.
        /// </summary>
        public McpServerCapabilitiesCountsPrompts()
        {
        }
    }
}