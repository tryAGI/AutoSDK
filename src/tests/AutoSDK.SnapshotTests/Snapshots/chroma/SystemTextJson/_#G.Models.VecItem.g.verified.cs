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
        [global::System.Text.Json.Serialization.JsonPropertyName("configuration_json")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.CollectionConfiguration ConfigurationJson { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("database")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Database { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dimension")]
        public int? Dimension { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("log_position")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long LogPosition { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverter<object, global::G.HashMap>))]
        public global::G.OneOf<object, global::G.HashMap>? Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("schema")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverter<object, global::G.Schema3>))]
        public global::G.OneOf<object, global::G.Schema3>? Schema { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tenant")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Tenant { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Version { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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