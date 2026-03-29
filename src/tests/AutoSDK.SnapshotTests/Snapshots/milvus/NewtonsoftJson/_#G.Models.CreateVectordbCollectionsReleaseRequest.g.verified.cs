//HintName: G.Models.CreateVectordbCollectionsReleaseRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateVectordbCollectionsReleaseRequest
    {
        /// <summary>
        /// The name of the database to which the cpllection belongs.<br/>
        /// Setting this to a non-existing database results in a **MilvusException**.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dbName")]
        public string? DbName { get; set; }

        /// <summary>
        /// The name of the target colletion.<br/>
        /// Setting this to a non-existing collection results in a **MilvusException**.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("collectionName", Required = global::Newtonsoft.Json.Required.Always)]
        public string CollectionName { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVectordbCollectionsReleaseRequest" /> class.
        /// </summary>
        /// <param name="collectionName">
        /// The name of the target colletion.<br/>
        /// Setting this to a non-existing collection results in a **MilvusException**.
        /// </param>
        /// <param name="dbName">
        /// The name of the database to which the cpllection belongs.<br/>
        /// Setting this to a non-existing database results in a **MilvusException**.
        /// </param>
        public CreateVectordbCollectionsReleaseRequest(
            string collectionName,
            string? dbName)
        {
            this.DbName = dbName;
            this.CollectionName = collectionName ?? throw new global::System.ArgumentNullException(nameof(collectionName));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVectordbCollectionsReleaseRequest" /> class.
        /// </summary>
        public CreateVectordbCollectionsReleaseRequest()
        {
        }
    }
}