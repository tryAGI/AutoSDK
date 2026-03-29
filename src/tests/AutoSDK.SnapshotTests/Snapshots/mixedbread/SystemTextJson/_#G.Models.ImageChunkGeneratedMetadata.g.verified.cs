//HintName: G.Models.ImageChunkGeneratedMetadata.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ImageChunkGeneratedMetadata
    {
        /// <summary>
        /// Default Value: image
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Default Value: image/jpeg
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_type")]
        public string? FileType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_size")]
        public int? FileSize { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("width")]
        public int? Width { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("height")]
        public int? Height { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_extension")]
        public string? FileExtension { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageChunkGeneratedMetadata" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: image
        /// </param>
        /// <param name="fileType">
        /// Default Value: image/jpeg
        /// </param>
        /// <param name="fileSize"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <param name="fileExtension"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImageChunkGeneratedMetadata(
            string? type,
            string? fileType,
            int? fileSize,
            int? width,
            int? height,
            string? fileExtension)
        {
            this.Type = type;
            this.FileType = fileType;
            this.FileSize = fileSize;
            this.Width = width;
            this.Height = height;
            this.FileExtension = fileExtension;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageChunkGeneratedMetadata" /> class.
        /// </summary>
        public ImageChunkGeneratedMetadata()
        {
        }
    }
}