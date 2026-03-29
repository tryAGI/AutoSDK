//HintName: G.Models.CreateVectordbCollectionsGetLoadStateRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateVectordbCollectionsGetLoadStateRequest
    {
        /// <summary>
        /// The name of a database to which the collection belongs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dbName")]
        public string? DbName { get; set; }

        /// <summary>
        /// The name of a collection.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("collectionName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CollectionName { get; set; }

        /// <summary>
        /// A list of partition names. If any partition names are specified, releasing any of these partitions results in the return of a NotLoad state.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("partitionNames")]
        public string? PartitionNames { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVectordbCollectionsGetLoadStateRequest" /> class.
        /// </summary>
        /// <param name="collectionName">
        /// The name of a collection.
        /// </param>
        /// <param name="dbName">
        /// The name of a database to which the collection belongs.
        /// </param>
        /// <param name="partitionNames">
        /// A list of partition names. If any partition names are specified, releasing any of these partitions results in the return of a NotLoad state.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateVectordbCollectionsGetLoadStateRequest(
            string collectionName,
            string? dbName,
            string? partitionNames)
        {
            this.DbName = dbName;
            this.CollectionName = collectionName ?? throw new global::System.ArgumentNullException(nameof(collectionName));
            this.PartitionNames = partitionNames;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVectordbCollectionsGetLoadStateRequest" /> class.
        /// </summary>
        public CreateVectordbCollectionsGetLoadStateRequest()
        {
        }
    }
}