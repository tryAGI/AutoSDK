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
        [global::System.Text.Json.Serialization.JsonPropertyName("in_progress")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long InProgress { get; set; }

        /// <summary>
        /// The number of files that have been successfully processed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long Completed { get; set; }

        /// <summary>
        /// The number of files that failed to process.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long Failed { get; set; }

        /// <summary>
        /// The total number of files associated with the Knowledge Graph.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long Total { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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