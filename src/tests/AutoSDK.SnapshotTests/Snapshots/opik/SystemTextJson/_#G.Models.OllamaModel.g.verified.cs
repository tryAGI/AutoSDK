//HintName: G.Models.OllamaModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Ollama model information
    /// </summary>
    public sealed partial class OllamaModel
    {
        /// <summary>
        /// Model name<br/>
        /// Example: llama2
        /// </summary>
        /// <example>llama2</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Model size in bytes
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("size")]
        public long? Size { get; set; }

        /// <summary>
        /// Model digest/hash
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("digest")]
        public string? Digest { get; set; }

        /// <summary>
        /// Model modification date
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modified_at")]
        public global::System.DateTime? ModifiedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OllamaModel" /> class.
        /// </summary>
        /// <param name="name">
        /// Model name<br/>
        /// Example: llama2
        /// </param>
        /// <param name="size">
        /// Model size in bytes
        /// </param>
        /// <param name="digest">
        /// Model digest/hash
        /// </param>
        /// <param name="modifiedAt">
        /// Model modification date
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OllamaModel(
            string name,
            long? size,
            string? digest,
            global::System.DateTime? modifiedAt)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Size = size;
            this.Digest = digest;
            this.ModifiedAt = modifiedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OllamaModel" /> class.
        /// </summary>
        public OllamaModel()
        {
        }
    }
}