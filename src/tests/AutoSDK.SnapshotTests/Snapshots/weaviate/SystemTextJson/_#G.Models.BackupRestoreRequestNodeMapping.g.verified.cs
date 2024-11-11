//HintName: G.Models.BackupRestoreRequestNodeMapping.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Allows overriding the node names stored in the backup with different ones. Useful when restoring backups to a different environment.
    /// </summary>
    public sealed partial class BackupRestoreRequestNodeMapping
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BackupRestoreRequestNodeMapping" /> class.
        /// </summary>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public BackupRestoreRequestNodeMapping(
 )
        {
        }
    }
}