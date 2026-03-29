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
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Model size in bytes
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("size")]
        public long? Size { get; set; }

        /// <summary>
        /// Model digest/hash
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("digest")]
        public string? Digest { get; set; }

        /// <summary>
        /// Model modification date
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("modified_at")]
        public global::System.DateTime? ModifiedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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