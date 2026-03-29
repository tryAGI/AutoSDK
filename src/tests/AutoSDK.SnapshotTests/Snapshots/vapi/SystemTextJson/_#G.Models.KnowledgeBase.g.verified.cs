//HintName: G.Models.KnowledgeBase.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class KnowledgeBase
    {
        /// <summary>
        /// The name of the knowledge base<br/>
        /// Example: My Knowledge Base
        /// </summary>
        /// <example>My Knowledge Base</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The provider of the knowledge base<br/>
        /// Example: google
        /// </summary>
        /// <example>google</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.KnowledgeBaseProviderJsonConverter))]
        public global::G.KnowledgeBaseProvider Provider { get; set; }

        /// <summary>
        /// The model to use for the knowledge base
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.KnowledgeBaseModelJsonConverter))]
        public global::G.KnowledgeBaseModel? Model { get; set; }

        /// <summary>
        /// A description of the knowledge base
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// The file IDs associated with this knowledge base
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fileIds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> FileIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeBase" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the knowledge base<br/>
        /// Example: My Knowledge Base
        /// </param>
        /// <param name="description">
        /// A description of the knowledge base
        /// </param>
        /// <param name="fileIds">
        /// The file IDs associated with this knowledge base
        /// </param>
        /// <param name="provider">
        /// The provider of the knowledge base<br/>
        /// Example: google
        /// </param>
        /// <param name="model">
        /// The model to use for the knowledge base
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public KnowledgeBase(
            string name,
            string description,
            global::System.Collections.Generic.IList<string> fileIds,
            global::G.KnowledgeBaseProvider provider,
            global::G.KnowledgeBaseModel? model)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Provider = provider;
            this.Model = model;
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.FileIds = fileIds ?? throw new global::System.ArgumentNullException(nameof(fileIds));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeBase" /> class.
        /// </summary>
        public KnowledgeBase()
        {
        }
    }
}