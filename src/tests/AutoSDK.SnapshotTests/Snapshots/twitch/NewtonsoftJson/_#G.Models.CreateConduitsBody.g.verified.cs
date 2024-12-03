//HintName: G.Models.CreateConduitsBody.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateConduitsBody
    {
        /// <summary>
        /// The number of shards to create for this conduit.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("shard_count", Required = global::Newtonsoft.Json.Required.Always)]
        public int ShardCount { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateConduitsBody" /> class.
        /// </summary>
        /// <param name="shardCount">
        /// The number of shards to create for this conduit.
        /// </param>
        public CreateConduitsBody(
            int shardCount)
        {
            this.ShardCount = shardCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateConduitsBody" /> class.
        /// </summary>
        public CreateConduitsBody()
        {
        }
    }
}