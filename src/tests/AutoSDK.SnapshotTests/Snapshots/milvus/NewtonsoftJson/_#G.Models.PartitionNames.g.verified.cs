//HintName: G.Models.PartitionNames.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PartitionNames
    {
        /// <summary>
        /// The name of the database to which the collection belongs.<br/>
        /// Setting this to a non-existing database results in a **MilvusException**.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dbName")]
        public string? DbName { get; set; }

        /// <summary>
        /// The name of the target collection.<br/>
        /// Setting this to a non-existing collection results in a **MilvusException**.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("collectionName", Required = global::Newtonsoft.Json.Required.Always)]
        public string CollectionName { get; set; } = default!;

        /// <summary>
        /// The list of names of the target partitions.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("partitionNames", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> PartitionNames1 { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PartitionNames" /> class.
        /// </summary>
        /// <param name="collectionName">
        /// The name of the target collection.<br/>
        /// Setting this to a non-existing collection results in a **MilvusException**.
        /// </param>
        /// <param name="partitionNames1">
        /// The list of names of the target partitions.
        /// </param>
        /// <param name="dbName">
        /// The name of the database to which the collection belongs.<br/>
        /// Setting this to a non-existing database results in a **MilvusException**.
        /// </param>
        public PartitionNames(
            string collectionName,
            global::System.Collections.Generic.IList<string> partitionNames1,
            string? dbName)
        {
            this.DbName = dbName;
            this.CollectionName = collectionName ?? throw new global::System.ArgumentNullException(nameof(collectionName));
            this.PartitionNames1 = partitionNames1 ?? throw new global::System.ArgumentNullException(nameof(partitionNames1));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PartitionNames" /> class.
        /// </summary>
        public PartitionNames()
        {
        }
    }
}