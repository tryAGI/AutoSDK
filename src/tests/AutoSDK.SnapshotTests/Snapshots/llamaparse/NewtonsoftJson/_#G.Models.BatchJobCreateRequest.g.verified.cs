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
        [global::Newtonsoft.Json.JsonProperty("directory_id")]
        public string? DirectoryId { get; set; }

        /// <summary>
        /// List of specific item IDs to process. Either this or directory_id must be provided.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("item_ids")]
        public global::System.Collections.Generic.IList<string>? ItemIds { get; set; }

        /// <summary>
        /// Job configuration — either a parse or classify config
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("job_config", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AnyOf<global::G.BatchParseJobRecordCreate, global::G.ClassifyJob> JobConfig { get; set; } = default!;

        /// <summary>
        /// Number of files to process per batch when using directory mode<br/>
        /// Default Value: 100
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("page_size")]
        public int? PageSize { get; set; }

        /// <summary>
        /// Maximum files to process per execution cycle in directory mode. Defaults to page_size.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("continue_as_new_threshold")]
        public int? ContinueAsNewThreshold { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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