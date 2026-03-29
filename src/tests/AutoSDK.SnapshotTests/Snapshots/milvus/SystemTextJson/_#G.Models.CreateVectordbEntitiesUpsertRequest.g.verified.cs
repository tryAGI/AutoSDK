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
        [global::System.Text.Json.Serialization.JsonPropertyName("dbName")]
        public string? DbName { get; set; }

        /// <summary>
        /// The name of the collection in which to upsert data.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("collectionName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CollectionName { get; set; }

        /// <summary>
        /// The data to insert into the current collection. <br/>
        /// The data to insert should be a dictionary that matches the schema of the current collection or a list of such dictionaries.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<global::G.CreateVectordbEntitiesUpsertRequestData, global::System.Collections.Generic.IList<object>>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.AnyOf<global::G.CreateVectordbEntitiesUpsertRequestData, global::System.Collections.Generic.IList<object>> Data { get; set; }

        /// <summary>
        /// The name of a partition in the current collection. <br/>
        /// If specified, the data is to be inserted into the specified partition.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("partitionName")]
        public string? PartitionName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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