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
        [global::Newtonsoft.Json.JsonProperty("configuration")]
        public global::G.OneOf<object, global::G.CollectionConfiguration>? Configuration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("get_or_create")]
        public bool? GetOrCreate { get; set; }

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCollectionPayload" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="configuration"></param>
        /// <param name="getOrCreate"></param>
        /// <param name="metadata"></param>
        /// <param name="schema"></param>
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