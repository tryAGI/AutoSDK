//HintName: G.Models.OCRPageDimensions.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OCRPageDimensions
    {
        /// <summary>
        /// Dots per inch of the page-image
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dpi", Required = global::Newtonsoft.Json.Required.Always)]
        public int Dpi { get; set; } = default!;

        /// <summary>
        /// Height of the image in pixels
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("height", Required = global::Newtonsoft.Json.Required.Always)]
        public int Height { get; set; } = default!;

        /// <summary>
        /// Width of the image in pixels
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("width", Required = global::Newtonsoft.Json.Required.Always)]
        public int Width { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OCRPageDimensions" /> class.
        /// </summary>
        /// <param name="dpi">
        /// Dots per inch of the page-image
        /// </param>
        /// <param name="height">
        /// Height of the image in pixels
        /// </param>
        /// <param name="width">
        /// Width of the image in pixels
        /// </param>
        public OCRPageDimensions(
            int dpi,
            int height,
            int width)
        {
            this.Dpi = dpi;
            this.Height = height;
            this.Width = width;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OCRPageDimensions" /> class.
        /// </summary>
        public OCRPageDimensions()
        {
        }
    }
}