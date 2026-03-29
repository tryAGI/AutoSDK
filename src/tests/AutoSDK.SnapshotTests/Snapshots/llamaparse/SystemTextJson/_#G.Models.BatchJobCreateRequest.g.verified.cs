//HintName: G.Models.BatchJobCreateRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Request to create a batch processing job.<br/>
    /// Supports two modes:<br/>
    /// 1. Directory mode: Process all files in a directory (use directory_id)<br/>
    /// 2. Item list mode: Process specific items (use item_ids). Project must be provided via validate_project dependency.
    /// </summary>
    public sealed partial class BatchJobCreateRequest
    {
        /// <summary>
        /// ID of the directory containing files to process
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("directory_id")]
        public string? DirectoryId { get; set; }

        /// <summary>
        /// List of specific item IDs to process. Either this or directory_id must be provided.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("item_ids")]
        public global::System.Collections.Generic.IList<string>? ItemIds { get; set; }

        /// <summary>
        /// Job configuration — either a parse or classify config
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("job_config")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<global::G.BatchParseJobRecordCreate, global::G.ClassifyJob>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.AnyOf<global::G.BatchParseJobRecordCreate, global::G.ClassifyJob> JobConfig { get; set; }

        /// <summary>
        /// Number of files to process per batch when using directory mode<br/>
        /// Default Value: 100
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("page_size")]
        public int? PageSize { get; set; }

        /// <summary>
        /// Maximum files to process per execution cycle in directory mode. Defaults to page_size.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("continue_as_new_threshold")]
        public int? ContinueAsNewThreshold { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchJobCreateRequest" /> class.
        /// </summary>
        /// <param name="jobConfig">
        /// Job configuration — either a parse or classify config
        /// </param>
        /// <param name="directoryId">
        /// ID of the directory containing files to process
        /// </param>
        /// <param name="itemIds">
        /// List of specific item IDs to process. Either this or directory_id must be provided.
        /// </param>
        /// <param name="pageSize">
        /// Number of files to process per batch when using directory mode<br/>
        /// Default Value: 100
        /// </param>
        /// <param name="continueAsNewThreshold">
        /// Maximum files to process per execution cycle in directory mode. Defaults to page_size.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BatchJobCreateRequest(
            global::G.AnyOf<global::G.BatchParseJobRecordCreate, global::G.ClassifyJob> jobConfig,
            string? directoryId,
            global::System.Collections.Generic.IList<string>? itemIds,
            int? pageSize,
            int? continueAsNewThreshold)
        {
            this.DirectoryId = directoryId;
            this.ItemIds = itemIds;
            this.JobConfig = jobConfig;
            this.PageSize = pageSize;
            this.ContinueAsNewThreshold = continueAsNewThreshold;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchJobCreateRequest" /> class.
        /// </summary>
        public BatchJobCreateRequest()
        {
        }
    }
}