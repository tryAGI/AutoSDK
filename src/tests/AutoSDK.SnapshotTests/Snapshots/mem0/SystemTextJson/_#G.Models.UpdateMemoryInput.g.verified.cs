//HintName: G.Models.UpdateMemoryInput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Input for updating an existing memory.
    /// </summary>
    public sealed partial class UpdateMemoryInput
    {
        /// <summary>
        /// The unique identifier of the memory to update
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("memory_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid MemoryId { get; set; }

        /// <summary>
        /// The new text content to update the memory with
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateMemoryInput" /> class.
        /// </summary>
        /// <param name="memoryId">
        /// The unique identifier of the memory to update
        /// </param>
        /// <param name="text">
        /// The new text content to update the memory with
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateMemoryInput(
            global::System.Guid memoryId,
            string text)
        {
            this.MemoryId = memoryId;
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateMemoryInput" /> class.
        /// </summary>
        public UpdateMemoryInput()
        {
        }
    }
}