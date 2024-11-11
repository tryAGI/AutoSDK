//HintName: G.Models.BatchRequestCounts.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The request counts for different statuses within the batch.
    /// </summary>
    public sealed partial class BatchRequestCounts
    {
        /// <summary>
        /// Total number of requests in the batch.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Total { get; set; }

        /// <summary>
        /// Number of requests that have been completed successfully.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Completed { get; set; }

        /// <summary>
        /// Number of requests that have failed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Failed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchRequestCounts" /> class.
        /// </summary>
        /// <param name="total">
        /// Total number of requests in the batch.
        /// </param>
        /// <param name="completed">
        /// Number of requests that have been completed successfully.
        /// </param>
        /// <param name="failed">
        /// Number of requests that have failed.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public BatchRequestCounts(
            int total,
            int completed,
            int failed)
        {
            this.Total = total;
            this.Completed = completed;
            this.Failed = failed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchRequestCounts" /> class.
        /// </summary>
        public BatchRequestCounts()
        {
        }
    }
}