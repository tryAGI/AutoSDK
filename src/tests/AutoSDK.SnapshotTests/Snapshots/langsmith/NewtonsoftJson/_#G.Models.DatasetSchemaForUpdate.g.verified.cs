//HintName: G.Models.DatasetSchemaForUpdate.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DatasetSchemaForUpdate
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("inputs_schema_definition")]
        public object? InputsSchemaDefinition { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("outputs_schema_definition")]
        public object? OutputsSchemaDefinition { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("externally_managed")]
        public bool? ExternallyManaged { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("transformations")]
        public global::System.Collections.Generic.IList<global::G.DatasetTransformation>? Transformations { get; set; }

        /// <summary>
        /// Enum for dataset data types.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data_type")]
        public global::G.DataType? DataType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tenant_id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid TenantId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetSchemaForUpdate" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="createdAt"></param>
        /// <param name="inputsSchemaDefinition"></param>
        /// <param name="outputsSchemaDefinition"></param>
        /// <param name="externallyManaged">
        /// Default Value: false
        /// </param>
        /// <param name="transformations"></param>
        /// <param name="dataType">
        /// Enum for dataset data types.
        /// </param>
        /// <param name="id"></param>
        /// <param name="tenantId"></param>
        public DatasetSchemaForUpdate(
            string name,
            global::System.Guid id,
            global::System.Guid tenantId,
            string? description,
            global::System.DateTime? createdAt,
            object? inputsSchemaDefinition,
            object? outputsSchemaDefinition,
            bool? externallyManaged,
            global::System.Collections.Generic.IList<global::G.DatasetTransformation>? transformations,
            global::G.DataType? dataType)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Id = id;
            this.TenantId = tenantId;
            this.Description = description;
            this.CreatedAt = createdAt;
            this.InputsSchemaDefinition = inputsSchemaDefinition;
            this.OutputsSchemaDefinition = outputsSchemaDefinition;
            this.ExternallyManaged = externallyManaged;
            this.Transformations = transformations;
            this.DataType = dataType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetSchemaForUpdate" /> class.
        /// </summary>
        public DatasetSchemaForUpdate()
        {
        }
    }
}