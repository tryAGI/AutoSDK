//HintName: G.Models.KnowledgeBaseLocator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class KnowledgeBaseLocator
    {
        /// <summary>
        /// The type of the knowledge base
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.KnowledgeBaseLocatorType Type { get; set; } = default!;

        /// <summary>
        /// The name of the knowledge base
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// The ID of the knowledge base
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("usage_mode")]
        public global::G.DocumentUsageModeEnum? UsageMode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeBaseLocator" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of the knowledge base
        /// </param>
        /// <param name="name">
        /// The name of the knowledge base
        /// </param>
        /// <param name="id">
        /// The ID of the knowledge base
        /// </param>
        /// <param name="usageMode"></param>
        public KnowledgeBaseLocator(
            global::G.KnowledgeBaseLocatorType type,
            string name,
            string id,
            global::G.DocumentUsageModeEnum? usageMode)
        {
            this.Type = type;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.UsageMode = usageMode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeBaseLocator" /> class.
        /// </summary>
        public KnowledgeBaseLocator()
        {
        }
    }
}