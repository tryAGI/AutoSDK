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
        [global::Newtonsoft.Json.JsonProperty("create_sharding_key", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.CreateShardingKey CreateShardingKey { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateShardingKeyOperation" /> class.
        /// </summary>
        /// <param name="createShardingKey"></param>
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