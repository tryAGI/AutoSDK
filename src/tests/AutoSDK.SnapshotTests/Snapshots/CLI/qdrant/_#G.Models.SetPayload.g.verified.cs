//HintName: G.Models.SetPayload.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This data structure is used in API interface and applied across multiple shards
    /// </summary>
    public sealed partial class SetPayload
    {
        /// <summary>
        /// Example: {"city":"London","color":"green"}
        /// </summary>
        /// <example>{"city":"London","color":"green"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("payload")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.Payload Payload { get; set; }

        /// <summary>
        /// Assigns payload to each point in this list
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("points")]
        public global::System.Collections.Generic.IList<global::G.ExtendedPointId>? Points { get; set; }

        /// <summary>
        /// Assigns payload to each point that satisfy this filter condition
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filter")]
        public global::G.Filter? Filter { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("shard_key")]
        public global::G.ShardKeySelector? ShardKey { get; set; }

        /// <summary>
        /// Assigns payload to each point that satisfy this path of property
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        public string? Key { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SetPayload" /> class.
        /// </summary>
        /// <param name="payload">
        /// Example: {"city":"London","color":"green"}
        /// </param>
        /// <param name="points">
        /// Assigns payload to each point in this list
        /// </param>
        /// <param name="filter">
        /// Assigns payload to each point that satisfy this filter condition
        /// </param>
        /// <param name="shardKey"></param>
        /// <param name="key">
        /// Assigns payload to each point that satisfy this path of property
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SetPayload(
            global::G.Payload payload,
            global::System.Collections.Generic.IList<global::G.ExtendedPointId>? points,
            global::G.Filter? filter,
            global::G.ShardKeySelector? shardKey,
            string? key)
        {
            this.Payload = payload ?? throw new global::System.ArgumentNullException(nameof(payload));
            this.Points = points;
            this.Filter = filter;
            this.ShardKey = shardKey;
            this.Key = key;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SetPayload" /> class.
        /// </summary>
        public SetPayload()
        {
        }
    }
}