//HintName: G.Models.EditImageGetLayersVariant1Text.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EditImageGetLayersVariant1Text
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("backgroundColor")]
        public string? BackgroundColor { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content")]
        public string? Content { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("font")]
        public string? Font { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("foregroundColor")]
        public string? ForegroundColor { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EditImageGetLayersVariant1Text" /> class.
        /// </summary>
        /// <param name="backgroundColor"></param>
        /// <param name="content"></param>
        /// <param name="font"></param>
        /// <param name="foregroundColor"></param>
        public EditImageGetLayersVariant1Text(
            string? backgroundColor,
            string? content,
            string? font,
            string? foregroundColor)
        {
            this.BackgroundColor = backgroundColor;
            this.Content = content;
            this.Font = font;
            this.ForegroundColor = foregroundColor;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EditImageGetLayersVariant1Text" /> class.
        /// </summary>
        public EditImageGetLayersVariant1Text()
        {
        }
    }
}