//HintName: G.Models.SnapshotInfo.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SnapshotInfo
    {
        /// <summary>
        /// Identifier of the snapshot template including the tag. Uses namespace/alias when a name was provided (e.g. team-slug/my-snapshot:default), otherwise falls back to the raw template ID (e.g. abc123:default).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("snapshotID")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SnapshotID { get; set; }

        /// <summary>
        /// Full names of the snapshot template including team namespace and tag (e.g. team-slug/my-snapshot:v2)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("names")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Names { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SnapshotInfo" /> class.
        /// </summary>
        /// <param name="snapshotID">
        /// Identifier of the snapshot template including the tag. Uses namespace/alias when a name was provided (e.g. team-slug/my-snapshot:default), otherwise falls back to the raw template ID (e.g. abc123:default).
        /// </param>
        /// <param name="names">
        /// Full names of the snapshot template including team namespace and tag (e.g. team-slug/my-snapshot:v2)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SnapshotInfo(
            string snapshotID,
            global::System.Collections.Generic.IList<string> names)
        {
            this.SnapshotID = snapshotID ?? throw new global::System.ArgumentNullException(nameof(snapshotID));
            this.Names = names ?? throw new global::System.ArgumentNullException(nameof(names));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SnapshotInfo" /> class.
        /// </summary>
        public SnapshotInfo()
        {
        }
    }
}