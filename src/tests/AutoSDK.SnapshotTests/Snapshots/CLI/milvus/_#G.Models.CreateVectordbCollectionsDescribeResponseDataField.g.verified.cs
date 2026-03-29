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
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The data type of the field.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        /// The description of the field.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// Whether this field automatically increments its value.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("autoId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool AutoId { get; set; }

        /// <summary>
        /// Whether this field serves as a partition key.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("partitionKey")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool PartitionKey { get; set; }

        /// <summary>
        /// Whether this field serves as the primary key.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("primaryKey")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool PrimaryKey { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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