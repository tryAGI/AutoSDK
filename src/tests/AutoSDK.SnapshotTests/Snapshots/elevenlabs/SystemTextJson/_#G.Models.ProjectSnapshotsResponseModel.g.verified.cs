//HintName: G.Models.ProjectSnapshotsResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProjectSnapshotsResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("snapshots")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.ProjectSnapshotResponseModel> Snapshots { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectSnapshotsResponseModel" /> class.
        /// </summary>
        /// <param name="snapshots"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ProjectSnapshotsResponseModel(
            global::System.Collections.Generic.IList<global::G.ProjectSnapshotResponseModel> snapshots)
        {
            this.Snapshots = snapshots ?? throw new global::System.ArgumentNullException(nameof(snapshots));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectSnapshotsResponseModel" /> class.
        /// </summary>
        public ProjectSnapshotsResponseModel()
        {
        }
    }
}