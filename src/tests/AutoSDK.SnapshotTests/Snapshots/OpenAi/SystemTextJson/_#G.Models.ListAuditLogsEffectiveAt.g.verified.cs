//HintName: G.Models.ListAuditLogsEffectiveAt.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListAuditLogsEffectiveAt
    {
        /// <summary>
        /// Return only events whose `effective_at` (Unix seconds) is greater than this value.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gt")]
        public int? Gt { get; set; }

        /// <summary>
        /// Return only events whose `effective_at` (Unix seconds) is greater than or equal to this value.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gte")]
        public int? Gte { get; set; }

        /// <summary>
        /// Return only events whose `effective_at` (Unix seconds) is less than this value.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lt")]
        public int? Lt { get; set; }

        /// <summary>
        /// Return only events whose `effective_at` (Unix seconds) is less than or equal to this value.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lte")]
        public int? Lte { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}