//HintName: G.Models.VecItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VecItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("configuration_json", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.CollectionConfiguration ConfigurationJson { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("database", Required = global::Newtonsoft.Json.Required.Always)]
        public string Database { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dimension")]
        public int? Dimension { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("log_position", Required = global::Newtonsoft.Json.Required.Always)]
        public long LogPosition { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public global::G.OneOf<object, global::G.HashMap>? Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("schema")]
        public global::G.OneOf<object, global::G.Schema3>? Schema { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tenant", Required = global::Newtonsoft.Json.Required.Always)]
        public string Tenant { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("version", Required = global::Newtonsoft.Json.Required.Always)]
        public int Version { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VecItem" /> class.
        /// </summary>
        /// <param name="configurationJson"></param>
        /// <param name="database"></param>
        /// <param name="id"></param>
        /// <param name="logPosition"></param>
        /// <param name="name"></param>
        /// <param name="tenant"></param>
        /// <param name="version"></param>
        /// <param name="dimension"></param>
        /// <param name="metadata"></param>
        /// <param name="schema"></param>
        public VecItem(
            global::G.CollectionConfiguration configurationJson,
            string database,
            global::System.Guid id,
            long logPosition,
            string name,
            string tenant,
            int version,
            int? dimension,
            global::G.OneOf<object, global::G.HashMap>? metadata,
            global::G.OneOf<object, global::G.Schema3>? schema)
        {
            this.ConfigurationJson = configurationJson ?? throw new global::System.ArgumentNullException(nameof(configurationJson));
            this.Database = database ?? throw new global::System.ArgumentNullException(nameof(database));
            this.Dimension = dimension;
            this.Id = id;
            this.LogPosition = logPosition;
            this.Metadata = metadata;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Schema = schema;
            this.Tenant = tenant ?? throw new global::System.ArgumentNullException(nameof(tenant));
            this.Version = version;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VecItem" /> class.
        /// </summary>
        public VecItem()
        {
        }
    }
}