//HintName: G.Models.VectorStoreObjectFileCounts.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VectorStoreObjectFileCounts
    {
        /// <summary>
        /// The number of files that are currently being processed.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("in_progress", Required = global::Newtonsoft.Json.Required.Always)]
        public int InProgress { get; set; } = default!;

        /// <summary>
        /// The number of files that have been successfully processed.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("completed", Required = global::Newtonsoft.Json.Required.Always)]
        public int Completed { get; set; } = default!;

        /// <summary>
        /// The number of files that have failed to process.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("failed", Required = global::Newtonsoft.Json.Required.Always)]
        public int Failed { get; set; } = default!;

        /// <summary>
        /// The number of files that were cancelled.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cancelled", Required = global::Newtonsoft.Json.Required.Always)]
        public int Cancelled { get; set; } = default!;

        /// <summary>
        /// The total number of files.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total", Required = global::Newtonsoft.Json.Required.Always)]
        public int Total { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}