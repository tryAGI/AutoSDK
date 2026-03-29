//HintName: G.Models.CollectionParams.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CollectionParams
    {
        /// <summary>
        /// The maximum number of characters in a VarChar field. This parameter is mandatory when the current field type is VarChar.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_length")]
        public string? MaxLength { get; set; }

        /// <summary>
        /// Whether to enable the reserved dynamic field. If set to true, non-schema-defined fields are saved in the reserved dynamic field as key-value pairs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enableDynamicField")]
        public string? EnableDynamicField { get; set; }

        /// <summary>
        /// The number of shards to create along with the current collection.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("shardsNum")]
        public string? ShardsNum { get; set; }

        /// <summary>
        /// The consistency level of the collection. Possible values are __STRONG__, __BOUNDED__, __SESSION__, and __EVENTUALLY__.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("consistencyLevel")]
        public string? ConsistencyLevel { get; set; }

        /// <summary>
        /// The number of partitions to create along with the current collection. This parameter is mandatory if one field of the collection has been designated as the partition key.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("partitionsNum")]
        public string? PartitionsNum { get; set; }

        /// <summary>
        /// The time-to-live (TTL) period of the collection. If set, the collection is to be dropped once the period ends.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ttlSeconds")]
        public string? TtlSeconds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CollectionParams" /> class.
        /// </summary>
        /// <param name="maxLength">
        /// The maximum number of characters in a VarChar field. This parameter is mandatory when the current field type is VarChar.
        /// </param>
        /// <param name="enableDynamicField">
        /// Whether to enable the reserved dynamic field. If set to true, non-schema-defined fields are saved in the reserved dynamic field as key-value pairs.
        /// </param>
        /// <param name="shardsNum">
        /// The number of shards to create along with the current collection.
        /// </param>
        /// <param name="consistencyLevel">
        /// The consistency level of the collection. Possible values are __STRONG__, __BOUNDED__, __SESSION__, and __EVENTUALLY__.
        /// </param>
        /// <param name="partitionsNum">
        /// The number of partitions to create along with the current collection. This parameter is mandatory if one field of the collection has been designated as the partition key.
        /// </param>
        /// <param name="ttlSeconds">
        /// The time-to-live (TTL) period of the collection. If set, the collection is to be dropped once the period ends.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CollectionParams(
            string? maxLength,
            string? enableDynamicField,
            string? shardsNum,
            string? consistencyLevel,
            string? partitionsNum,
            string? ttlSeconds)
        {
            this.MaxLength = maxLength;
            this.EnableDynamicField = enableDynamicField;
            this.ShardsNum = shardsNum;
            this.ConsistencyLevel = consistencyLevel;
            this.PartitionsNum = partitionsNum;
            this.TtlSeconds = ttlSeconds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CollectionParams" /> class.
        /// </summary>
        public CollectionParams()
        {
        }
    }
}