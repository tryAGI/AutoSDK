//HintName: G.Models.HasReq.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class HasReq
    {
        /// <summary>
        /// The name of the database in which to check the existence of a collection.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dbName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DbName { get; set; }

        /// <summary>
        /// The name of an existing collection.
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
        /// Initializes a new instance of the <see cref="HasReq" /> class.
        /// </summary>
        /// <param name="dbName">
        /// The name of the database in which to check the existence of a collection.
        /// </param>
        /// <param name="collectionName">
        /// The name of an existing collection.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public HasReq(
            string dbName,
            string collectionName)
        {
            this.DbName = dbName ?? throw new global::System.ArgumentNullException(nameof(dbName));
            this.CollectionName = collectionName ?? throw new global::System.ArgumentNullException(nameof(collectionName));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HasReq" /> class.
        /// </summary>
        public HasReq()
        {
        }
    }
}