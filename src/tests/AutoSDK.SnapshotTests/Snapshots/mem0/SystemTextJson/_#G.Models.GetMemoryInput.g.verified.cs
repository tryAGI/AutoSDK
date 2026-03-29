//HintName: G.Models.GetMemoryInput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetMemoryInput
    {
        /// <summary>
        /// The unique identifier of the memory
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("memory_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid MemoryId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetMemoryInput" /> class.
        /// </summary>
        /// <param name="memoryId">
        /// The unique identifier of the memory
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetMemoryInput(
            global::System.Guid memoryId)
        {
            this.MemoryId = memoryId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetMemoryInput" /> class.
        /// </summary>
        public GetMemoryInput()
        {
        }
    }
}