//HintName: G.Models.UpscaleImageRequestBody.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpscaleImageRequestBody
    {
        /// <summary>
        /// Example: &lt;image binary&gt;
        /// </summary>
        /// <example>&lt;image binary&gt;</example>
        [global::Newtonsoft.Json.JsonProperty("image", Required = global::Newtonsoft.Json.Required.Always)]
        public byte[] Image { get; set; } = default!;

        /// <summary>
        /// Example: &lt;image binary&gt;
        /// </summary>
        /// <example>&lt;image binary&gt;</example>
        [global::Newtonsoft.Json.JsonProperty("imagename", Required = global::Newtonsoft.Json.Required.Always)]
        public string Imagename { get; set; } = default!;

        /// <summary>
        /// Desired width of the output image.  Only one of `width` or `height` may be specified.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("width")]
        public int? Width { get; set; }

        /// <summary>
        /// Desired height of the output image.  Only one of `width` or `height` may be specified.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("height")]
        public int? Height { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpscaleImageRequestBody" /> class.
        /// </summary>
        /// <param name="image">
        /// Example: &lt;image binary&gt;
        /// </param>
        /// <param name="imagename">
        /// Example: &lt;image binary&gt;
        /// </param>
        /// <param name="width">
        /// Desired width of the output image.  Only one of `width` or `height` may be specified.
        /// </param>
        /// <param name="height">
        /// Desired height of the output image.  Only one of `width` or `height` may be specified.
        /// </param>
        public UpscaleImageRequestBody(
            byte[] image,
            string imagename,
            int? width,
            int? height)
        {
            this.Image = image ?? throw new global::System.ArgumentNullException(nameof(image));
            this.Imagename = imagename ?? throw new global::System.ArgumentNullException(nameof(imagename));
            this.Width = width;
            this.Height = height;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpscaleImageRequestBody" /> class.
        /// </summary>
        public UpscaleImageRequestBody()
        {
        }
    }
}