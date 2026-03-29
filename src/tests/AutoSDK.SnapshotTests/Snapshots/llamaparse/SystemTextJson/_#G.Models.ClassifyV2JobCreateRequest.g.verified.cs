//HintName: G.Models.ClassifyV2JobCreateRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Request to create a classify job.
    /// </summary>
    public sealed partial class ClassifyV2JobCreateRequest
    {
        /// <summary>
        /// File ID to classify
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_id")]
        public string? FileId { get; set; }

        /// <summary>
        /// Parse job ID to classify
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parse_job_id")]
        public string? ParseJobId { get; set; }

        /// <summary>
        /// Inline classify configuration (required if configuration_id is not provided)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("configuration")]
        public global::G.ClassifyV2Configuration? Configuration { get; set; }

        /// <summary>
        /// Product configuration ID for reusable presets
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("configuration_id")]
        public string? ConfigurationId { get; set; }

        /// <summary>
        /// Idempotency key scoped to the project
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transaction_id")]
        public string? TransactionId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ClassifyV2JobCreateRequest" /> class.
        /// </summary>
        /// <param name="fileId">
        /// File ID to classify
        /// </param>
        /// <param name="parseJobId">
        /// Parse job ID to classify
        /// </param>
        /// <param name="configuration">
        /// Inline classify configuration (required if configuration_id is not provided)
        /// </param>
        /// <param name="configurationId">
        /// Product configuration ID for reusable presets
        /// </param>
        /// <param name="transactionId">
        /// Idempotency key scoped to the project
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ClassifyV2JobCreateRequest(
            string? fileId,
            string? parseJobId,
            global::G.ClassifyV2Configuration? configuration,
            string? configurationId,
            string? transactionId)
        {
            this.FileId = fileId;
            this.ParseJobId = parseJobId;
            this.Configuration = configuration;
            this.ConfigurationId = configurationId;
            this.TransactionId = transactionId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClassifyV2JobCreateRequest" /> class.
        /// </summary>
        public ClassifyV2JobCreateRequest()
        {
        }
    }
}