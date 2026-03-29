//HintName: G.Models.DropShardingKeyOperation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DropShardingKeyOperation
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("drop_sharding_key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.DropShardingKey DropShardingKey { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DropShardingKeyOperation" /> class.
        /// </summary>
        /// <param name="dropShardingKey"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DropShardingKeyOperation(
            global::G.DropShardingKey dropShardingKey)
        {
            this.DropShardingKey = dropShardingKey ?? throw new global::System.ArgumentNullException(nameof(dropShardingKey));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DropShardingKeyOperation" /> class.
        /// </summary>
        public DropShardingKeyOperation()
        {
        }
    }
}