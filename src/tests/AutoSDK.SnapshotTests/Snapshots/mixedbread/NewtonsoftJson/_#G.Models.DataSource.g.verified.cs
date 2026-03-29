//HintName: G.Models.DataSource.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Service-level representation of a data source.
    /// </summary>
    public sealed partial class DataSource
    {
        /// <summary>
        /// The ID of the data source
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// The creation time of the data source
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// The last update time of the data source
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime UpdatedAt { get; set; } = default!;

        /// <summary>
        /// The type of data source
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.DataSourceType Type { get; set; } = default!;

        /// <summary>
        /// The name of the data source
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// The metadata of the data source
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Authentication parameters
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("auth_params")]
        public global::G.AuthParamsVariant1? AuthParams { get; set; }

        /// <summary>
        /// The type of the object<br/>
        /// Default Value: data_source
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("object")]
        public string? Object { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DataSource" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the data source
        /// </param>
        /// <param name="createdAt">
        /// The creation time of the data source
        /// </param>
        /// <param name="updatedAt">
        /// The last update time of the data source
        /// </param>
        /// <param name="type">
        /// The type of data source
        /// </param>
        /// <param name="name">
        /// The name of the data source
        /// </param>
        /// <param name="metadata">
        /// The metadata of the data source
        /// </param>
        /// <param name="authParams">
        /// Authentication parameters
        /// </param>
        /// <param name="object">
        /// The type of the object<br/>
        /// Default Value: data_source
        /// </param>
        public DataSource(
            string id,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            global::G.DataSourceType type,
            string name,
            object? metadata,
            global::G.AuthParamsVariant1? authParams,
            string? @object)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Type = type;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Metadata = metadata;
            this.AuthParams = authParams;
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DataSource" /> class.
        /// </summary>
        public DataSource()
        {
        }
    }
}