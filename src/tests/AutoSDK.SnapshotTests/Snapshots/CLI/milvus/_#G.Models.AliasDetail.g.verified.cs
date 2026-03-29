//HintName: G.Models.AliasDetail.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AliasDetail
    {
        /// <summary>
        /// The name of the database to which the collection belongs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dbName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DbName { get; set; }

        /// <summary>
        /// the name of the collection to which an alias belongs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("collectionName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CollectionName { get; set; }

        /// <summary>
        /// The name of the alias.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aliasName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AliasName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AliasDetail" /> class.
        /// </summary>
        /// <param name="dbName">
        /// The name of the database to which the collection belongs.
        /// </param>
        /// <param name="collectionName">
        /// the name of the collection to which an alias belongs.
        /// </param>
        /// <param name="aliasName">
        /// The name of the alias.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AliasDetail(
            string dbName,
            string collectionName,
            string aliasName)
        {
            this.DbName = dbName ?? throw new global::System.ArgumentNullException(nameof(dbName));
            this.CollectionName = collectionName ?? throw new global::System.ArgumentNullException(nameof(collectionName));
            this.AliasName = aliasName ?? throw new global::System.ArgumentNullException(nameof(aliasName));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AliasDetail" /> class.
        /// </summary>
        public AliasDetail()
        {
        }
    }
}