//HintName: G.Models.PointGroup.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PointGroup
    {
        /// <summary>
        /// Scored points that have the same value of the group_by key
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hits")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.ScoredPoint> Hits { get; set; }

        /// <summary>
        /// Value of the group_by key, shared across all the hits in the group
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.GroupIdJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.GroupId Id { get; set; }

        /// <summary>
        /// Record that has been looked up using the group id
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lookup")]
        public global::G.Record? Lookup { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PointGroup" /> class.
        /// </summary>
        /// <param name="hits">
        /// Scored points that have the same value of the group_by key
        /// </param>
        /// <param name="id">
        /// Value of the group_by key, shared across all the hits in the group
        /// </param>
        /// <param name="lookup">
        /// Record that has been looked up using the group id
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PointGroup(
            global::System.Collections.Generic.IList<global::G.ScoredPoint> hits,
            global::G.GroupId id,
            global::G.Record? lookup)
        {
            this.Hits = hits ?? throw new global::System.ArgumentNullException(nameof(hits));
            this.Id = id;
            this.Lookup = lookup;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PointGroup" /> class.
        /// </summary>
        public PointGroup()
        {
        }
    }
}