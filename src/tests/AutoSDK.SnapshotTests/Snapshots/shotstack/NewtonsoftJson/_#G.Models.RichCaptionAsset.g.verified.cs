//HintName: G.Models.RichCaptionAsset.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The RichCaptionAsset provides word-level caption animations with rich-text styling. It supports<br/>
    /// karaoke-style highlighting, word-by-word animations, and advanced typography. Use with SRT/VTT<br/>
    /// files or auto-transcription via aliases.
    /// </summary>
    public sealed partial class RichCaptionAsset
    {
        /// <summary>
        /// The type of asset - set to `rich-caption` for rich captions.<br/>
        /// Default Value: rich-caption
        /// </summary>
        /// <default>global::G.RichCaptionAssetType.RichCaption</default>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.RichCaptionAssetType Type { get; set; } = global::G.RichCaptionAssetType.RichCaption;

        /// <summary>
        /// The URL to an SRT or VTT subtitles file, or an alias reference to auto-generate captions from an audio or video clip. For file URLs, the URL must be publicly accessible or include credentials. For auto-captioning, use the format `alias://clip-name` where clip-name is the alias of an audio, video, or text-to-speech clip.<br/>
        /// Example: alias://audio
        /// </summary>
        /// <example>alias://audio</example>
        [global::Newtonsoft.Json.JsonProperty("src", Required = global::Newtonsoft.Json.Required.Always)]
        public string Src { get; set; } = default!;

        /// <summary>
        /// Font properties for rich captions. Defaults to Roboto.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("font")]
        public global::G.RichCaptionFont? Font { get; set; }

        /// <summary>
        /// Text style properties for rich captions. Same as RichTextStyle but without wordSpacing.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("style")]
        public global::G.RichCaptionStyle? Style { get; set; }

        /// <summary>
        /// Text stroke (outline) properties.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("stroke")]
        public global::G.RichTextStroke? Stroke { get; set; }

        /// <summary>
        /// Text shadow properties.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("shadow")]
        public global::G.RichTextShadow? Shadow { get; set; }

        /// <summary>
        /// Background styling properties for the text bounding box.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("background")]
        public global::G.RichTextBackground? Background { get; set; }

        /// <summary>
        /// Border styling properties for the text bounding box.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("border")]
        public global::G.RichTextBorder? Border { get; set; }

        /// <summary>
        /// Padding inside the caption bounding box. Can be a single number (applied to all sides) or an object with individual sides.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("padding")]
        public global::G.OneOf<double?, global::G.RichTextPadding>? Padding { get; set; }

        /// <summary>
        /// Text alignment properties (horizontal and vertical).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("align")]
        public global::G.RichTextAlignment? Align { get; set; }

        /// <summary>
        /// Styling properties for the active/highlighted word.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("active")]
        public global::G.RichCaptionActive? Active { get; set; }

        /// <summary>
        /// Word-level animation properties for caption effects.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("animation")]
        public global::G.RichCaptionAnimation? Animation { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RichCaptionAsset" /> class.
        /// </summary>
        /// <param name="src">
        /// The URL to an SRT or VTT subtitles file, or an alias reference to auto-generate captions from an audio or video clip. For file URLs, the URL must be publicly accessible or include credentials. For auto-captioning, use the format `alias://clip-name` where clip-name is the alias of an audio, video, or text-to-speech clip.<br/>
        /// Example: alias://audio
        /// </param>
        /// <param name="font">
        /// Font properties for rich captions. Defaults to Roboto.
        /// </param>
        /// <param name="style">
        /// Text style properties for rich captions. Same as RichTextStyle but without wordSpacing.
        /// </param>
        /// <param name="stroke">
        /// Text stroke (outline) properties.
        /// </param>
        /// <param name="shadow">
        /// Text shadow properties.
        /// </param>
        /// <param name="background">
        /// Background styling properties for the text bounding box.
        /// </param>
        /// <param name="border">
        /// Border styling properties for the text bounding box.
        /// </param>
        /// <param name="padding">
        /// Padding inside the caption bounding box. Can be a single number (applied to all sides) or an object with individual sides.
        /// </param>
        /// <param name="align">
        /// Text alignment properties (horizontal and vertical).
        /// </param>
        /// <param name="active">
        /// Styling properties for the active/highlighted word.
        /// </param>
        /// <param name="animation">
        /// Word-level animation properties for caption effects.
        /// </param>
        /// <param name="type">
        /// The type of asset - set to `rich-caption` for rich captions.<br/>
        /// Default Value: rich-caption
        /// </param>
        public RichCaptionAsset(
            string src,
            global::G.RichCaptionFont? font,
            global::G.RichCaptionStyle? style,
            global::G.RichTextStroke? stroke,
            global::G.RichTextShadow? shadow,
            global::G.RichTextBackground? background,
            global::G.RichTextBorder? border,
            global::G.OneOf<double?, global::G.RichTextPadding>? padding,
            global::G.RichTextAlignment? align,
            global::G.RichCaptionActive? active,
            global::G.RichCaptionAnimation? animation,
            global::G.RichCaptionAssetType type = global::G.RichCaptionAssetType.RichCaption)
        {
            this.Type = type;
            this.Src = src ?? throw new global::System.ArgumentNullException(nameof(src));
            this.Font = font;
            this.Style = style;
            this.Stroke = stroke;
            this.Shadow = shadow;
            this.Background = background;
            this.Border = border;
            this.Padding = padding;
            this.Align = align;
            this.Active = active;
            this.Animation = animation;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RichCaptionAsset" /> class.
        /// </summary>
        public RichCaptionAsset()
        {
        }
    }
}