//HintName: G.Models.MemoryInputMetadata.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Additional metadata associated with the memory, which can be used to store any additional information or context about the memory. Best practice for incorporating additional information is through metadata (e.g. location, time, ids, etc.). During retrieval, you can either use these metadata alongside the query to fetch relevant memories or retrieve memories based on the query first and then refine the results using metadata during post-processing.
    /// </summary>
    public sealed partial class MemoryInputMetadata
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}