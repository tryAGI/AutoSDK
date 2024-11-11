//HintName: G.Models.ProjectSnapshotUploadResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProjectSnapshotUploadResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ProjectSnapshotUploadResponseModelStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ProjectSnapshotUploadResponseModelStatus Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("acx_volume_normalization")]
        public bool? AcxVolumeNormalization { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectSnapshotUploadResponseModel" /> class.
        /// </summary>
        /// <param name="status"></param>
        /// <param name="acxVolumeNormalization"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ProjectSnapshotUploadResponseModel(
            global::G.ProjectSnapshotUploadResponseModelStatus status,
            bool? acxVolumeNormalization)
        {
            this.Status = status;
            this.AcxVolumeNormalization = acxVolumeNormalization;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectSnapshotUploadResponseModel" /> class.
        /// </summary>
        public ProjectSnapshotUploadResponseModel()
        {
        }
    }
}