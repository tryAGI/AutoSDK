//HintName: G.Models.AliasCollection.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AliasCollection
    {
        /// <summary>
        /// The name of the database to which the collection belongs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dbName")]
        public string? DbName { get; set; }

        /// <summary>
        /// The name of the target collection to reassign an alias to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("collectionName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CollectionName { get; set; }

        /// <summary>
        /// The alias of the collection. 
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
        /// Initializes a new instance of the <see cref="AliasCollection" /> class.
        /// </summary>
        /// <param name="collectionName">
        /// The name of the target collection to reassign an alias to.
        /// </param>
        /// <param name="aliasName">
        /// The alias of the collection. 
        /// </param>
        /// <param name="dbName">
        /// The name of the database to which the collection belongs.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AliasCollection(
            string collectionName,
            string aliasName,
            string? dbName)
        {
            this.DbName = dbName;
            this.CollectionName = collectionName ?? throw new global::System.ArgumentNullException(nameof(collectionName));
            this.AliasName = aliasName ?? throw new global::System.ArgumentNullException(nameof(aliasName));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AliasCollection" /> class.
        /// </summary>
        public AliasCollection()
        {
        }
    }
}