//HintName: G.Models.DataSinkCreate.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Schema for creating a data sink.
    /// </summary>
    public sealed partial class DataSinkCreate
    {
        /// <summary>
        /// The name of the data sink.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sink_type", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ConfigurableDataSinkNames SinkType { get; set; } = default!;

        /// <summary>
        /// Component that implements the data sink
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("component", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AnyOf<object, global::G.CloudPineconeVectorStore, global::G.CloudPostgresVectorStore, global::G.CloudQdrantVectorStore, global::G.CloudAzureAISearchVectorStore, global::G.CloudMongoDBAtlasVectorSearch, global::G.CloudMilvusVectorStore, global::G.CloudAstraDBVectorStore> Component { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DataSinkCreate" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the data sink.
        /// </param>
        /// <param name="sinkType"></param>
        /// <param name="component">
        /// Component that implements the data sink
        /// </param>
        public DataSinkCreate(
            string name,
            global::G.ConfigurableDataSinkNames sinkType,
            global::G.AnyOf<object, global::G.CloudPineconeVectorStore, global::G.CloudPostgresVectorStore, global::G.CloudQdrantVectorStore, global::G.CloudAzureAISearchVectorStore, global::G.CloudMongoDBAtlasVectorSearch, global::G.CloudMilvusVectorStore, global::G.CloudAstraDBVectorStore> component)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.SinkType = sinkType;
            this.Component = component;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DataSinkCreate" /> class.
        /// </summary>
        public DataSinkCreate()
        {
        }
    }
}