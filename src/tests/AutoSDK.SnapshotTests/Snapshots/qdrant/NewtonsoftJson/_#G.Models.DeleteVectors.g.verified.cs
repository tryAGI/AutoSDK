//HintName: G.Models.DeleteVectors.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeleteVectors
    {
        /// <summary>
        /// Deletes values from each point in this list
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("points")]
        public global::System.Collections.Generic.IList<global::G.ExtendedPointId>? Points { get; set; }

        /// <summary>
        /// Deletes values from points that satisfy this filter condition
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("filter")]
        public global::G.Filter? Filter { get; set; }

        /// <summary>
        /// Vector names
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("vector", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> Vector { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("shard_key")]
        public global::G.ShardKeySelector? ShardKey { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteVectors" /> class.
        /// </summary>
        /// <param name="vector">
        /// Vector names
        /// </param>
        /// <param name="points">
        /// Deletes values from each point in this list
        /// </param>
        /// <param name="filter">
        /// Deletes values from points that satisfy this filter condition
        /// </param>
        /// <param name="shardKey"></param>
        public DeleteVectors(
            global::System.Collections.Generic.IList<string> vector,
            global::System.Collections.Generic.IList<global::G.ExtendedPointId>? points,
            global::G.Filter? filter,
            global::G.ShardKeySelector? shardKey)
        {
            this.Points = points;
            this.Filter = filter;
            this.Vector = vector ?? throw new global::System.ArgumentNullException(nameof(vector));
            this.ShardKey = shardKey;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteVectors" /> class.
        /// </summary>
        public DeleteVectors()
        {
        }
    }
}