//HintName: G.Models.MemoriesBatchDeleteRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MemoriesBatchDeleteRequest
    {
        /// <summary>
        /// Array of memory IDs to delete.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("memory_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::System.Guid> MemoryIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MemoriesBatchDeleteRequest" /> class.
        /// </summary>
        /// <param name="memoryIds">
        /// Array of memory IDs to delete.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MemoriesBatchDeleteRequest(
            global::System.Collections.Generic.IList<global::System.Guid> memoryIds)
        {
            this.MemoryIds = memoryIds ?? throw new global::System.ArgumentNullException(nameof(memoryIds));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MemoriesBatchDeleteRequest" /> class.
        /// </summary>
        public MemoriesBatchDeleteRequest()
        {
        }
    }
}