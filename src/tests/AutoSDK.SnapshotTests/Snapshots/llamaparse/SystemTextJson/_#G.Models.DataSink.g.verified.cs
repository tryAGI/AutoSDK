//HintName: G.Models.DataSink.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Schema for a data sink.
    /// </summary>
    public sealed partial class DataSink
    {
        /// <summary>
        /// Unique identifier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// Creation datetime
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Update datetime
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// The name of the data sink.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sink_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ConfigurableDataSinkNamesJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ConfigurableDataSinkNames SinkType { get; set; }

        /// <summary>
        /// Component that implements the data sink
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("component")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<object, global::G.CloudPineconeVectorStore, global::G.CloudPostgresVectorStore, global::G.CloudQdrantVectorStore, global::G.CloudAzureAISearchVectorStore, global::G.CloudMongoDBAtlasVectorSearch, global::G.CloudMilvusVectorStore, global::G.CloudAstraDBVectorStore>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.AnyOf<object, global::G.CloudPineconeVectorStore, global::G.CloudPostgresVectorStore, global::G.CloudQdrantVectorStore, global::G.CloudAzureAISearchVectorStore, global::G.CloudMongoDBAtlasVectorSearch, global::G.CloudMilvusVectorStore, global::G.CloudAstraDBVectorStore> Component { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid ProjectId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DataSink" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier
        /// </param>
        /// <param name="name">
        /// The name of the data sink.
        /// </param>
        /// <param name="sinkType"></param>
        /// <param name="component">
        /// Component that implements the data sink
        /// </param>
        /// <param name="projectId"></param>
        /// <param name="createdAt">
        /// Creation datetime
        /// </param>
        /// <param name="updatedAt">
        /// Update datetime
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DataSink(
            global::System.Guid id,
            string name,
            global::G.ConfigurableDataSinkNames sinkType,
            global::G.AnyOf<object, global::G.CloudPineconeVectorStore, global::G.CloudPostgresVectorStore, global::G.CloudQdrantVectorStore, global::G.CloudAzureAISearchVectorStore, global::G.CloudMongoDBAtlasVectorSearch, global::G.CloudMilvusVectorStore, global::G.CloudAstraDBVectorStore> component,
            global::System.Guid projectId,
            global::System.DateTime? createdAt,
            global::System.DateTime? updatedAt)
        {
            this.Id = id;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.SinkType = sinkType;
            this.Component = component;
            this.ProjectId = projectId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DataSink" /> class.
        /// </summary>
        public DataSink()
        {
        }
    }
}