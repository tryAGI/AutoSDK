//HintName: G.Models.BackupListResponseItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BackupListResponseItem
    {
        /// <summary>
        /// The ID of the backup. Must be URL-safe and work as a filesystem path, only lowercase, numbers, underscore, minus characters allowed.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// destination path of backup files proper to selected backend
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("path")]
        public string? Path { get; set; }

        /// <summary>
        /// The list of classes for which the existed backup process
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("classes")]
        public global::System.Collections.Generic.IList<string>? Classes { get; set; }

        /// <summary>
        /// status of backup process
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status")]
        public global::G.BackupListResponseItemStatus? Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BackupListResponseItem" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the backup. Must be URL-safe and work as a filesystem path, only lowercase, numbers, underscore, minus characters allowed.
        /// </param>
        /// <param name="path">
        /// destination path of backup files proper to selected backend
        /// </param>
        /// <param name="classes">
        /// The list of classes for which the existed backup process
        /// </param>
        /// <param name="status">
        /// status of backup process
        /// </param>
        public BackupListResponseItem(
            string? id,
            string? path,
            global::System.Collections.Generic.IList<string>? classes,
            global::G.BackupListResponseItemStatus? status)
        {
            this.Id = id;
            this.Path = path;
            this.Classes = classes;
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BackupListResponseItem" /> class.
        /// </summary>
        public BackupListResponseItem()
        {
        }
    }
}