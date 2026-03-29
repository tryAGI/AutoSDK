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
        [global::System.Text.Json.Serialization.JsonPropertyName("backgroundColor")]
        public string? BackgroundColor { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public string? Content { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("font")]
        public string? Font { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("foregroundColor")]
        public string? ForegroundColor { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EditImageGetLayersVariant1Text" /> class.
        /// </summary>
        /// <param name="backgroundColor"></param>
        /// <param name="content"></param>
        /// <param name="font"></param>
        /// <param name="foregroundColor"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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