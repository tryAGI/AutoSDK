//HintName: G.Models.CreateVectordbPartitionsListRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateVectordbPartitionsListRequest
    {
        /// <summary>
        /// The name of the target database.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dbName", Required = global::Newtonsoft.Json.Required.Always)]
        public string DbName { get; set; } = default!;

        /// <summary>
        /// The name of the target collection to which the partition belongs.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("collectionName", Required = global::Newtonsoft.Json.Required.Always)]
        public string CollectionName { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVectordbPartitionsListRequest" /> class.
        /// </summary>
        /// <param name="dbName">
        /// The name of the target database.
        /// </param>
        /// <param name="collectionName">
        /// The name of the target collection to which the partition belongs.
        /// </param>
        public CreateVectordbPartitionsListRequest(
            string dbName,
            string collectionName)
        {
            this.DbName = dbName ?? throw new global::System.ArgumentNullException(nameof(dbName));
            this.CollectionName = collectionName ?? throw new global::System.ArgumentNullException(nameof(collectionName));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVectordbPartitionsListRequest" /> class.
        /// </summary>
        public CreateVectordbPartitionsListRequest()
        {
        }
    }
}