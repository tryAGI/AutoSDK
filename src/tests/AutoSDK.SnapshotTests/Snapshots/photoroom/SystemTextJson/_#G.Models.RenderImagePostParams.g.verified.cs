//HintName: G.Models.RenderImagePostParams.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RenderImagePostParams
    {
        /// <summary>
        /// The ID of the template to render<br/>
        /// Example: 592dd982-4a1b-4cd9-ab11-21481d5a0064
        /// </summary>
        /// <example>592dd982-4a1b-4cd9-ab11-21481d5a0064</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("templateId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TemplateId { get; set; }

        /// <summary>
        /// The image file to render
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("imageFile")]
        public byte[]? ImageFile { get; set; }

        /// <summary>
        /// The image file to render
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("imageFilename")]
        public string? ImageFilename { get; set; }

        /// <summary>
        /// Deprecated, use `imageFile` instead.<br/>
        /// Example: https://s3.amazonaws.com/a.storyblok.com/f/191576/1024x1024/d25e1a99d7/sample-05.png
        /// </summary>
        /// <example>https://s3.amazonaws.com/a.storyblok.com/f/191576/1024x1024/d25e1a99d7/sample-05.png</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("imageUrl")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? ImageUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RenderImagePostParams" /> class.
        /// </summary>
        /// <param name="templateId">
        /// The ID of the template to render<br/>
        /// Example: 592dd982-4a1b-4cd9-ab11-21481d5a0064
        /// </param>
        /// <param name="imageFile">
        /// The image file to render
        /// </param>
        /// <param name="imageFilename">
        /// The image file to render
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RenderImagePostParams(
            string templateId,
            byte[]? imageFile,
            string? imageFilename)
        {
            this.TemplateId = templateId ?? throw new global::System.ArgumentNullException(nameof(templateId));
            this.ImageFile = imageFile;
            this.ImageFilename = imageFilename;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RenderImagePostParams" /> class.
        /// </summary>
        public RenderImagePostParams()
        {
        }
    }
}