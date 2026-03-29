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
        [global::Newtonsoft.Json.JsonProperty("snapshotID", Required = global::Newtonsoft.Json.Required.Always)]
        public string SnapshotID { get; set; } = default!;

        /// <summary>
        /// Full names of the snapshot template including team namespace and tag (e.g. team-slug/my-snapshot:v2)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("names", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> Names { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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