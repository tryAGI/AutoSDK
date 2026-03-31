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
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.KnowledgeEmbedderProviderJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.KnowledgeEmbedderProvider Provider { get; set; }

        /// <summary>
        /// name of model from provider to use
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trim")]
        public global::G.KnowledgeEmbedderTrim? Trim { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeEmbedder" /> class.
        /// </summary>
        /// <param name="provider"></param>
        /// <param name="model">
        /// name of model from provider to use
        /// </param>
        /// <param name="trim"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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