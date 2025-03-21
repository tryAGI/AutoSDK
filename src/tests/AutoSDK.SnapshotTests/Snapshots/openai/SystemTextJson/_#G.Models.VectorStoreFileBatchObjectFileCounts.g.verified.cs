//HintName: G.Models.VectorStoreFileBatchObjectFileCounts.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VectorStoreFileBatchObjectFileCounts
    {
        /// <summary>
        /// The number of files that where cancelled.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cancelled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Cancelled { get; set; }

        /// <summary>
        /// The number of files that have been processed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Completed { get; set; }

        /// <summary>
        /// The number of files that have failed to process.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Failed { get; set; }

        /// <summary>
        /// The number of files that are currently being processed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("in_progress")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int InProgress { get; set; }

        /// <summary>
        /// The total number of files.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Total { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VectorStoreFileBatchObjectFileCounts" /> class.
        /// </summary>
        /// <param name="cancelled">
        /// The number of files that where cancelled.
        /// </param>
        /// <param name="completed">
        /// The number of files that have been processed.
        /// </param>
        /// <param name="failed">
        /// The number of files that have failed to process.
        /// </param>
        /// <param name="inProgress">
        /// The number of files that are currently being processed.
        /// </param>
        /// <param name="total">
        /// The total number of files.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VectorStoreFileBatchObjectFileCounts(
            int cancelled,
            int completed,
            int failed,
            int inProgress,
            int total)
        {
            this.Cancelled = cancelled;
            this.Completed = completed;
            this.Failed = failed;
            this.InProgress = inProgress;
            this.Total = total;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VectorStoreFileBatchObjectFileCounts" /> class.
        /// </summary>
        public VectorStoreFileBatchObjectFileCounts()
        {
        }
    }
}