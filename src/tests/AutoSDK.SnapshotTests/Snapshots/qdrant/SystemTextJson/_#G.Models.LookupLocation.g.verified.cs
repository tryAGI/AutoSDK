//HintName: G.Models.LookupLocation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Defines a location to use for looking up the vector. Specifies collection and vector field name.
    /// </summary>
    public sealed partial class LookupLocation
    {
        /// <summary>
        /// Name of the collection used for lookup
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("collection")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Collection { get; set; }

        /// <summary>
        /// Optional name of the vector field within the collection. If not provided, the default vector field will be used.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vector")]
        public string? Vector { get; set; }

        /// <summary>
        /// Specify in which shards to look for the points, if not specified - look in all shards
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("shard_key")]
        public global::G.ShardKeySelector? ShardKey { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LookupLocation" /> class.
        /// </summary>
        /// <param name="collection">
        /// Name of the collection used for lookup
        /// </param>
        /// <param name="vector">
        /// Optional name of the vector field within the collection. If not provided, the default vector field will be used.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="shardKey">
        /// Specify in which shards to look for the points, if not specified - look in all shards
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LookupLocation(
            string collection,
            string? vector,
            global::G.ShardKeySelector? shardKey)
        {
            this.Collection = collection ?? throw new global::System.ArgumentNullException(nameof(collection));
            this.Vector = vector;
            this.ShardKey = shardKey;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LookupLocation" /> class.
        /// </summary>
        public LookupLocation()
        {
        }
    }
}