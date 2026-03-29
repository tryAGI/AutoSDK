//HintName: G.Models.RecoverFromUploadedSnapshotRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RecoverFromUploadedSnapshotRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("snapshot")]
        public byte[]? Snapshot { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("snapshotname")]
        public string? Snapshotname { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RecoverFromUploadedSnapshotRequest" /> class.
        /// </summary>
        /// <param name="snapshot"></param>
        /// <param name="snapshotname"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RecoverFromUploadedSnapshotRequest(
            byte[]? snapshot,
            string? snapshotname)
        {
            this.Snapshot = snapshot;
            this.Snapshotname = snapshotname;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RecoverFromUploadedSnapshotRequest" /> class.
        /// </summary>
        public RecoverFromUploadedSnapshotRequest()
        {
        }
    }
}