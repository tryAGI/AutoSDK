//HintName: G.Models.ReplicateShardOperation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ReplicateShardOperation
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("replicate_shard", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ReplicateShard ReplicateShard { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReplicateShardOperation" /> class.
        /// </summary>
        /// <param name="replicateShard"></param>
        public ReplicateShardOperation(
            global::G.ReplicateShard replicateShard)
        {
            this.ReplicateShard = replicateShard ?? throw new global::System.ArgumentNullException(nameof(replicateShard));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReplicateShardOperation" /> class.
        /// </summary>
        public ReplicateShardOperation()
        {
        }
    }
}