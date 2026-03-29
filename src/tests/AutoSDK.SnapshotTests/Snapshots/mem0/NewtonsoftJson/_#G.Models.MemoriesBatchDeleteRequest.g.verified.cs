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
        [global::Newtonsoft.Json.JsonProperty("memory_ids", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::System.Guid> MemoryIds { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MemoriesBatchDeleteRequest" /> class.
        /// </summary>
        /// <param name="memoryIds">
        /// Array of memory IDs to delete.
        /// </param>
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