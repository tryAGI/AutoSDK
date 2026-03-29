//HintName: G.Models.EditImageGetVirtualModelModelVariant2Custom.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Use a custom model image.
    /// </summary>
    public sealed partial class EditImageGetVirtualModelModelVariant2Custom
    {
        /// <summary>
        /// Bytes of a custom model image. Only available in the POST request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("imageFile")]
        public byte[]? ImageFile { get; set; }

        /// <summary>
        /// Bytes of a custom model image. Only available in the POST request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("imageFilename")]
        public string? ImageFilename { get; set; }

        /// <summary>
        /// URL of a custom model image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("imageUrl")]
        public string? ImageUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EditImageGetVirtualModelModelVariant2Custom" /> class.
        /// </summary>
        /// <param name="imageFile">
        /// Bytes of a custom model image. Only available in the POST request.
        /// </param>
        /// <param name="imageFilename">
        /// Bytes of a custom model image. Only available in the POST request.
        /// </param>
        /// <param name="imageUrl">
        /// URL of a custom model image.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EditImageGetVirtualModelModelVariant2Custom(
            byte[]? imageFile,
            string? imageFilename,
            string? imageUrl)
        {
            this.ImageFile = imageFile;
            this.ImageFilename = imageFilename;
            this.ImageUrl = imageUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EditImageGetVirtualModelModelVariant2Custom" /> class.
        /// </summary>
        public EditImageGetVirtualModelModelVariant2Custom()
        {
        }
    }
}