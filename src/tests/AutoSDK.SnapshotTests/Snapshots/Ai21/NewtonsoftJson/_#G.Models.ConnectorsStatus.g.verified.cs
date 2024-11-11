//HintName: G.Models.ConnectorsStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ConnectorsStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public string CreatedAt { get; set; } = default!;

        /// <summary>
        /// An enumeration.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("workflow_status", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ConnectorsWorkflowStatus WorkflowStatus { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("files_successfully_uploaded", Required = global::Newtonsoft.Json.Required.Always)]
        public int FilesSuccessfullyUploaded { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("failed_uploaded_files", Required = global::Newtonsoft.Json.Required.Always)]
        public int FailedUploadedFiles { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectorsStatus" /> class.
        /// </summary>
        /// <param name="createdAt"></param>
        /// <param name="workflowStatus">
        /// An enumeration.
        /// </param>
        /// <param name="filesSuccessfullyUploaded"></param>
        /// <param name="failedUploadedFiles"></param>
        public ConnectorsStatus(
            string createdAt,
            global::G.ConnectorsWorkflowStatus workflowStatus,
            int filesSuccessfullyUploaded,
            int failedUploadedFiles)
        {
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.WorkflowStatus = workflowStatus;
            this.FilesSuccessfullyUploaded = filesSuccessfullyUploaded;
            this.FailedUploadedFiles = failedUploadedFiles;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectorsStatus" /> class.
        /// </summary>
        public ConnectorsStatus()
        {
        }
    }
}