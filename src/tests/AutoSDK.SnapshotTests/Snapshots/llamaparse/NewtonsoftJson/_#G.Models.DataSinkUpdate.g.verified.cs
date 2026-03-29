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
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sink_type", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ConfigurableDataSinkNames SinkType { get; set; } = default!;

        /// <summary>
        /// Component that implements the data sink
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("component")]
        public global::G.AnyOf<object, global::G.CloudPineconeVectorStore, global::G.CloudPostgresVectorStore, global::G.CloudQdrantVectorStore, global::G.CloudAzureAISearchVectorStore, global::G.CloudMongoDBAtlasVectorSearch, global::G.CloudMilvusVectorStore, global::G.CloudAstraDBVectorStore, object>? Component { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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