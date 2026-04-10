//HintName: G.Models.GetDubbingProjectVideosResponseInProgress.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Response when dubbing project is in progress.
    /// </summary>
    public sealed partial class GetDubbingProjectVideosResponseInProgress
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid Id { get; set; } = default!;

        /// <summary>
        /// The status of the dubbed video.<br/>
        /// Default Value: in_progress
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.GetDubbingProjectVideosResponseInProgressStatusJsonConverter))]
        public global::G.GetDubbingProjectVideosResponseInProgressStatus? Status { get; set; }

        /// <summary>
        /// The dubbed videos in the project.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dubbedAssets")]
        public global::System.Collections.Generic.IList<global::G.AnyOf<global::G.DubbedAssetInProgress, global::G.DubbedAssetComplete, global::G.DubbedAssetError>>? DubbedAssets { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDubbingProjectVideosResponseInProgress" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="status">
        /// The status of the dubbed video.<br/>
        /// Default Value: in_progress
        /// </param>
        /// <param name="dubbedAssets">
        /// The dubbed videos in the project.
        /// </param>
        public GetDubbingProjectVideosResponseInProgress(
            global::System.Guid id,
            global::G.GetDubbingProjectVideosResponseInProgressStatus? status,
            global::System.Collections.Generic.IList<global::G.AnyOf<global::G.DubbedAssetInProgress, global::G.DubbedAssetComplete, global::G.DubbedAssetError>>? dubbedAssets)
        {
            this.Id = id;
            this.Status = status;
            this.DubbedAssets = dubbedAssets;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDubbingProjectVideosResponseInProgress" /> class.
        /// </summary>
        public GetDubbingProjectVideosResponseInProgress()
        {
        }
    }
}