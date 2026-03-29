//HintName: G.Models.CreateArchivalMemory.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateArchivalMemory
    {
        /// <summary>
        /// Text to write to archival memory.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// Optional list of tags to attach to the memory.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// Optional timestamp for the memory (defaults to current UTC time).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateArchivalMemory" /> class.
        /// </summary>
        /// <param name="text">
        /// Text to write to archival memory.
        /// </param>
        /// <param name="tags">
        /// Optional list of tags to attach to the memory.
        /// </param>
        /// <param name="createdAt">
        /// Optional timestamp for the memory (defaults to current UTC time).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateArchivalMemory(
            string text,
            global::System.Collections.Generic.IList<string>? tags,
            global::System.DateTime? createdAt)
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Tags = tags;
            this.CreatedAt = createdAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateArchivalMemory" /> class.
        /// </summary>
        public CreateArchivalMemory()
        {
        }
    }
}