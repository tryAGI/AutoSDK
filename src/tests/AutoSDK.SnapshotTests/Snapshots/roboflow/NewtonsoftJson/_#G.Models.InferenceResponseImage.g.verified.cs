//HintName: G.Models.InferenceResponseImage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Inference response image information.<br/>
    /// Attributes:<br/>
    ///     width (int): The original width of the image used in inference.<br/>
    ///     height (int): The original height of the image used in inference.
    /// </summary>
    public sealed partial class InferenceResponseImage
    {
        /// <summary>
        /// The original width of the image used in inference
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("width", Required = global::Newtonsoft.Json.Required.Always)]
        public int Width { get; set; } = default!;

        /// <summary>
        /// The original height of the image used in inference
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("height", Required = global::Newtonsoft.Json.Required.Always)]
        public int Height { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InferenceResponseImage" /> class.
        /// </summary>
        /// <param name="width">
        /// The original width of the image used in inference
        /// </param>
        /// <param name="height">
        /// The original height of the image used in inference
        /// </param>
        public InferenceResponseImage(
            int width,
            int height)
        {
            this.Width = width;
            this.Height = height;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InferenceResponseImage" /> class.
        /// </summary>
        public InferenceResponseImage()
        {
        }
    }
}