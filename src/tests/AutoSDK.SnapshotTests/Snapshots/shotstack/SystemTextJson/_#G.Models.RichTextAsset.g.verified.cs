//HintName: G.Models.RichTextAsset.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The RichTextAsset provides advanced text rendering with support for custom fonts, gradients, shadows, strokes,<br/>
    /// animations, and styling options. It offers more flexibility and visual effects than the basic TextAsset.
    /// </summary>
    public sealed partial class RichTextAsset
    {
        /// <summary>
        /// The type of asset - set to `rich-text` for rich text.<br/>
        /// Default Value: rich-text
        /// </summary>
        /// <default>global::G.RichTextAssetType.RichText</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.RichTextAssetTypeJsonConverter))]
        public global::G.RichTextAssetType Type { get; set; } = global::G.RichTextAssetType.RichText;

        /// <summary>
        /// The text string to display. Maximum 5000 characters.<br/>
        /// Example: Hello World
        /// </summary>
        /// <example>Hello World</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// Font properties for rich text.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("font")]
        public global::G.RichTextFont? Font { get; set; }

        /// <summary>
        /// Text style properties including spacing, line height, and transformations.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("style")]
        public global::G.RichTextStyle? Style { get; set; }

        /// <summary>
        /// Text stroke (outline) properties.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stroke")]
        public global::G.RichTextStroke? Stroke { get; set; }

        /// <summary>
        /// Text shadow properties.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("shadow")]
        public global::G.RichTextShadow? Shadow { get; set; }

        /// <summary>
        /// Background styling properties for the text bounding box.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("background")]
        public global::G.RichTextBackground? Background { get; set; }

        /// <summary>
        /// Border styling properties for the text bounding box.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("border")]
        public global::G.RichTextBorder? Border { get; set; }

        /// <summary>
        /// Padding inside the text bounding box. Can be a single number (applied to all sides) or an object with individual sides.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("padding")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverter<double?, global::G.RichTextPadding>))]
        public global::G.OneOf<double?, global::G.RichTextPadding>? Padding { get; set; }

        /// <summary>
        /// Text alignment properties (horizontal and vertical).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("align")]
        public global::G.RichTextAlignment? Align { get; set; }

        /// <summary>
        /// Animation properties for text entrance effects.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("animation")]
        public global::G.RichTextAnimation? Animation { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RichTextAsset" /> class.
        /// </summary>
        /// <param name="text">
        /// The text string to display. Maximum 5000 characters.<br/>
        /// Example: Hello World
        /// </param>
        /// <param name="font">
        /// Font properties for rich text.
        /// </param>
        /// <param name="style">
        /// Text style properties including spacing, line height, and transformations.
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
        /// Padding inside the text bounding box. Can be a single number (applied to all sides) or an object with individual sides.
        /// </param>
        /// <param name="align">
        /// Text alignment properties (horizontal and vertical).
        /// </param>
        /// <param name="animation">
        /// Animation properties for text entrance effects.
        /// </param>
        /// <param name="type">
        /// The type of asset - set to `rich-text` for rich text.<br/>
        /// Default Value: rich-text
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RichTextAsset(
            string text,
            global::G.RichTextFont? font,
            global::G.RichTextStyle? style,
            global::G.RichTextStroke? stroke,
            global::G.RichTextShadow? shadow,
            global::G.RichTextBackground? background,
            global::G.RichTextBorder? border,
            global::G.OneOf<double?, global::G.RichTextPadding>? padding,
            global::G.RichTextAlignment? align,
            global::G.RichTextAnimation? animation,
            global::G.RichTextAssetType type = global::G.RichTextAssetType.RichText)
        {
            this.Type = type;
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Font = font;
            this.Style = style;
            this.Stroke = stroke;
            this.Shadow = shadow;
            this.Background = background;
            this.Border = border;
            this.Padding = padding;
            this.Align = align;
            this.Animation = animation;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RichTextAsset" /> class.
        /// </summary>
        public RichTextAsset()
        {
        }
    }
}