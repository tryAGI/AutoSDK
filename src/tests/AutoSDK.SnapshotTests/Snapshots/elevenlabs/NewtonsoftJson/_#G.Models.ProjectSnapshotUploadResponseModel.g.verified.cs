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
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ProjectSnapshotUploadResponseModelStatus Status { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("acx_volume_normalization")]
        public bool? AcxVolumeNormalization { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectSnapshotUploadResponseModel" /> class.
        /// </summary>
        /// <param name="status"></param>
        /// <param name="acxVolumeNormalization"></param>
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