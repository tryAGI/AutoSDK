//HintName: G.Models.BackupRestoreRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Request body for restoring a backup for a set of classes
    /// </summary>
    public sealed partial class BackupRestoreRequest
    {
        /// <summary>
        /// Backup custom configuration
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("config")]
        public global::G.RestoreConfig? Config { get; set; }

        /// <summary>
        /// List of collections to include in the backup restoration process. If not set, all collections are included. Cannot be used together with `exclude`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("include")]
        public global::System.Collections.Generic.IList<string>? Include { get; set; }

        /// <summary>
        /// List of collections to exclude from the backup restoration process. If not set, all collections are included. Cannot be used together with `include`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("exclude")]
        public global::System.Collections.Generic.IList<string>? Exclude { get; set; }

        /// <summary>
        /// Allows overriding the node names stored in the backup with different ones. Useful when restoring backups to a different environment.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("node_mapping")]
        public global::System.Collections.Generic.Dictionary<string, string>? NodeMapping { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BackupRestoreRequest" /> class.
        /// </summary>
        /// <param name="config">
        /// Backup custom configuration
        /// </param>
        /// <param name="include">
        /// List of collections to include in the backup restoration process. If not set, all collections are included. Cannot be used together with `exclude`.
        /// </param>
        /// <param name="exclude">
        /// List of collections to exclude from the backup restoration process. If not set, all collections are included. Cannot be used together with `include`.
        /// </param>
        /// <param name="nodeMapping">
        /// Allows overriding the node names stored in the backup with different ones. Useful when restoring backups to a different environment.
        /// </param>
        public BackupRestoreRequest(
            global::G.RestoreConfig? config,
            global::System.Collections.Generic.IList<string>? include,
            global::System.Collections.Generic.IList<string>? exclude,
            global::System.Collections.Generic.Dictionary<string, string>? nodeMapping)
        {
            this.Config = config;
            this.Include = include;
            this.Exclude = exclude;
            this.NodeMapping = nodeMapping;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BackupRestoreRequest" /> class.
        /// </summary>
        public BackupRestoreRequest()
        {
        }
    }
}