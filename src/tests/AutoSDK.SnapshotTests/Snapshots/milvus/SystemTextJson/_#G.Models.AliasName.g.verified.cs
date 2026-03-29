//HintName: G.Models.AliasName.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AliasName
    {
        /// <summary>
        /// The name of the database to which the collection belongs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dbName")]
        public string? DbName { get; set; }

        /// <summary>
        /// The name of the collection to which the alias is assigned to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("collectionName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CollectionName { get; set; }

        /// <summary>
        /// The alias to drop.<br/>
        /// When dropping an alias, you do not need to provide the collection name because one alias can only be assigned to exactly one collection. Therefore, the server knows which collection the specified alias belongs to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aliasName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AliasName1 { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AliasName" /> class.
        /// </summary>
        /// <param name="collectionName">
        /// The name of the collection to which the alias is assigned to.
        /// </param>
        /// <param name="aliasName1">
        /// The alias to drop.<br/>
        /// When dropping an alias, you do not need to provide the collection name because one alias can only be assigned to exactly one collection. Therefore, the server knows which collection the specified alias belongs to.
        /// </param>
        /// <param name="dbName">
        /// The name of the database to which the collection belongs.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AliasName(
            string collectionName,
            string aliasName1,
            string? dbName)
        {
            this.DbName = dbName;
            this.CollectionName = collectionName ?? throw new global::System.ArgumentNullException(nameof(collectionName));
            this.AliasName1 = aliasName1 ?? throw new global::System.ArgumentNullException(nameof(aliasName1));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AliasName" /> class.
        /// </summary>
        public AliasName()
        {
        }
    }
}