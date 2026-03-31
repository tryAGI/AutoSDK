//HintName: G.Models.GroupScope.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Process spans/traces grouped by a field (e.g., session_id)
    /// </summary>
    public sealed partial class GroupScope
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.GroupScopeTypeJsonConverter))]
        public global::G.GroupScopeType Type { get; set; }

        /// <summary>
        /// Field path to group by, e.g. metadata.session_id
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("group_by")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string GroupBy { get; set; }

        /// <summary>
        /// Optional: trigger after this many seconds of inactivity
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("idle_seconds")]
        public double? IdleSeconds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GroupScope" /> class.
        /// </summary>
        /// <param name="groupBy">
        /// Field path to group by, e.g. metadata.session_id
        /// </param>
        /// <param name="type"></param>
        /// <param name="idleSeconds">
        /// Optional: trigger after this many seconds of inactivity
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GroupScope(
            string groupBy,
            global::G.GroupScopeType type,
            double? idleSeconds)
        {
            this.Type = type;
            this.GroupBy = groupBy ?? throw new global::System.ArgumentNullException(nameof(groupBy));
            this.IdleSeconds = idleSeconds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GroupScope" /> class.
        /// </summary>
        public GroupScope()
        {
        }
    }
}