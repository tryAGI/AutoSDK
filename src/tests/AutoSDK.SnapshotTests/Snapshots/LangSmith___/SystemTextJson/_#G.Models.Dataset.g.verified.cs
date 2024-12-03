//HintName: G.Models.Dataset.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Dataset schema.
    /// </summary>
    public sealed partial class Dataset
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inputs_schema_definition")]
        public object? InputsSchemaDefinition { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputs_schema_definition")]
        public object? OutputsSchemaDefinition { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("externally_managed")]
        public bool? ExternallyManaged { get; set; }

        /// <summary>
        /// Enum for dataset data types.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.DataTypeJsonConverter))]
        public global::G.DataType? DataType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tenant_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid TenantId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("example_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ExampleCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int SessionCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modified_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime ModifiedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_session_start_time")]
        public global::System.DateTime? LastSessionStartTime { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Dataset" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="createdAt"></param>
        /// <param name="inputsSchemaDefinition"></param>
        /// <param name="outputsSchemaDefinition"></param>
        /// <param name="externallyManaged">
        /// Default Value: false
        /// </param>
        /// <param name="dataType">
        /// Enum for dataset data types.
        /// </param>
        /// <param name="id"></param>
        /// <param name="tenantId"></param>
        /// <param name="exampleCount"></param>
        /// <param name="sessionCount"></param>
        /// <param name="modifiedAt"></param>
        /// <param name="lastSessionStartTime"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public Dataset(
            string name,
            global::System.Guid id,
            global::System.Guid tenantId,
            int exampleCount,
            int sessionCount,
            global::System.DateTime modifiedAt,
            string? description,
            global::System.DateTime? createdAt,
            object? inputsSchemaDefinition,
            object? outputsSchemaDefinition,
            bool? externallyManaged,
            global::G.DataType? dataType,
            global::System.DateTime? lastSessionStartTime)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Id = id;
            this.TenantId = tenantId;
            this.ExampleCount = exampleCount;
            this.SessionCount = sessionCount;
            this.ModifiedAt = modifiedAt;
            this.Description = description;
            this.CreatedAt = createdAt;
            this.InputsSchemaDefinition = inputsSchemaDefinition;
            this.OutputsSchemaDefinition = outputsSchemaDefinition;
            this.ExternallyManaged = externallyManaged;
            this.DataType = dataType;
            this.LastSessionStartTime = lastSessionStartTime;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Dataset" /> class.
        /// </summary>
        public Dataset()
        {
        }
    }
}