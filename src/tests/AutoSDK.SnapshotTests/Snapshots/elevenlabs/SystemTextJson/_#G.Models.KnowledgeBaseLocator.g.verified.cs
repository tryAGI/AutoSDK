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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.KnowledgeBaseDocumentTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.KnowledgeBaseDocumentType Type { get; set; }

        /// <summary>
        /// The name of the knowledge base
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The ID of the knowledge base
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage_mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.DocumentUsageModeEnumJsonConverter))]
        public global::G.DocumentUsageModeEnum? UsageMode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeBaseLocator" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="name">
        /// The name of the knowledge base
        /// </param>
        /// <param name="id">
        /// The ID of the knowledge base
        /// </param>
        /// <param name="usageMode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public KnowledgeBaseLocator(
            global::G.KnowledgeBaseDocumentType type,
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