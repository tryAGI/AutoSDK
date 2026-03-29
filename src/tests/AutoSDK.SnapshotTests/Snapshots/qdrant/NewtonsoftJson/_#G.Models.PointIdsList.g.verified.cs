//HintName: G.Models.PointIdsList.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PointIdsList
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("points", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.ExtendedPointId> Points { get; set; } = default!;

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
        /// Initializes a new instance of the <see cref="PointIdsList" /> class.
        /// </summary>
        /// <param name="points"></param>
        /// <param name="shardKey"></param>
        public PointIdsList(
            global::System.Collections.Generic.IList<global::G.ExtendedPointId> points,
            global::G.ShardKeySelector? shardKey)
        {
            this.Points = points ?? throw new global::System.ArgumentNullException(nameof(points));
            this.ShardKey = shardKey;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PointIdsList" /> class.
        /// </summary>
        public PointIdsList()
        {
        }
    }
}