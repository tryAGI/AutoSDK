//HintName: G.Models.CreateVectordbEntitiesUpsertRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateVectordbEntitiesUpsertRequest
    {
        /// <summary>
        /// The name of the database.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dbName")]
        public string? DbName { get; set; }

        /// <summary>
        /// The name of the collection in which to upsert data.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("collectionName", Required = global::Newtonsoft.Json.Required.Always)]
        public string CollectionName { get; set; } = default!;

        /// <summary>
        /// The data to insert into the current collection. <br/>
        /// The data to insert should be a dictionary that matches the schema of the current collection or a list of such dictionaries.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AnyOf<global::G.CreateVectordbEntitiesUpsertRequestData, global::System.Collections.Generic.IList<object>> Data { get; set; } = default!;

        /// <summary>
        /// The name of a partition in the current collection. <br/>
        /// If specified, the data is to be inserted into the specified partition.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("partitionName")]
        public string? PartitionName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVectordbEntitiesUpsertRequest" /> class.
        /// </summary>
        /// <param name="collectionName">
        /// The name of the collection in which to upsert data.
        /// </param>
        /// <param name="data">
        /// The data to insert into the current collection. <br/>
        /// The data to insert should be a dictionary that matches the schema of the current collection or a list of such dictionaries.
        /// </param>
        /// <param name="dbName">
        /// The name of the database.
        /// </param>
        /// <param name="partitionName">
        /// The name of a partition in the current collection. <br/>
        /// If specified, the data is to be inserted into the specified partition.
        /// </param>
        public CreateVectordbEntitiesUpsertRequest(
            string collectionName,
            global::G.AnyOf<global::G.CreateVectordbEntitiesUpsertRequestData, global::System.Collections.Generic.IList<object>> data,
            string? dbName,
            string? partitionName)
        {
            this.DbName = dbName;
            this.CollectionName = collectionName ?? throw new global::System.ArgumentNullException(nameof(collectionName));
            this.Data = data;
            this.PartitionName = partitionName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVectordbEntitiesUpsertRequest" /> class.
        /// </summary>
        public CreateVectordbEntitiesUpsertRequest()
        {
        }
    }
}