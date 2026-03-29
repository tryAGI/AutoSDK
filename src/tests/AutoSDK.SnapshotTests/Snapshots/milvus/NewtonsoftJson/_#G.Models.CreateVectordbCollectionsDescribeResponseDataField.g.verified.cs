//HintName: G.Models.CreateVectordbCollectionsDescribeResponseDataField.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateVectordbCollectionsDescribeResponseDataField
    {
        /// <summary>
        /// The name of the current field.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// The data type of the field.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public string Type { get; set; } = default!;

        /// <summary>
        /// The description of the field.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description", Required = global::Newtonsoft.Json.Required.Always)]
        public string Description { get; set; } = default!;

        /// <summary>
        /// Whether this field automatically increments its value.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("autoId", Required = global::Newtonsoft.Json.Required.Always)]
        public bool AutoId { get; set; } = default!;

        /// <summary>
        /// Whether this field serves as a partition key.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("partitionKey", Required = global::Newtonsoft.Json.Required.Always)]
        public bool PartitionKey { get; set; } = default!;

        /// <summary>
        /// Whether this field serves as the primary key.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("primaryKey", Required = global::Newtonsoft.Json.Required.Always)]
        public bool PrimaryKey { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVectordbCollectionsDescribeResponseDataField" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the current field.
        /// </param>
        /// <param name="type">
        /// The data type of the field.
        /// </param>
        /// <param name="description">
        /// The description of the field.
        /// </param>
        /// <param name="autoId">
        /// Whether this field automatically increments its value.
        /// </param>
        /// <param name="partitionKey">
        /// Whether this field serves as a partition key.
        /// </param>
        /// <param name="primaryKey">
        /// Whether this field serves as the primary key.
        /// </param>
        public CreateVectordbCollectionsDescribeResponseDataField(
            string name,
            string type,
            string description,
            bool autoId,
            bool partitionKey,
            bool primaryKey)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.AutoId = autoId;
            this.PartitionKey = partitionKey;
            this.PrimaryKey = primaryKey;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVectordbCollectionsDescribeResponseDataField" /> class.
        /// </summary>
        public CreateVectordbCollectionsDescribeResponseDataField()
        {
        }
    }
}