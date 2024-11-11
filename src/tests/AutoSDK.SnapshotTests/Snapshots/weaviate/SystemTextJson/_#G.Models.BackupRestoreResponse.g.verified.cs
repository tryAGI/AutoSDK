//HintName: G.Models.BackupRestoreResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The definition of a backup restore response body
    /// </summary>
    public sealed partial class BackupRestoreResponse
    {
        /// <summary>
        /// The ID of the backup. Must be URL-safe and work as a filesystem path, only lowercase, numbers, underscore, minus characters allowed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The list of classes for which the backup restoration process was started
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("classes")]
        public global::System.Collections.Generic.IList<string>? Classes { get; set; }

        /// <summary>
        /// Backup backend name e.g. filesystem, gcs, s3.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("backend")]
        public string? Backend { get; set; }

        /// <summary>
        /// destination path of backup files proper to selected backend
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        public string? Path { get; set; }

        /// <summary>
        /// error message if restoration failed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; set; }

        /// <summary>
        /// phase of backup restoration process<br/>
        /// Default Value: STARTED
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.BackupRestoreResponseStatusJsonConverter))]
        public global::G.BackupRestoreResponseStatus? Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BackupRestoreResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the backup. Must be URL-safe and work as a filesystem path, only lowercase, numbers, underscore, minus characters allowed.
        /// </param>
        /// <param name="classes">
        /// The list of classes for which the backup restoration process was started
        /// </param>
        /// <param name="backend">
        /// Backup backend name e.g. filesystem, gcs, s3.
        /// </param>
        /// <param name="path">
        /// destination path of backup files proper to selected backend
        /// </param>
        /// <param name="error">
        /// error message if restoration failed
        /// </param>
        /// <param name="status">
        /// phase of backup restoration process<br/>
        /// Default Value: STARTED
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public BackupRestoreResponse(
            string? id,
            global::System.Collections.Generic.IList<string>? classes,
            string? backend,
            string? path,
            string? error,
            global::G.BackupRestoreResponseStatus? status)
        {
            this.Id = id;
            this.Classes = classes;
            this.Backend = backend;
            this.Path = path;
            this.Error = error;
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BackupRestoreResponse" /> class.
        /// </summary>
        public BackupRestoreResponse()
        {
        }
    }
}