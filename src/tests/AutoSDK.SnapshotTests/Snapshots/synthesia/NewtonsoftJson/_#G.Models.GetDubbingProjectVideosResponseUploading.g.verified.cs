//HintName: G.Models.GetDubbingProjectVideosResponseUploading.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Response when dubbing project is still uploading from sourceVideoUrl.
    /// </summary>
    public sealed partial class GetDubbingProjectVideosResponseUploading
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid Id { get; set; } = default!;

        /// <summary>
        /// The status of the dubbed video.<br/>
        /// Default Value: uploading
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.GetDubbingProjectVideosResponseUploadingStatusJsonConverter))]
        public global::G.GetDubbingProjectVideosResponseUploadingStatus? Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDubbingProjectVideosResponseUploading" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="status">
        /// The status of the dubbed video.<br/>
        /// Default Value: uploading
        /// </param>
        public GetDubbingProjectVideosResponseUploading(
            global::System.Guid id,
            global::G.GetDubbingProjectVideosResponseUploadingStatus? status)
        {
            this.Id = id;
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDubbingProjectVideosResponseUploading" /> class.
        /// </summary>
        public GetDubbingProjectVideosResponseUploading()
        {
        }
    }
}