﻿//HintName: G.Models.ChapterSnapshotsResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChapterSnapshotsResponseModel
    {
        /// <summary>
        /// List of chapter snapshots.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("snapshots")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.ChapterSnapshotResponseModel> Snapshots { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChapterSnapshotsResponseModel" /> class.
        /// </summary>
        /// <param name="snapshots">
        /// List of chapter snapshots.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChapterSnapshotsResponseModel(
            global::System.Collections.Generic.IList<global::G.ChapterSnapshotResponseModel> snapshots)
        {
            this.Snapshots = snapshots ?? throw new global::System.ArgumentNullException(nameof(snapshots));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChapterSnapshotsResponseModel" /> class.
        /// </summary>
        public ChapterSnapshotsResponseModel()
        {
        }
    }
}