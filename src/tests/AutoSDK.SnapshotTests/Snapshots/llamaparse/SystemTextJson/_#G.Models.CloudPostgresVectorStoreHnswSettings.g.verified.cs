//HintName: G.Models.CloudPostgresVectorStoreHnswSettings.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// HNSW settings for PGVector index. Set to null to disable HNSW indexing in favor of a brute force indexing/exact search strategy instead.
    /// </summary>
    public sealed partial class CloudPostgresVectorStoreHnswSettings
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}