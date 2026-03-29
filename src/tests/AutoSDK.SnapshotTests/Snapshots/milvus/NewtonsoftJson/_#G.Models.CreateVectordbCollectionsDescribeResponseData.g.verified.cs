//HintName: G.Models.CreateVectordbCollectionsDescribeResponseData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateVectordbCollectionsDescribeResponseData
    {
        /// <summary>
        /// The name of the current collection.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("collectionName", Required = global::Newtonsoft.Json.Required.Always)]
        public string CollectionName { get; set; } = default!;

        /// <summary>
        /// Whether the primary key of this collection automatically increments.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("autoID", Required = global::Newtonsoft.Json.Required.Always)]
        public bool AutoID { get; set; } = default!;

        /// <summary>
        /// The description of the collection.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description", Required = global::Newtonsoft.Json.Required.Always)]
        public string Description { get; set; } = default!;

        /// <summary>
        /// Whether the reserved dynamic field named $meta is enabled to save non-schema-defined fields and their values in key-value pairs.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("enableDynamicField", Required = global::Newtonsoft.Json.Required.Always)]
        public bool EnableDynamicField { get; set; } = default!;

        /// <summary>
        /// The collection fields in an array
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("fields", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.CreateVectordbCollectionsDescribeResponseDataField> Fields { get; set; } = default!;

        /// <summary>
        /// The created indexes in an array
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("indexes", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.CreateVectordbCollectionsDescribeResponseDataIndexe> Indexes { get; set; } = default!;

        /// <summary>
        /// The load status of the current collection.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("load", Required = global::Newtonsoft.Json.Required.Always)]
        public string Load { get; set; } = default!;

        /// <summary>
        /// The number of shards created along with the collection.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("shardsNum", Required = global::Newtonsoft.Json.Required.Always)]
        public int ShardsNum { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVectordbCollectionsDescribeResponseData" /> class.
        /// </summary>
        /// <param name="collectionName">
        /// The name of the current collection.
        /// </param>
        /// <param name="autoID">
        /// Whether the primary key of this collection automatically increments.
        /// </param>
        /// <param name="description">
        /// The description of the collection.
        /// </param>
        /// <param name="enableDynamicField">
        /// Whether the reserved dynamic field named $meta is enabled to save non-schema-defined fields and their values in key-value pairs.
        /// </param>
        /// <param name="fields">
        /// The collection fields in an array
        /// </param>
        /// <param name="indexes">
        /// The created indexes in an array
        /// </param>
        /// <param name="load">
        /// The load status of the current collection.
        /// </param>
        /// <param name="shardsNum">
        /// The number of shards created along with the collection.
        /// </param>
        public CreateVectordbCollectionsDescribeResponseData(
            string collectionName,
            bool autoID,
            string description,
            bool enableDynamicField,
            global::System.Collections.Generic.IList<global::G.CreateVectordbCollectionsDescribeResponseDataField> fields,
            global::System.Collections.Generic.IList<global::G.CreateVectordbCollectionsDescribeResponseDataIndexe> indexes,
            string load,
            int shardsNum)
        {
            this.CollectionName = collectionName ?? throw new global::System.ArgumentNullException(nameof(collectionName));
            this.AutoID = autoID;
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.EnableDynamicField = enableDynamicField;
            this.Fields = fields ?? throw new global::System.ArgumentNullException(nameof(fields));
            this.Indexes = indexes ?? throw new global::System.ArgumentNullException(nameof(indexes));
            this.Load = load ?? throw new global::System.ArgumentNullException(nameof(load));
            this.ShardsNum = shardsNum;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVectordbCollectionsDescribeResponseData" /> class.
        /// </summary>
        public CreateVectordbCollectionsDescribeResponseData()
        {
        }
    }
}