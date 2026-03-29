//HintName: G.Models.CreateVectordbCollectionsDescribeRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateVectordbCollectionsDescribeRequest
    {
        /// <summary>
        /// The name of the database.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dbName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DbName { get; set; }

        /// <summary>
        /// The name of the collection to describe.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("collectionName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CollectionName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVectordbCollectionsDescribeRequest" /> class.
        /// </summary>
        /// <param name="dbName">
        /// The name of the database.
        /// </param>
        /// <param name="collectionName">
        /// The name of the collection to describe.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateVectordbCollectionsDescribeRequest(
            string dbName,
            string collectionName)
        {
            this.DbName = dbName ?? throw new global::System.ArgumentNullException(nameof(dbName));
            this.CollectionName = collectionName ?? throw new global::System.ArgumentNullException(nameof(collectionName));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVectordbCollectionsDescribeRequest" /> class.
        /// </summary>
        public CreateVectordbCollectionsDescribeRequest()
        {
        }
    }
}