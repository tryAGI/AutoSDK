//HintName: G.Models.FieldSchema.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The name of the field to create in the target collection
    /// </summary>
    public sealed partial class FieldSchema
    {
        /// <summary>
        /// The name of the field to create in the target collection
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("fieldName", Required = global::Newtonsoft.Json.Required.Always)]
        public string FieldName { get; set; } = default!;

        /// <summary>
        /// The data type of the field values.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dataType", Required = global::Newtonsoft.Json.Required.Always)]
        public string DataType { get; set; } = default!;

        /// <summary>
        /// The data type of the elements in an array field.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("elementDataType")]
        public string? ElementDataType { get; set; }

        /// <summary>
        /// Whether the current field is the primary field. Setting this to True makes the current field the primary field.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("isPrimary")]
        public bool? IsPrimary { get; set; }

        /// <summary>
        /// Whether the current field serves as the partition key. Setting this to True makes the current field serve as the partition key. In this case, MilvusZilliz Cloud manages all partitions in the current collection.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("isPartitionKey")]
        public bool? IsPartitionKey { get; set; }

        /// <summary>
        /// Extra field parameters.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("elementTypeParams")]
        public global::G.FieldSchemaElementTypeParams? ElementTypeParams { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FieldSchema" /> class.
        /// </summary>
        /// <param name="fieldName">
        /// The name of the field to create in the target collection
        /// </param>
        /// <param name="dataType">
        /// The data type of the field values.
        /// </param>
        /// <param name="elementDataType">
        /// The data type of the elements in an array field.
        /// </param>
        /// <param name="isPrimary">
        /// Whether the current field is the primary field. Setting this to True makes the current field the primary field.
        /// </param>
        /// <param name="isPartitionKey">
        /// Whether the current field serves as the partition key. Setting this to True makes the current field serve as the partition key. In this case, MilvusZilliz Cloud manages all partitions in the current collection.
        /// </param>
        /// <param name="elementTypeParams">
        /// Extra field parameters.
        /// </param>
        public FieldSchema(
            string fieldName,
            string dataType,
            string? elementDataType,
            bool? isPrimary,
            bool? isPartitionKey,
            global::G.FieldSchemaElementTypeParams? elementTypeParams)
        {
            this.FieldName = fieldName ?? throw new global::System.ArgumentNullException(nameof(fieldName));
            this.DataType = dataType ?? throw new global::System.ArgumentNullException(nameof(dataType));
            this.ElementDataType = elementDataType;
            this.IsPrimary = isPrimary;
            this.IsPartitionKey = isPartitionKey;
            this.ElementTypeParams = elementTypeParams;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FieldSchema" /> class.
        /// </summary>
        public FieldSchema()
        {
        }
    }
}