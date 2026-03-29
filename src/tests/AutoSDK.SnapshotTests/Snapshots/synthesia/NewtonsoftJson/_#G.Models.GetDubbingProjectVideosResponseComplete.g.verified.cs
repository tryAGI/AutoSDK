//HintName: G.Models.GetDubbingProjectVideosResponseComplete.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Response when dubbing project is complete.
    /// </summary>
    public sealed partial class GetDubbingProjectVideosResponseComplete
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid Id { get; set; } = default!;

        /// <summary>
        /// The status of the dubbed video.<br/>
        /// Default Value: complete
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status")]
        public global::G.GetDubbingProjectVideosResponseCompleteStatus? Status { get; set; }

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
        /// Initializes a new instance of the <see cref="GetDubbingProjectVideosResponseComplete" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="status">
        /// The status of the dubbed video.<br/>
        /// Default Value: complete
        /// </param>
        /// <param name="dubbedAssets">
        /// The dubbed videos in the project.
        /// </param>
        public GetDubbingProjectVideosResponseComplete(
            global::System.Guid id,
            global::G.GetDubbingProjectVideosResponseCompleteStatus? status,
            global::System.Collections.Generic.IList<global::G.AnyOf<global::G.DubbedAssetInProgress, global::G.DubbedAssetComplete, global::G.DubbedAssetError>>? dubbedAssets)
        {
            this.Id = id;
            this.Status = status;
            this.DubbedAssets = dubbedAssets;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDubbingProjectVideosResponseComplete" /> class.
        /// </summary>
        public GetDubbingProjectVideosResponseComplete()
        {
        }
    }
}