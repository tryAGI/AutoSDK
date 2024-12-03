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
        [global::System.Text.Json.Serialization.JsonPropertyName("shard_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ShardCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateConduitsBody" /> class.
        /// </summary>
        /// <param name="shardCount">
        /// The number of shards to create for this conduit.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
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