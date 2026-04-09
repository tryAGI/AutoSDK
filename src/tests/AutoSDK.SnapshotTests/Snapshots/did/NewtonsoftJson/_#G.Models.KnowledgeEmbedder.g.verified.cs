//HintName: G.Models.KnowledgeEmbedder.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class KnowledgeEmbedder
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("provider", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.KnowledgeEmbedderProviderJsonConverter))]
        public global::G.KnowledgeEmbedderProvider Provider { get; set; } = default!;

        /// <summary>
        /// name of model from provider to use
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model", Required = global::Newtonsoft.Json.Required.Always)]
        public string Model { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("trim")]
        public global::G.KnowledgeEmbedderTrim? Trim { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeEmbedder" /> class.
        /// </summary>
        /// <param name="provider"></param>
        /// <param name="model">
        /// name of model from provider to use
        /// </param>
        /// <param name="trim"></param>
        public KnowledgeEmbedder(
            global::G.KnowledgeEmbedderProvider provider,
            string model,
            global::G.KnowledgeEmbedderTrim? trim)
        {
            this.Provider = provider;
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Trim = trim;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeEmbedder" /> class.
        /// </summary>
        public KnowledgeEmbedder()
        {
        }
    }
}