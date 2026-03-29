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
        [global::Newtonsoft.Json.JsonProperty("dbName", Required = global::Newtonsoft.Json.Required.Always)]
        public string DbName { get; set; } = default!;

        /// <summary>
        /// The name of the collection to check.<br/>
        /// Setting this to a non-existing database results in an error.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("collectionName", Required = global::Newtonsoft.Json.Required.Always)]
        public string CollectionName { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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