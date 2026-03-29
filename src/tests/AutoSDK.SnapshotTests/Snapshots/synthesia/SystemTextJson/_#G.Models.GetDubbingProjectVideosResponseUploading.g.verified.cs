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
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// The status of the dubbed video.<br/>
        /// Default Value: uploading
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.GetDubbingProjectVideosResponseUploadingStatusJsonConverter))]
        public global::G.GetDubbingProjectVideosResponseUploadingStatus? Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDubbingProjectVideosResponseUploading" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="status">
        /// The status of the dubbed video.<br/>
        /// Default Value: uploading
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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