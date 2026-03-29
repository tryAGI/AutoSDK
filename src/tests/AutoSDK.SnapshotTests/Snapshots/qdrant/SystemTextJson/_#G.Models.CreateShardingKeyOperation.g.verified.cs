//HintName: G.Models.CreateShardingKeyOperation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateShardingKeyOperation
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("create_sharding_key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.CreateShardingKey CreateShardingKey { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateShardingKeyOperation" /> class.
        /// </summary>
        /// <param name="createShardingKey"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateShardingKeyOperation(
            global::G.CreateShardingKey createShardingKey)
        {
            this.CreateShardingKey = createShardingKey ?? throw new global::System.ArgumentNullException(nameof(createShardingKey));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateShardingKeyOperation" /> class.
        /// </summary>
        public CreateShardingKeyOperation()
        {
        }
    }
}