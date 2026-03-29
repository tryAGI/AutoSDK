//HintName: G.Models.GetStatsReq.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetStatsReq
    {
        /// <summary>
        /// The name of the database which the collection belongs to. Setting this to a non-existing database results in an error.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dbName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DbName { get; set; }

        /// <summary>
        /// The name of the collection to check.<br/>
        /// Setting this to a non-existing database results in an error.
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
        /// Initializes a new instance of the <see cref="GetStatsReq" /> class.
        /// </summary>
        /// <param name="dbName">
        /// The name of the database which the collection belongs to. Setting this to a non-existing database results in an error.
        /// </param>
        /// <param name="collectionName">
        /// The name of the collection to check.<br/>
        /// Setting this to a non-existing database results in an error.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetStatsReq(
            string dbName,
            string collectionName)
        {
            this.DbName = dbName ?? throw new global::System.ArgumentNullException(nameof(dbName));
            this.CollectionName = collectionName ?? throw new global::System.ArgumentNullException(nameof(collectionName));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetStatsReq" /> class.
        /// </summary>
        public GetStatsReq()
        {
        }
    }
}