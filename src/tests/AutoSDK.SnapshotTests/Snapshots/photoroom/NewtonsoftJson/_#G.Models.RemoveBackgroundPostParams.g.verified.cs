//HintName: G.Models.RemoveBackgroundPostParams.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RemoveBackgroundPostParams
    {
        /// <summary>
        /// The image file to render
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("image_file", Required = global::Newtonsoft.Json.Required.Always)]
        public byte[] ImageFile { get; set; } = default!;

        /// <summary>
        /// The image file to render
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("image_filename", Required = global::Newtonsoft.Json.Required.Always)]
        public string ImageFilename { get; set; } = default!;

        /// <summary>
        /// The format of the resulting image<br/>
        /// Default Value: png
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("format")]
        public global::G.RemoveBackgroundPostParamsFormat? Format { get; set; }

        /// <summary>
        /// The channels of the resulting image<br/>
        /// Default Value: rgba
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("channels")]
        public global::G.RemoveBackgroundPostParamsChannels? Channels { get; set; }

        /// <summary>
        /// The background color of the resulting image. Can be a hex code (`#FF00FF`) or a HTML color (`red`, `green`, etc.)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("bg_color")]
        public string? BgColor { get; set; }

        /// <summary>
        /// Will resize the output to the specified size. Can be `preview` (0.25 Megapixels), `medium` (1.5 MP), `hd` (4 MP) or `full` (36 MP, can be slower for large images). Useful for mobile apps that need smaller images.<br/>
        /// Default Value: full
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("size")]
        public global::G.RemoveBackgroundPostParamsSize? Size { get; set; }

        /// <summary>
        /// If `true`, the image returned is cropped to the cutout border. Transparent pixels are removed from the border<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("crop")]
        public global::G.RemoveBackgroundPostParamsCrop? Crop { get; set; }

        /// <summary>
        /// If `true`, automatically removes colored reflections that have been left on the main subject by a green background.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("despill")]
        public global::G.RemoveBackgroundPostParamsDespill? Despill { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RemoveBackgroundPostParams" /> class.
        /// </summary>
        /// <param name="imageFile">
        /// The image file to render
        /// </param>
        /// <param name="imageFilename">
        /// The image file to render
        /// </param>
        /// <param name="format">
        /// The format of the resulting image<br/>
        /// Default Value: png
        /// </param>
        /// <param name="channels">
        /// The channels of the resulting image<br/>
        /// Default Value: rgba
        /// </param>
        /// <param name="bgColor">
        /// The background color of the resulting image. Can be a hex code (`#FF00FF`) or a HTML color (`red`, `green`, etc.)
        /// </param>
        /// <param name="size">
        /// Will resize the output to the specified size. Can be `preview` (0.25 Megapixels), `medium` (1.5 MP), `hd` (4 MP) or `full` (36 MP, can be slower for large images). Useful for mobile apps that need smaller images.<br/>
        /// Default Value: full
        /// </param>
        /// <param name="crop">
        /// If `true`, the image returned is cropped to the cutout border. Transparent pixels are removed from the border<br/>
        /// Default Value: false
        /// </param>
        /// <param name="despill">
        /// If `true`, automatically removes colored reflections that have been left on the main subject by a green background.<br/>
        /// Default Value: false
        /// </param>
        public RemoveBackgroundPostParams(
            byte[] imageFile,
            string imageFilename,
            global::G.RemoveBackgroundPostParamsFormat? format,
            global::G.RemoveBackgroundPostParamsChannels? channels,
            string? bgColor,
            global::G.RemoveBackgroundPostParamsSize? size,
            global::G.RemoveBackgroundPostParamsCrop? crop,
            global::G.RemoveBackgroundPostParamsDespill? despill)
        {
            this.ImageFile = imageFile ?? throw new global::System.ArgumentNullException(nameof(imageFile));
            this.ImageFilename = imageFilename ?? throw new global::System.ArgumentNullException(nameof(imageFilename));
            this.Format = format;
            this.Channels = channels;
            this.BgColor = bgColor;
            this.Size = size;
            this.Crop = crop;
            this.Despill = despill;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RemoveBackgroundPostParams" /> class.
        /// </summary>
        public RemoveBackgroundPostParams()
        {
        }
    }
}