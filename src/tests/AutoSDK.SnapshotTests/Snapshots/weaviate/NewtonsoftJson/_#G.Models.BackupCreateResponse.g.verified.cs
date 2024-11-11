//HintName: G.Models.BackupCreateResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The definition of a backup create response body
    /// </summary>
    public sealed partial class BackupCreateResponse
    {
        /// <summary>
        /// The ID of the backup. Must be URL-safe and work as a filesystem path, only lowercase, numbers, underscore, minus characters allowed.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The list of classes for which the backup creation process was started
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("classes")]
        public global::System.Collections.Generic.IList<string>? Classes { get; set; }

        /// <summary>
        /// Backup backend name e.g. filesystem, gcs, s3.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("backend")]
        public string? Backend { get; set; }

        /// <summary>
        /// destination path of backup files proper to selected backend
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("path")]
        public string? Path { get; set; }

        /// <summary>
        /// error message if creation failed
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("error")]
        public string? Error { get; set; }

        /// <summary>
        /// phase of backup creation process<br/>
        /// Default Value: STARTED
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status")]
        public global::G.BackupCreateResponseStatus? Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BackupCreateResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the backup. Must be URL-safe and work as a filesystem path, only lowercase, numbers, underscore, minus characters allowed.
        /// </param>
        /// <param name="classes">
        /// The list of classes for which the backup creation process was started
        /// </param>
        /// <param name="backend">
        /// Backup backend name e.g. filesystem, gcs, s3.
        /// </param>
        /// <param name="path">
        /// destination path of backup files proper to selected backend
        /// </param>
        /// <param name="error">
        /// error message if creation failed
        /// </param>
        /// <param name="status">
        /// phase of backup creation process<br/>
        /// Default Value: STARTED
        /// </param>
        public BackupCreateResponse(
            string? id,
            global::System.Collections.Generic.IList<string>? classes,
            string? backend,
            string? path,
            string? error,
            global::G.BackupCreateResponseStatus? status)
        {
            this.Id = id;
            this.Classes = classes;
            this.Backend = backend;
            this.Path = path;
            this.Error = error;
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BackupCreateResponse" /> class.
        /// </summary>
        public BackupCreateResponse()
        {
        }
    }
}