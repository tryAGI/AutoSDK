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
        [global::System.Text.Json.Serialization.JsonPropertyName("image_file")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required byte[] ImageFile { get; set; }

        /// <summary>
        /// The image file to render
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_filename")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ImageFilename { get; set; }

        /// <summary>
        /// The format of the resulting image<br/>
        /// Default Value: png
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.RemoveBackgroundPostParamsFormatJsonConverter))]
        public global::G.RemoveBackgroundPostParamsFormat? Format { get; set; }

        /// <summary>
        /// The channels of the resulting image<br/>
        /// Default Value: rgba
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("channels")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.RemoveBackgroundPostParamsChannelsJsonConverter))]
        public global::G.RemoveBackgroundPostParamsChannels? Channels { get; set; }

        /// <summary>
        /// The background color of the resulting image. Can be a hex code (`#FF00FF`) or a HTML color (`red`, `green`, etc.)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bg_color")]
        public string? BgColor { get; set; }

        /// <summary>
        /// Will resize the output to the specified size. Can be `preview` (0.25 Megapixels), `medium` (1.5 MP), `hd` (4 MP) or `full` (36 MP, can be slower for large images). Useful for mobile apps that need smaller images.<br/>
        /// Default Value: full
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("size")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.RemoveBackgroundPostParamsSizeJsonConverter))]
        public global::G.RemoveBackgroundPostParamsSize? Size { get; set; }

        /// <summary>
        /// If `true`, the image returned is cropped to the cutout border. Transparent pixels are removed from the border<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("crop")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.RemoveBackgroundPostParamsCropJsonConverter))]
        public global::G.RemoveBackgroundPostParamsCrop? Crop { get; set; }

        /// <summary>
        /// If `true`, automatically removes colored reflections that have been left on the main subject by a green background.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("despill")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.RemoveBackgroundPostParamsDespillJsonConverter))]
        public global::G.RemoveBackgroundPostParamsDespill? Despill { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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