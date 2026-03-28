//HintName: G.Models.Image.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An image element within a document, containing its identifying information, optional metadata, and the actual image data.
    /// </summary>
    public sealed partial class Image
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
        /// An object containing an image's binary data and format information. The image data is provided as a Base64-encoded string along with its MIME type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ImageData ImageData { get; set; }

        /// <summary>
        /// A longer, detailed description of the image for accessibility or additional context.<br/>
        /// Example: A bar chart showing quarterly sales growth, with Q4 outperforming all previous quarters by 15%
        /// </summary>
        /// <example>A bar chart showing quarterly sales growth, with Q4 outperforming all previous quarters by 15%</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Image" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique identifier of the image within the document, used to reference it in related content.<br/>
        /// Example: chart_1
        /// </param>
        /// <param name="imageData">
        /// An object containing an image's binary data and format information. The image data is provided as a Base64-encoded string along with its MIME type.
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
        public Image(
            string id,
            global::G.ImageData imageData,
            string? title,
            string? caption,
            string? description)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Title = title;
            this.Caption = caption;
            this.ImageData = imageData ?? throw new global::System.ArgumentNullException(nameof(imageData));
            this.Description = description;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Image" /> class.
        /// </summary>
        public Image()
        {
        }
    }
}