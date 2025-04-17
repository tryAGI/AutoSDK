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
        [global::Newtonsoft.Json.JsonProperty("dimensions", Required = global::Newtonsoft.Json.Required.Always)]
        public object? Dimensions { get; set; } = default!;

        /// <summary>
        /// List of all extracted images in the page
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("images", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.OCRImageObject> Images { get; set; } = default!;

        /// <summary>
        /// The page index in a pdf document starting from 0
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("index", Required = global::Newtonsoft.Json.Required.Always)]
        public int Index { get; set; } = default!;

        /// <summary>
        /// The markdown string response of the page
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("markdown", Required = global::Newtonsoft.Json.Required.Always)]
        public string Markdown { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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