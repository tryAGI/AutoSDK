//HintName: G.Models.CreateVectordbCollectionsListRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateVectordbCollectionsListRequest
    {
        /// <summary>
        /// The name of an existing database.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dbName", Required = global::Newtonsoft.Json.Required.Always)]
        public string DbName { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVectordbCollectionsListRequest" /> class.
        /// </summary>
        /// <param name="dbName">
        /// The name of an existing database.
        /// </param>
        public CreateVectordbCollectionsListRequest(
            string dbName)
        {
            this.DbName = dbName ?? throw new global::System.ArgumentNullException(nameof(dbName));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVectordbCollectionsListRequest" /> class.
        /// </summary>
        public CreateVectordbCollectionsListRequest()
        {
        }
    }
}