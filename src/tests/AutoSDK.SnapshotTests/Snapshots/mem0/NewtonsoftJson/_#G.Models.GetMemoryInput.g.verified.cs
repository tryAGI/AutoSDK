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
        [global::Newtonsoft.Json.JsonProperty("memory_id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid MemoryId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetMemoryInput" /> class.
        /// </summary>
        /// <param name="memoryId">
        /// The unique identifier of the memory
        /// </param>
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