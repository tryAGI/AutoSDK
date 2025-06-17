//HintName: G.Models.Image.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Image
    {
        /// <summary>
        /// Bit depth of the image
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("bit_depth", Required = global::Newtonsoft.Json.Required.Always)]
        public double BitDepth { get; set; } = default!;

        /// <summary>
        /// Format of the image
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("format", Required = global::Newtonsoft.Json.Required.Always)]
        public string Format { get; set; } = default!;

        /// <summary>
        /// Height of the image in pixels
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("height", Required = global::Newtonsoft.Json.Required.Always)]
        public double Height { get; set; } = default!;

        /// <summary>
        /// Width of the image in pixels
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("width", Required = global::Newtonsoft.Json.Required.Always)]
        public double Width { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Image" /> class.
        /// </summary>
        /// <param name="bitDepth">
        /// Bit depth of the image
        /// </param>
        /// <param name="format">
        /// Format of the image
        /// </param>
        /// <param name="height">
        /// Height of the image in pixels
        /// </param>
        /// <param name="width">
        /// Width of the image in pixels
        /// </param>
        public Image(
            double bitDepth,
            string format,
            double height,
            double width)
        {
            this.BitDepth = bitDepth;
            this.Format = format ?? throw new global::System.ArgumentNullException(nameof(format));
            this.Height = height;
            this.Width = width;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Image" /> class.
        /// </summary>
        public Image()
        {
        }
    }
}