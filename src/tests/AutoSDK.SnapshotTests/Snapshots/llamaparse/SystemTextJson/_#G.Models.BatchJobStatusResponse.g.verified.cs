//HintName: G.Models.BatchJobStatusResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Detailed status response for a batch processing job.
    /// </summary>
    public sealed partial class BatchJobStatusResponse
    {
        /// <summary>
        /// Response schema for a batch processing job.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("job")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.BatchJobResponse Job { get; set; }

        /// <summary>
        /// Percentage of items processed (0-100)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("progress_percentage")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double ProgressPercentage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchJobStatusResponse" /> class.
        /// </summary>
        /// <param name="job">
        /// Response schema for a batch processing job.
        /// </param>
        /// <param name="progressPercentage">
        /// Percentage of items processed (0-100)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BatchJobStatusResponse(
            global::G.BatchJobResponse job,
            double progressPercentage)
        {
            this.Job = job ?? throw new global::System.ArgumentNullException(nameof(job));
            this.ProgressPercentage = progressPercentage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchJobStatusResponse" /> class.
        /// </summary>
        public BatchJobStatusResponse()
        {
        }
    }
}