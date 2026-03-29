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
        [global::System.Text.Json.Serialization.JsonPropertyName("uploadUrl")]
        public string? UploadUrl { get; set; }

        /// <summary>
        /// The unique langfuse identifier of a media record
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mediaId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string MediaId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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