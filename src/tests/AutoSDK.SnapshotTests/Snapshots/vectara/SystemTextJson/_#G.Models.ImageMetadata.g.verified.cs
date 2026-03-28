//HintName: G.Models.ImageMetadata.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An image element within a document, containing its identifying information and optional metadata.
    /// </summary>
    public sealed partial class ImageMetadata
    {
        /// <summary>
        /// The unique identifier of the image within the document, used to reference it in related content.<br/>
        /// Example: chart_1
        /// </summary>
        /// <example>chart_1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// A short, human-readable title for the image, often displayed above or alongside it.<br/>
        /// Example: Quarterly Sales Performance
        /// </summary>
        /// <example>Quarterly Sales Performance</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// A brief caption providing context or an explanation for the image, typically displayed below it.<br/>
        /// Example: Sales growth trends for Q1 to Q4 of 2024
        /// </summary>
        /// <example>Sales growth trends for Q1 to Q4 of 2024</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("caption")]
        public string? Caption { get; set; }

        /// <summary>
        /// A longer, detailed description of the image for accessibility or additional context.<br/>
        /// Example: A bar chart showing quarterly sales growth, with Q4 outperforming all previous quarters by 15%
        /// </summary>
        /// <example>A bar chart showing quarterly sales growth, with Q4 outperforming all previous quarters by 15%</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The MIME type of the image, indicating the format of the binary data (e.g., image/jpeg for JPEG images).<br/>
        /// Example: image/jpeg
        /// </summary>
        /// <example>image/jpeg</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("mime_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string MimeType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageMetadata" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique identifier of the image within the document, used to reference it in related content.<br/>
        /// Example: chart_1
        /// </param>
        /// <param name="mimeType">
        /// The MIME type of the image, indicating the format of the binary data (e.g., image/jpeg for JPEG images).<br/>
        /// Example: image/jpeg
        /// </param>
        /// <param name="title">
        /// A short, human-readable title for the image, often displayed above or alongside it.<br/>
        /// Example: Quarterly Sales Performance
        /// </param>
        /// <param name="caption">
        /// A brief caption providing context or an explanation for the image, typically displayed below it.<br/>
        /// Example: Sales growth trends for Q1 to Q4 of 2024
        /// </param>
        /// <param name="description">
        /// A longer, detailed description of the image for accessibility or additional context.<br/>
        /// Example: A bar chart showing quarterly sales growth, with Q4 outperforming all previous quarters by 15%
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImageMetadata(
            string id,
            string mimeType,
            string? title,
            string? caption,
            string? description)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Title = title;
            this.Caption = caption;
            this.Description = description;
            this.MimeType = mimeType ?? throw new global::System.ArgumentNullException(nameof(mimeType));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageMetadata" /> class.
        /// </summary>
        public ImageMetadata()
        {
        }
    }
}