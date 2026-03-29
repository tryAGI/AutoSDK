//HintName: G.Models.DbName.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DbName
    {
        /// <summary>
        /// The name of the database to which the collection belongs.<br/>
        /// Setting this to a non-existing database results in a **MilvusException**.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dbName")]
        public string? DbName1 { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DbName" /> class.
        /// </summary>
        /// <param name="dbName1">
        /// The name of the database to which the collection belongs.<br/>
        /// Setting this to a non-existing database results in a **MilvusException**.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DbName(
            string? dbName1)
        {
            this.DbName1 = dbName1;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DbName" /> class.
        /// </summary>
        public DbName()
        {
        }
    }
}