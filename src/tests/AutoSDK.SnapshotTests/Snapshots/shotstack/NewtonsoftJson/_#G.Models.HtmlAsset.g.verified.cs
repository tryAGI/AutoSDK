//HintName: G.Models.HtmlAsset.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// **Notice: The HtmlAsset is deprecated, use the [TextAsset](#tocs_textasset) instead.**<br/>
    /// The HtmlAsset clip type lets you create text based layout and formatting using<br/>
    /// HTML and CSS. You can also set the height and width of a bounding box for the HTML<br/>
    /// content to sit within. Text and elements will wrap within the bounding box.
    /// </summary>
    [global::System.Obsolete("This model marked as deprecated.")]
    public sealed partial class HtmlAsset
    {
        /// <summary>
        /// The type of asset - set to `html` for HTML.<br/>
        /// Default Value: html
        /// </summary>
        /// <default>global::G.HtmlAssetType.Html</default>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::G.HtmlAssetType Type { get; set; } = global::G.HtmlAssetType.Html;

        /// <summary>
        /// The HTML text string. See list of [supported HTML tags](https://shotstack.io/docs/guide/architecting-an-application/html-support/#supported-html-tags).<br/>
        /// Example: &lt;p&gt;Hello &lt;b&gt;World&lt;/b&gt;&lt;/p&gt;
        /// </summary>
        /// <example>&lt;p&gt;Hello &lt;b&gt;World&lt;/b&gt;&lt;/p&gt;</example>
        [global::Newtonsoft.Json.JsonProperty("html", Required = global::Newtonsoft.Json.Required.Always)]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string Html { get; set; } = default!;

        /// <summary>
        /// The CSS text string to apply styling to the HTML. See list of  [support CSS properties](https://shotstack.io/docs/guide/architecting-an-application/html-support/#supported-css-properties).<br/>
        /// Example: p { color: #ffffff; } b { color: #ffff00; }
        /// </summary>
        /// <example>p { color: #ffffff; } b { color: #ffff00; }</example>
        [global::Newtonsoft.Json.JsonProperty("css")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? Css { get; set; }

        /// <summary>
        /// Set the width of the HTML asset bounding box in pixels. Text will wrap to fill the bounding box.<br/>
        /// Example: 400
        /// </summary>
        /// <example>400</example>
        [global::Newtonsoft.Json.JsonProperty("width")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public int? Width { get; set; }

        /// <summary>
        /// Set the width of the HTML asset bounding box in pixels. Text and elements will be masked if they exceed the  height of the bounding box.<br/>
        /// Example: 200
        /// </summary>
        /// <example>200</example>
        [global::Newtonsoft.Json.JsonProperty("height")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public int? Height { get; set; }

        /// <summary>
        /// Apply a background color behind the HTML bounding box using. Set the text color using hexadecimal  color notation. Transparency is supported by setting the first two characters of the hex string  (opposite to HTML), i.e. #80ffffff will be white with 50% transparency.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("background")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? Background { get; set; }

        /// <summary>
        /// Place the HTML in one of nine predefined positions within the HTML area. &lt;ul&gt;<br/>
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
        public global::G.HtmlAssetPosition? Position { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HtmlAsset" /> class.
        /// </summary>
        /// <param name="html">
        /// The HTML text string. See list of [supported HTML tags](https://shotstack.io/docs/guide/architecting-an-application/html-support/#supported-html-tags).<br/>
        /// Example: &lt;p&gt;Hello &lt;b&gt;World&lt;/b&gt;&lt;/p&gt;
        /// </param>
        /// <param name="css">
        /// The CSS text string to apply styling to the HTML. See list of  [support CSS properties](https://shotstack.io/docs/guide/architecting-an-application/html-support/#supported-css-properties).<br/>
        /// Example: p { color: #ffffff; } b { color: #ffff00; }
        /// </param>
        /// <param name="width">
        /// Set the width of the HTML asset bounding box in pixels. Text will wrap to fill the bounding box.<br/>
        /// Example: 400
        /// </param>
        /// <param name="height">
        /// Set the width of the HTML asset bounding box in pixels. Text and elements will be masked if they exceed the  height of the bounding box.<br/>
        /// Example: 200
        /// </param>
        /// <param name="background">
        /// Apply a background color behind the HTML bounding box using. Set the text color using hexadecimal  color notation. Transparency is supported by setting the first two characters of the hex string  (opposite to HTML), i.e. #80ffffff will be white with 50% transparency.
        /// </param>
        /// <param name="position">
        /// Place the HTML in one of nine predefined positions within the HTML area. &lt;ul&gt;<br/>
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
        /// <param name="type">
        /// The type of asset - set to `html` for HTML.<br/>
        /// Default Value: html
        /// </param>
        public HtmlAsset(
            string html,
            string? css,
            int? width,
            int? height,
            string? background,
            global::G.HtmlAssetPosition? position,
            global::G.HtmlAssetType type = global::G.HtmlAssetType.Html)
        {
            this.Type = type;
            this.Html = html ?? throw new global::System.ArgumentNullException(nameof(html));
            this.Css = css;
            this.Width = width;
            this.Height = height;
            this.Background = background;
            this.Position = position;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HtmlAsset" /> class.
        /// </summary>
        public HtmlAsset()
        {
        }
    }
}