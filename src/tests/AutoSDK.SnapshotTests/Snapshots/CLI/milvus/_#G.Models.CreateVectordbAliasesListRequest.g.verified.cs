//HintName: G.Models.CreateVectordbAliasesListRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateVectordbAliasesListRequest
    {
        /// <summary>
        /// The name of an existing database. The value defaults to __default__.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dbName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DbName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVectordbAliasesListRequest" /> class.
        /// </summary>
        /// <param name="dbName">
        /// The name of an existing database. The value defaults to __default__.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateVectordbAliasesListRequest(
            string dbName)
        {
            this.DbName = dbName ?? throw new global::System.ArgumentNullException(nameof(dbName));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVectordbAliasesListRequest" /> class.
        /// </summary>
        public CreateVectordbAliasesListRequest()
        {
        }
    }
}