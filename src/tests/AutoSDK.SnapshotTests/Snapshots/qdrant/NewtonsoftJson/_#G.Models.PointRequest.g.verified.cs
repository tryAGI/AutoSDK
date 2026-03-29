//HintName: G.Models.PointRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PointRequest
    {
        /// <summary>
        /// Specify in which shards to look for the points, if not specified - look in all shards
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("shard_key")]
        public global::G.ShardKeySelector? ShardKey { get; set; }

        /// <summary>
        /// Look for points with ids
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ids", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.ExtendedPointId> Ids { get; set; } = default!;

        /// <summary>
        /// Select which payload to return with the response. Default is true.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("with_payload")]
        public global::G.WithPayloadInterface? WithPayload { get; set; }

        /// <summary>
        /// Options for specifying which vector to include
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("with_vector")]
        public global::G.WithVector? WithVector { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PointRequest" /> class.
        /// </summary>
        /// <param name="ids">
        /// Look for points with ids
        /// </param>
        /// <param name="shardKey">
        /// Specify in which shards to look for the points, if not specified - look in all shards
        /// </param>
        /// <param name="withPayload">
        /// Select which payload to return with the response. Default is true.
        /// </param>
        /// <param name="withVector">
        /// Options for specifying which vector to include
        /// </param>
        public PointRequest(
            global::System.Collections.Generic.IList<global::G.ExtendedPointId> ids,
            global::G.ShardKeySelector? shardKey,
            global::G.WithPayloadInterface? withPayload,
            global::G.WithVector? withVector)
        {
            this.ShardKey = shardKey;
            this.Ids = ids ?? throw new global::System.ArgumentNullException(nameof(ids));
            this.WithPayload = withPayload;
            this.WithVector = withVector;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PointRequest" /> class.
        /// </summary>
        public PointRequest()
        {
        }
    }
}