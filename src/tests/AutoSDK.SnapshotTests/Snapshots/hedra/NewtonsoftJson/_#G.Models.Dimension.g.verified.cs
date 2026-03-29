//HintName: G.Models.Dimension.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Dimension
    {
        /// <summary>
        /// Width of the image.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("width", Required = global::Newtonsoft.Json.Required.Always)]
        public int Width { get; set; } = default!;

        /// <summary>
        /// Height of the image.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("height", Required = global::Newtonsoft.Json.Required.Always)]
        public int Height { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Dimension" /> class.
        /// </summary>
        /// <param name="width">
        /// Width of the image.
        /// </param>
        /// <param name="height">
        /// Height of the image.
        /// </param>
        public Dimension(
            int width,
            int height)
        {
            this.Width = width;
            this.Height = height;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Dimension" /> class.
        /// </summary>
        public Dimension()
        {
        }
    }
}