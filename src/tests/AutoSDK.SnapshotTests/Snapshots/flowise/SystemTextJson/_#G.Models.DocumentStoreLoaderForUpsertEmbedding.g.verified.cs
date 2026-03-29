//HintName: G.Models.DocumentStoreLoaderForUpsertEmbedding.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DocumentStoreLoaderForUpsertEmbedding
    {
        /// <summary>
        /// Name of the embedding generator (camelCase)<br/>
        /// Example: openAIEmbeddings
        /// </summary>
        /// <example>openAIEmbeddings</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Configuration for the embedding generator
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        public object? Config { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentStoreLoaderForUpsertEmbedding" /> class.
        /// </summary>
        /// <param name="name">
        /// Name of the embedding generator (camelCase)<br/>
        /// Example: openAIEmbeddings
        /// </param>
        /// <param name="config">
        /// Configuration for the embedding generator
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DocumentStoreLoaderForUpsertEmbedding(
            string? name,
            object? config)
        {
            this.Name = name;
            this.Config = config;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentStoreLoaderForUpsertEmbedding" /> class.
        /// </summary>
        public DocumentStoreLoaderForUpsertEmbedding()
        {
        }
    }
}