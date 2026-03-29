//HintName: G.Models.DataSinkUpdate.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Schema for updating a data sink.
    /// </summary>
    public sealed partial class DataSinkUpdate
    {
        /// <summary>
        /// The name of the data sink.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<object, global::G.CloudPineconeVectorStore, global::G.CloudPostgresVectorStore, global::G.CloudQdrantVectorStore, global::G.CloudAzureAISearchVectorStore, global::G.CloudMongoDBAtlasVectorSearch, global::G.CloudMilvusVectorStore, global::G.CloudAstraDBVectorStore, object>))]
        public global::G.AnyOf<object, global::G.CloudPineconeVectorStore, global::G.CloudPostgresVectorStore, global::G.CloudQdrantVectorStore, global::G.CloudAzureAISearchVectorStore, global::G.CloudMongoDBAtlasVectorSearch, global::G.CloudMilvusVectorStore, global::G.CloudAstraDBVectorStore, object>? Component { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DataSinkUpdate" /> class.
        /// </summary>
        /// <param name="sinkType"></param>
        /// <param name="name">
        /// The name of the data sink.
        /// </param>
        /// <param name="component">
        /// Component that implements the data sink
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DataSinkUpdate(
            global::G.ConfigurableDataSinkNames sinkType,
            string? name,
            global::G.AnyOf<object, global::G.CloudPineconeVectorStore, global::G.CloudPostgresVectorStore, global::G.CloudQdrantVectorStore, global::G.CloudAzureAISearchVectorStore, global::G.CloudMongoDBAtlasVectorSearch, global::G.CloudMilvusVectorStore, global::G.CloudAstraDBVectorStore, object>? component)
        {
            this.Name = name;
            this.SinkType = sinkType;
            this.Component = component;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DataSinkUpdate" /> class.
        /// </summary>
        public DataSinkUpdate()
        {
        }
    }
}