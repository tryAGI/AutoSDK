//HintName: G.Models.OCRPageObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OCRPageObject
    {
        /// <summary>
        /// The dimensions of the PDF Page's screenshot image
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dimensions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object? Dimensions { get; set; }

        /// <summary>
        /// List of all extracted images in the page
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("images")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.OCRImageObject> Images { get; set; }

        /// <summary>
        /// The page index in a pdf document starting from 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Index { get; set; }

        /// <summary>
        /// The markdown string response of the page
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("markdown")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Markdown { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OCRPageObject" /> class.
        /// </summary>
        /// <param name="dimensions">
        /// The dimensions of the PDF Page's screenshot image
        /// </param>
        /// <param name="images">
        /// List of all extracted images in the page
        /// </param>
        /// <param name="index">
        /// The page index in a pdf document starting from 0
        /// </param>
        /// <param name="markdown">
        /// The markdown string response of the page
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OCRPageObject(
            object? dimensions,
            global::System.Collections.Generic.IList<global::G.OCRImageObject> images,
            int index,
            string markdown)
        {
            this.Dimensions = dimensions ?? throw new global::System.ArgumentNullException(nameof(dimensions));
            this.Images = images ?? throw new global::System.ArgumentNullException(nameof(images));
            this.Index = index;
            this.Markdown = markdown ?? throw new global::System.ArgumentNullException(nameof(markdown));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OCRPageObject" /> class.
        /// </summary>
        public OCRPageObject()
        {
        }
    }
}