//HintName: G.Models.ImageDimension.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ImageDimension
    {
        /// <summary>
        /// Width must be a positive integer
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("width", Required = global::Newtonsoft.Json.Required.Always)]
        public int Width { get; set; } = default!;

        /// <summary>
        /// Height must be a positive integer
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("height", Required = global::Newtonsoft.Json.Required.Always)]
        public int Height { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageDimension" /> class.
        /// </summary>
        /// <param name="width">
        /// Width must be a positive integer
        /// </param>
        /// <param name="height">
        /// Height must be a positive integer
        /// </param>
        public ImageDimension(
            int width,
            int height)
        {
            this.Width = width;
            this.Height = height;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageDimension" /> class.
        /// </summary>
        public ImageDimension()
        {
        }
    }
}