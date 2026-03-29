//HintName: G.Models.PartitionName.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PartitionName
    {
        /// <summary>
        /// The name of the database to which the collection belongs.<br/>
        /// Setting this to a non-existing database results in a **MilvusException**.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dbName")]
        public string? DbName { get; set; }

        /// <summary>
        /// The name of the target collection.<br/>
        /// Setting this to a non-existing collection results in a **MilvusException**.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("collectionName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CollectionName { get; set; }

        /// <summary>
        /// The name of the target parition.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("partitionName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PartitionName1 { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PartitionName" /> class.
        /// </summary>
        /// <param name="collectionName">
        /// The name of the target collection.<br/>
        /// Setting this to a non-existing collection results in a **MilvusException**.
        /// </param>
        /// <param name="partitionName1">
        /// The name of the target parition.
        /// </param>
        /// <param name="dbName">
        /// The name of the database to which the collection belongs.<br/>
        /// Setting this to a non-existing database results in a **MilvusException**.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PartitionName(
            string collectionName,
            string partitionName1,
            string? dbName)
        {
            this.DbName = dbName;
            this.CollectionName = collectionName ?? throw new global::System.ArgumentNullException(nameof(collectionName));
            this.PartitionName1 = partitionName1 ?? throw new global::System.ArgumentNullException(nameof(partitionName1));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PartitionName" /> class.
        /// </summary>
        public PartitionName()
        {
        }
    }
}