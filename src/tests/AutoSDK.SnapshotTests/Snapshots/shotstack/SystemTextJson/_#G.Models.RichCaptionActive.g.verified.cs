//HintName: G.Models.RichCaptionActive.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Styling properties for the active/highlighted word.
    /// </summary>
    public sealed partial class RichCaptionActive
    {
        /// <summary>
        /// Font properties for the active/highlighted word.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("font")]
        public global::G.RichCaptionActiveFont? Font { get; set; }

        /// <summary>
        /// Stroke properties for the active word. Set to "none" to explicitly remove the base stroke on the active word.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stroke")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverter<global::G.RichTextStroke, global::G.RichCaptionActiveStroke?>))]
        public global::G.OneOf<global::G.RichTextStroke, global::G.RichCaptionActiveStroke?>? Stroke { get; set; }

        /// <summary>
        /// Shadow properties for the active word. Set to "none" to explicitly remove the base shadow on the active word.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("shadow")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverter<global::G.RichTextShadow, global::G.RichCaptionActiveShadow?>))]
        public global::G.OneOf<global::G.RichTextShadow, global::G.RichCaptionActiveShadow?>? Shadow { get; set; }

        /// <summary>
        /// Scale multiplier for the active word. 1.0 is normal size, 1.2 is 20% larger.<br/>
        /// Default Value: 1<br/>
        /// Example: 1.2F
        /// </summary>
        /// <example>1.2F</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("scale")]
        public double? Scale { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RichCaptionActive" /> class.
        /// </summary>
        /// <param name="font">
        /// Font properties for the active/highlighted word.
        /// </param>
        /// <param name="stroke">
        /// Stroke properties for the active word. Set to "none" to explicitly remove the base stroke on the active word.
        /// </param>
        /// <param name="shadow">
        /// Shadow properties for the active word. Set to "none" to explicitly remove the base shadow on the active word.
        /// </param>
        /// <param name="scale">
        /// Scale multiplier for the active word. 1.0 is normal size, 1.2 is 20% larger.<br/>
        /// Default Value: 1<br/>
        /// Example: 1.2F
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RichCaptionActive(
            global::G.RichCaptionActiveFont? font,
            global::G.OneOf<global::G.RichTextStroke, global::G.RichCaptionActiveStroke?>? stroke,
            global::G.OneOf<global::G.RichTextShadow, global::G.RichCaptionActiveShadow?>? shadow,
            double? scale)
        {
            this.Font = font;
            this.Stroke = stroke;
            this.Shadow = shadow;
            this.Scale = scale;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RichCaptionActive" /> class.
        /// </summary>
        public RichCaptionActive()
        {
        }
    }
}