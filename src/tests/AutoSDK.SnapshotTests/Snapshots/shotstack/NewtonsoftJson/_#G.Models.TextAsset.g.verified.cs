//HintName: G.Models.TextAsset.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The TextAsset is used to add text and titles to a video. The text can be styled with built in and custom<br/>
    /// [Fonts](#tocs_font). You can also add a background bounding box used to control wrapping and overflow. Emoticons are also supported.
    /// </summary>
    public sealed partial class TextAsset
    {
        /// <summary>
        /// The type of asset - set to `text` for text.<br/>
        /// Default Value: text
        /// </summary>
        /// <default>global::G.TextAssetType.Text</default>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.TextAssetType Type { get; set; } = global::G.TextAssetType.Text;

        /// <summary>
        /// The text string to display.<br/>
        /// Example: Hello World
        /// </summary>
        /// <example>Hello World</example>
        [global::Newtonsoft.Json.JsonProperty("text", Required = global::Newtonsoft.Json.Required.Always)]
        public string Text { get; set; } = default!;

        /// <summary>
        /// Set the width of the HTML asset bounding box in pixels. Text will wrap to fill the bounding box.<br/>
        /// Example: 400
        /// </summary>
        /// <example>400</example>
        [global::Newtonsoft.Json.JsonProperty("width")]
        public int? Width { get; set; }

        /// <summary>
        /// Set the width of the HTML asset bounding box in pixels. Text and elements will be masked if they exceed the  height of the bounding box.<br/>
        /// Example: 200
        /// </summary>
        /// <example>200</example>
        [global::Newtonsoft.Json.JsonProperty("height")]
        public int? Height { get; set; }

        /// <summary>
        /// Font properties for text.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("font")]
        public global::G.TextFont? Font { get; set; }

        /// <summary>
        /// Displays a background box behind the text.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("background")]
        public global::G.TextBackground? Background { get; set; }

        /// <summary>
        /// Horizontal and vertical alignment properties for text.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("alignment")]
        public global::G.TextAlignment? Alignment { get; set; }

        /// <summary>
        /// Text stroke (outline) properties.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("stroke")]
        public global::G.TextStroke? Stroke { get; set; }

        /// <summary>
        /// Animation properties for text entrance effects.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("animation")]
        public global::G.TextAnimation? Animation { get; set; }

        /// <summary>
        /// The string to display when text overflows its bounding box. Set to an ellipsis character or custom string to indicate truncated text.<br/>
        /// Example: ...
        /// </summary>
        /// <example>...</example>
        [global::Newtonsoft.Json.JsonProperty("ellipsis")]
        public string? Ellipsis { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TextAsset" /> class.
        /// </summary>
        /// <param name="text">
        /// The text string to display.<br/>
        /// Example: Hello World
        /// </param>
        /// <param name="width">
        /// Set the width of the HTML asset bounding box in pixels. Text will wrap to fill the bounding box.<br/>
        /// Example: 400
        /// </param>
        /// <param name="height">
        /// Set the width of the HTML asset bounding box in pixels. Text and elements will be masked if they exceed the  height of the bounding box.<br/>
        /// Example: 200
        /// </param>
        /// <param name="font">
        /// Font properties for text.
        /// </param>
        /// <param name="background">
        /// Displays a background box behind the text.
        /// </param>
        /// <param name="alignment">
        /// Horizontal and vertical alignment properties for text.
        /// </param>
        /// <param name="stroke">
        /// Text stroke (outline) properties.
        /// </param>
        /// <param name="animation">
        /// Animation properties for text entrance effects.
        /// </param>
        /// <param name="ellipsis">
        /// The string to display when text overflows its bounding box. Set to an ellipsis character or custom string to indicate truncated text.<br/>
        /// Example: ...
        /// </param>
        /// <param name="type">
        /// The type of asset - set to `text` for text.<br/>
        /// Default Value: text
        /// </param>
        public TextAsset(
            string text,
            int? width,
            int? height,
            global::G.TextFont? font,
            global::G.TextBackground? background,
            global::G.TextAlignment? alignment,
            global::G.TextStroke? stroke,
            global::G.TextAnimation? animation,
            string? ellipsis,
            global::G.TextAssetType type = global::G.TextAssetType.Text)
        {
            this.Type = type;
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Width = width;
            this.Height = height;
            this.Font = font;
            this.Background = background;
            this.Alignment = alignment;
            this.Stroke = stroke;
            this.Animation = animation;
            this.Ellipsis = ellipsis;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TextAsset" /> class.
        /// </summary>
        public TextAsset()
        {
        }
    }
}