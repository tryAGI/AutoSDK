//HintName: G.Models.TitleAsset.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// **Notice: The TitleAsset is deprecated, use the [TextAsset](#tocs_textasset) instead.**<br/>
    /// The TitleAsset clip type lets you create video titles from a text string and apply styling and positioning.
    /// </summary>
    [global::System.Obsolete("This model marked as deprecated.")]
    public sealed partial class TitleAsset
    {
        /// <summary>
        /// The type of asset - set to `title` for titles.<br/>
        /// Default Value: title
        /// </summary>
        /// <default>global::G.TitleAssetType.Title</default>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::G.TitleAssetType Type { get; set; } = global::G.TitleAssetType.Title;

        /// <summary>
        /// The title text string - i.e. "My Title".<br/>
        /// Example: Hello World
        /// </summary>
        /// <example>Hello World</example>
        [global::Newtonsoft.Json.JsonProperty("text", Required = global::Newtonsoft.Json.Required.Always)]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string Text { get; set; } = default!;

        /// <summary>
        /// Uses a preset to apply font properties and styling to the title. &lt;ul&gt;<br/>
        ///   &lt;li&gt;`minimal`&lt;/li&gt;<br/>
        ///   &lt;li&gt;`blockbuster`&lt;/li&gt;<br/>
        ///   &lt;li&gt;`vogue`&lt;/li&gt;<br/>
        ///   &lt;li&gt;`sketchy`&lt;/li&gt;<br/>
        ///   &lt;li&gt;`skinny`&lt;/li&gt;<br/>
        ///   &lt;li&gt;`chunk`&lt;/li&gt;<br/>
        ///   &lt;li&gt;`chunkLight`&lt;/li&gt;<br/>
        ///   &lt;li&gt;`marker`&lt;/li&gt;<br/>
        ///   &lt;li&gt;`future`&lt;/li&gt;<br/>
        ///   &lt;li&gt;`subtitle`&lt;/li&gt;<br/>
        /// &lt;/ul&gt;
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("style")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::G.TitleAssetStyle? Style { get; set; }

        /// <summary>
        /// Set the text color using hexadecimal color notation. Transparency is supported by setting the first two characters of the hex string (opposite to HTML),  i.e. #80ffffff will be white with  50% transparency.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("color")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? Color { get; set; }

        /// <summary>
        /// Set the relative size of the text using predefined sizes from xx-small to xx-large. &lt;ul&gt;<br/>
        ///   &lt;li&gt;`xx-small`&lt;/li&gt;<br/>
        ///   &lt;li&gt;`x-small`&lt;/li&gt;<br/>
        ///   &lt;li&gt;`small`&lt;/li&gt;<br/>
        ///   &lt;li&gt;`medium`&lt;/li&gt;<br/>
        ///   &lt;li&gt;`large`&lt;/li&gt;<br/>
        ///   &lt;li&gt;`x-large`&lt;/li&gt;<br/>
        ///   &lt;li&gt;`xx-large`&lt;/li&gt;<br/>
        /// &lt;/ul&gt;
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("size")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::G.TitleAssetSize? Size { get; set; }

        /// <summary>
        /// Apply a background color behind the text. Set the text color using hexadecimal color notation. Transparency is supported by setting the first two characters of the hex string (opposite to HTML),  i.e. #80ffffff will be white with 50% transparency. Omit to use transparent background.<br/>
        /// Example: #000000
        /// </summary>
        /// <example>#000000</example>
        [global::Newtonsoft.Json.JsonProperty("background")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? Background { get; set; }

        /// <summary>
        /// Place the title in one of nine predefined positions of the viewport. &lt;ul&gt;<br/>
        ///   &lt;li&gt;`top` - top (center)&lt;/li&gt;<br/>
        ///   &lt;li&gt;`topRight` - top right&lt;/li&gt;<br/>
        ///   &lt;li&gt;`right` - right (center)&lt;/li&gt;<br/>
        ///   &lt;li&gt;`bottomRight` - bottom right&lt;/li&gt;<br/>
        ///   &lt;li&gt;`bottom` - bottom (center)&lt;/li&gt;<br/>
        ///   &lt;li&gt;`bottomLeft` - bottom left&lt;/li&gt;<br/>
        ///   &lt;li&gt;`left` - left (center)&lt;/li&gt;<br/>
        ///   &lt;li&gt;`topLeft` - top left&lt;/li&gt;<br/>
        ///   &lt;li&gt;`center` - center&lt;/li&gt;<br/>
        /// &lt;/ul&gt;
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("position")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::G.TitleAssetPosition? Position { get; set; }

        /// <summary>
        /// Offsets the position of an asset horizontally or vertically by a relative distance.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("offset")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::G.Offset? Offset { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TitleAsset" /> class.
        /// </summary>
        /// <param name="text">
        /// The title text string - i.e. "My Title".<br/>
        /// Example: Hello World
        /// </param>
        /// <param name="style">
        /// Uses a preset to apply font properties and styling to the title. &lt;ul&gt;<br/>
        ///   &lt;li&gt;`minimal`&lt;/li&gt;<br/>
        ///   &lt;li&gt;`blockbuster`&lt;/li&gt;<br/>
        ///   &lt;li&gt;`vogue`&lt;/li&gt;<br/>
        ///   &lt;li&gt;`sketchy`&lt;/li&gt;<br/>
        ///   &lt;li&gt;`skinny`&lt;/li&gt;<br/>
        ///   &lt;li&gt;`chunk`&lt;/li&gt;<br/>
        ///   &lt;li&gt;`chunkLight`&lt;/li&gt;<br/>
        ///   &lt;li&gt;`marker`&lt;/li&gt;<br/>
        ///   &lt;li&gt;`future`&lt;/li&gt;<br/>
        ///   &lt;li&gt;`subtitle`&lt;/li&gt;<br/>
        /// &lt;/ul&gt;
        /// </param>
        /// <param name="color">
        /// Set the text color using hexadecimal color notation. Transparency is supported by setting the first two characters of the hex string (opposite to HTML),  i.e. #80ffffff will be white with  50% transparency.
        /// </param>
        /// <param name="size">
        /// Set the relative size of the text using predefined sizes from xx-small to xx-large. &lt;ul&gt;<br/>
        ///   &lt;li&gt;`xx-small`&lt;/li&gt;<br/>
        ///   &lt;li&gt;`x-small`&lt;/li&gt;<br/>
        ///   &lt;li&gt;`small`&lt;/li&gt;<br/>
        ///   &lt;li&gt;`medium`&lt;/li&gt;<br/>
        ///   &lt;li&gt;`large`&lt;/li&gt;<br/>
        ///   &lt;li&gt;`x-large`&lt;/li&gt;<br/>
        ///   &lt;li&gt;`xx-large`&lt;/li&gt;<br/>
        /// &lt;/ul&gt;
        /// </param>
        /// <param name="background">
        /// Apply a background color behind the text. Set the text color using hexadecimal color notation. Transparency is supported by setting the first two characters of the hex string (opposite to HTML),  i.e. #80ffffff will be white with 50% transparency. Omit to use transparent background.<br/>
        /// Example: #000000
        /// </param>
        /// <param name="position">
        /// Place the title in one of nine predefined positions of the viewport. &lt;ul&gt;<br/>
        ///   &lt;li&gt;`top` - top (center)&lt;/li&gt;<br/>
        ///   &lt;li&gt;`topRight` - top right&lt;/li&gt;<br/>
        ///   &lt;li&gt;`right` - right (center)&lt;/li&gt;<br/>
        ///   &lt;li&gt;`bottomRight` - bottom right&lt;/li&gt;<br/>
        ///   &lt;li&gt;`bottom` - bottom (center)&lt;/li&gt;<br/>
        ///   &lt;li&gt;`bottomLeft` - bottom left&lt;/li&gt;<br/>
        ///   &lt;li&gt;`left` - left (center)&lt;/li&gt;<br/>
        ///   &lt;li&gt;`topLeft` - top left&lt;/li&gt;<br/>
        ///   &lt;li&gt;`center` - center&lt;/li&gt;<br/>
        /// &lt;/ul&gt;
        /// </param>
        /// <param name="offset">
        /// Offsets the position of an asset horizontally or vertically by a relative distance.
        /// </param>
        /// <param name="type">
        /// The type of asset - set to `title` for titles.<br/>
        /// Default Value: title
        /// </param>
        public TitleAsset(
            string text,
            global::G.TitleAssetStyle? style,
            string? color,
            global::G.TitleAssetSize? size,
            string? background,
            global::G.TitleAssetPosition? position,
            global::G.Offset? offset,
            global::G.TitleAssetType type = global::G.TitleAssetType.Title)
        {
            this.Type = type;
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Style = style;
            this.Color = color;
            this.Size = size;
            this.Background = background;
            this.Position = position;
            this.Offset = offset;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TitleAsset" /> class.
        /// </summary>
        public TitleAsset()
        {
        }
    }
}