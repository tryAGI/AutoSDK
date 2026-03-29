//HintName: G.Models.GetMediaUploadUrlResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetMediaUploadUrlResponse
    {
        /// <summary>
        /// The presigned upload URL. If the asset is already uploaded, this will be null
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("uploadUrl")]
        public string? UploadUrl { get; set; }

        /// <summary>
        /// The unique langfuse identifier of a media record
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("mediaId", Required = global::Newtonsoft.Json.Required.Always)]
        public string MediaId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetMediaUploadUrlResponse" /> class.
        /// </summary>
        /// <param name="mediaId">
        /// The unique langfuse identifier of a media record
        /// </param>
        /// <param name="uploadUrl">
        /// The presigned upload URL. If the asset is already uploaded, this will be null
        /// </param>
        public GetMediaUploadUrlResponse(
            string mediaId,
            string? uploadUrl)
        {
            this.UploadUrl = uploadUrl;
            this.MediaId = mediaId ?? throw new global::System.ArgumentNullException(nameof(mediaId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetMediaUploadUrlResponse" /> class.
        /// </summary>
        public GetMediaUploadUrlResponse()
        {
        }
    }
}