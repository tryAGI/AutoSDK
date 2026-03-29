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
        [global::Newtonsoft.Json.JsonProperty("hits", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.ScoredPoint> Hits { get; set; } = default!;

        /// <summary>
        /// Value of the group_by key, shared across all the hits in the group
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.GroupId Id { get; set; } = default!;

        /// <summary>
        /// Record that has been looked up using the group id
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("lookup")]
        public global::G.Record? Lookup { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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