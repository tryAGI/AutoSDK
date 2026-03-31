//HintName: G.Models.FileCounts.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Tracks counts of files in different states within a store.
    /// </summary>
    public sealed partial class FileCounts
    {
        /// <summary>
        /// Number of files waiting to be processed<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pending")]
        public int? Pending { get; set; }

        /// <summary>
        /// Number of files currently being processed<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("in_progress")]
        public int? InProgress { get; set; }

        /// <summary>
        /// Number of files whose processing was cancelled<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cancelled")]
        public int? Cancelled { get; set; }

        /// <summary>
        /// Number of successfully processed files<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completed")]
        public int? Completed { get; set; }

        /// <summary>
        /// Number of files that failed processing<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failed")]
        public int? Failed { get; set; }

        /// <summary>
        /// Total number of files<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total")]
        public int? Total { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FileCounts" /> class.
        /// </summary>
        /// <param name="pending">
        /// Number of files waiting to be processed<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="inProgress">
        /// Number of files currently being processed<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="cancelled">
        /// Number of files whose processing was cancelled<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="completed">
        /// Number of successfully processed files<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="failed">
        /// Number of files that failed processing<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="total">
        /// Total number of files<br/>
        /// Default Value: 0
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FileCounts(
            int? pending,
            int? inProgress,
            int? cancelled,
            int? completed,
            int? failed,
            int? total)
        {
            this.Pending = pending;
            this.InProgress = inProgress;
            this.Cancelled = cancelled;
            this.Completed = completed;
            this.Failed = failed;
            this.Total = total;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FileCounts" /> class.
        /// </summary>
        public FileCounts()
        {
        }
    }
}