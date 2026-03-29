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
        [global::System.Text.Json.Serialization.JsonPropertyName("collectionName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CollectionName { get; set; }

        /// <summary>
        /// Whether the primary key of this collection automatically increments.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("autoID")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool AutoID { get; set; }

        /// <summary>
        /// The description of the collection.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// Whether the reserved dynamic field named $meta is enabled to save non-schema-defined fields and their values in key-value pairs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enableDynamicField")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool EnableDynamicField { get; set; }

        /// <summary>
        /// The collection fields in an array
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fields")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.CreateVectordbCollectionsDescribeResponseDataField> Fields { get; set; }

        /// <summary>
        /// The created indexes in an array
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("indexes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.CreateVectordbCollectionsDescribeResponseDataIndexe> Indexes { get; set; }

        /// <summary>
        /// The load status of the current collection.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("load")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Load { get; set; }

        /// <summary>
        /// The number of shards created along with the collection.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("shardsNum")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ShardsNum { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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