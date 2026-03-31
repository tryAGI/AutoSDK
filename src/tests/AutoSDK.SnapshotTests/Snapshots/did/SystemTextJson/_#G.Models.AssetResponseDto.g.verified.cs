//HintName: G.Models.AssetResponseDto.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Response DTO for agent assets with CDN URL
    /// </summary>
    public sealed partial class AssetResponseDto
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mime_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string MimeType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cdn_url")]
        public string? CdnUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("thumbnail_url")]
        public string? ThumbnailUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AssetResponseDtoStatusJsonConverter))]
        public global::G.AssetResponseDtoStatus? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("moderation_error")]
        public global::G.AssetResponseDtoModerationError? ModerationError { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AssetResponseDto" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="mimeType"></param>
        /// <param name="description"></param>
        /// <param name="cdnUrl"></param>
        /// <param name="name"></param>
        /// <param name="tags"></param>
        /// <param name="thumbnailUrl"></param>
        /// <param name="status"></param>
        /// <param name="moderationError"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AssetResponseDto(
            string id,
            string mimeType,
            string description,
            string? cdnUrl,
            string? name,
            global::System.Collections.Generic.IList<string>? tags,
            string? thumbnailUrl,
            global::G.AssetResponseDtoStatus? status,
            global::G.AssetResponseDtoModerationError? moderationError)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.MimeType = mimeType ?? throw new global::System.ArgumentNullException(nameof(mimeType));
            this.CdnUrl = cdnUrl;
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Name = name;
            this.Tags = tags;
            this.ThumbnailUrl = thumbnailUrl;
            this.Status = status;
            this.ModerationError = moderationError;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AssetResponseDto" /> class.
        /// </summary>
        public AssetResponseDto()
        {
        }
    }
}