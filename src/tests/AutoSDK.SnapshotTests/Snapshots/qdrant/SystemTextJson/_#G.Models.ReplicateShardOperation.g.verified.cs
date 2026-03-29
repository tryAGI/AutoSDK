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
        [global::System.Text.Json.Serialization.JsonPropertyName("replicate_shard")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ReplicateShard ReplicateShard { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReplicateShardOperation" /> class.
        /// </summary>
        /// <param name="replicateShard"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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