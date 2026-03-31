//HintName: G.Models.UploadImageResponseDto.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UploadImageResponseDto
    {
        /// <summary>
        /// The temporary URL of the image.<br/>
        /// This URL should be provided when creating an animation via the /animations endpoint.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// A unique identifier which represents this image operation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("faces")]
        public global::System.Collections.Generic.IList<global::G.UploadImageResponseDtoFace>? Faces { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadImageResponseDto" /> class.
        /// </summary>
        /// <param name="url">
        /// The temporary URL of the image.<br/>
        /// This URL should be provided when creating an animation via the /animations endpoint.
        /// </param>
        /// <param name="id">
        /// A unique identifier which represents this image operation
        /// </param>
        /// <param name="faces"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UploadImageResponseDto(
            string url,
            string? id,
            global::System.Collections.Generic.IList<global::G.UploadImageResponseDtoFace>? faces)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Id = id;
            this.Faces = faces;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadImageResponseDto" /> class.
        /// </summary>
        public UploadImageResponseDto()
        {
        }
    }
}