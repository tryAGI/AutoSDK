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
        [global::Newtonsoft.Json.JsonProperty("memory_id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid MemoryId { get; set; } = default!;

        /// <summary>
        /// The new text content to update the memory with
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text", Required = global::Newtonsoft.Json.Required.Always)]
        public string Text { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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