//HintName: G.Models.ImageMetadataBBox2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Bounding box for an image on its page.
    /// </summary>
    public sealed partial class ImageMetadataBBox2
    {
        /// <summary>
        /// X coordinate of the bounding box
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("x", Required = global::Newtonsoft.Json.Required.Always)]
        public int X { get; set; } = default!;

        /// <summary>
        /// Y coordinate of the bounding box
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("y", Required = global::Newtonsoft.Json.Required.Always)]
        public int Y { get; set; } = default!;

        /// <summary>
        /// Width of the bounding box
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("w", Required = global::Newtonsoft.Json.Required.Always)]
        public int W { get; set; } = default!;

        /// <summary>
        /// Height of the bounding box
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("h", Required = global::Newtonsoft.Json.Required.Always)]
        public int H { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageMetadataBBox2" /> class.
        /// </summary>
        /// <param name="x">
        /// X coordinate of the bounding box
        /// </param>
        /// <param name="y">
        /// Y coordinate of the bounding box
        /// </param>
        /// <param name="w">
        /// Width of the bounding box
        /// </param>
        /// <param name="h">
        /// Height of the bounding box
        /// </param>
        public ImageMetadataBBox2(
            int x,
            int y,
            int w,
            int h)
        {
            this.X = x;
            this.Y = y;
            this.W = w;
            this.H = h;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageMetadataBBox2" /> class.
        /// </summary>
        public ImageMetadataBBox2()
        {
        }
    }
}