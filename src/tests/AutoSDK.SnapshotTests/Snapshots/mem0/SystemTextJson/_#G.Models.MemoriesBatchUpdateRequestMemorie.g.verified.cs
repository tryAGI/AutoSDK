//HintName: G.Models.MemoriesBatchUpdateRequestMemorie.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MemoriesBatchUpdateRequestMemorie
    {
        /// <summary>
        /// The unique identifier of the memory to update
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("memory_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid MemoryId { get; set; }

        /// <summary>
        /// The new text content for the memory
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
        /// Initializes a new instance of the <see cref="MemoriesBatchUpdateRequestMemorie" /> class.
        /// </summary>
        /// <param name="memoryId">
        /// The unique identifier of the memory to update
        /// </param>
        /// <param name="text">
        /// The new text content for the memory
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MemoriesBatchUpdateRequestMemorie(
            global::System.Guid memoryId,
            string text)
        {
            this.MemoryId = memoryId;
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MemoriesBatchUpdateRequestMemorie" /> class.
        /// </summary>
        public MemoriesBatchUpdateRequestMemorie()
        {
        }
    }
}