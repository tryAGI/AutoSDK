//HintName: G.Models.ScrapeResponseDataBranding.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Brand identity information derived from executing on-page javascript.
    /// </summary>
    public sealed partial class ScrapeResponseDataBranding
    {
        /// <summary>
        /// Primary logo URL if detected.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("logo")]
        public string? Logo { get; set; }

        /// <summary>
        /// Detected font families.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("fonts")]
        public global::System.Collections.Generic.IList<global::G.ScrapeResponseDataBrandingFont>? Fonts { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("colors")]
        public object? Colors { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("typography")]
        public object? Typography { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("spacing")]
        public object? Spacing { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("components")]
        public object? Components { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("icons")]
        public object? Icons { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("images")]
        public object? Images { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("animations")]
        public object? Animations { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("layout")]
        public object? Layout { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tone")]
        public object? Tone { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ScrapeResponseDataBranding" /> class.
        /// </summary>
        /// <param name="logo">
        /// Primary logo URL if detected.
        /// </param>
        /// <param name="fonts">
        /// Detected font families.
        /// </param>
        /// <param name="colors"></param>
        /// <param name="typography"></param>
        /// <param name="spacing"></param>
        /// <param name="components"></param>
        /// <param name="icons"></param>
        /// <param name="images"></param>
        /// <param name="animations"></param>
        /// <param name="layout"></param>
        /// <param name="tone"></param>
        public ScrapeResponseDataBranding(
            string? logo,
            global::System.Collections.Generic.IList<global::G.ScrapeResponseDataBrandingFont>? fonts,
            object? colors,
            object? typography,
            object? spacing,
            object? components,
            object? icons,
            object? images,
            object? animations,
            object? layout,
            object? tone)
        {
            this.Logo = logo;
            this.Fonts = fonts;
            this.Colors = colors;
            this.Typography = typography;
            this.Spacing = spacing;
            this.Components = components;
            this.Icons = icons;
            this.Images = images;
            this.Animations = animations;
            this.Layout = layout;
            this.Tone = tone;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScrapeResponseDataBranding" /> class.
        /// </summary>
        public ScrapeResponseDataBranding()
        {
        }
    }
}