//HintName: G.Models.CreateCollectionPayload.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateCollectionPayload
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("configuration")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverter<object, global::G.CollectionConfiguration>))]
        public global::G.OneOf<object, global::G.CollectionConfiguration>? Configuration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("get_or_create")]
        public bool? GetOrCreate { get; set; }

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCollectionPayload" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="configuration"></param>
        /// <param name="getOrCreate"></param>
        /// <param name="metadata"></param>
        /// <param name="schema"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateCollectionPayload(
            string name,
            global::G.OneOf<object, global::G.CollectionConfiguration>? configuration,
            bool? getOrCreate,
            global::G.OneOf<object, global::G.HashMap>? metadata,
            global::G.OneOf<object, global::G.Schema3>? schema)
        {
            this.Configuration = configuration;
            this.GetOrCreate = getOrCreate;
            this.Metadata = metadata;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Schema = schema;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCollectionPayload" /> class.
        /// </summary>
        public CreateCollectionPayload()
        {
        }
    }
}