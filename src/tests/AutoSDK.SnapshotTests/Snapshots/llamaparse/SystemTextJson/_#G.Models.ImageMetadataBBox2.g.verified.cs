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
        [global::System.Text.Json.Serialization.JsonPropertyName("x")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int X { get; set; }

        /// <summary>
        /// Y coordinate of the bounding box
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("y")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Y { get; set; }

        /// <summary>
        /// Width of the bounding box
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("w")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int W { get; set; }

        /// <summary>
        /// Height of the bounding box
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("h")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int H { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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