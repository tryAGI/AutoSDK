//HintName: G.Models.GraphFileStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GraphFileStatus
    {
        /// <summary>
        /// The number of files currently being processed.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("in_progress", Required = global::Newtonsoft.Json.Required.Always)]
        public long InProgress { get; set; } = default!;

        /// <summary>
        /// The number of files that have been successfully processed.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("completed", Required = global::Newtonsoft.Json.Required.Always)]
        public long Completed { get; set; } = default!;

        /// <summary>
        /// The number of files that failed to process.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("failed", Required = global::Newtonsoft.Json.Required.Always)]
        public long Failed { get; set; } = default!;

        /// <summary>
        /// The total number of files associated with the Knowledge Graph.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total", Required = global::Newtonsoft.Json.Required.Always)]
        public long Total { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GraphFileStatus" /> class.
        /// </summary>
        /// <param name="inProgress">
        /// The number of files currently being processed.
        /// </param>
        /// <param name="completed">
        /// The number of files that have been successfully processed.
        /// </param>
        /// <param name="failed">
        /// The number of files that failed to process.
        /// </param>
        /// <param name="total">
        /// The total number of files associated with the Knowledge Graph.
        /// </param>
        public GraphFileStatus(
            long inProgress,
            long completed,
            long failed,
            long total)
        {
            this.InProgress = inProgress;
            this.Completed = completed;
            this.Failed = failed;
            this.Total = total;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GraphFileStatus" /> class.
        /// </summary>
        public GraphFileStatus()
        {
        }
    }
}