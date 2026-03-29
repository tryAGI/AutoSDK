//HintName: G.Models.RichTextGradientStop.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RichTextGradientStop
    {
        /// <summary>
        /// Position of the color stop between 0 (start) and 1 (end).<br/>
        /// Example: 0.5F
        /// </summary>
        /// <example>0.5F</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("offset")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Offset { get; set; }

        /// <summary>
        /// Color at this stop using hexadecimal color notation.<br/>
        /// Example: #ff0000
        /// </summary>
        /// <example>#ff0000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("color")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Color { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RichTextGradientStop" /> class.
        /// </summary>
        /// <param name="offset">
        /// Position of the color stop between 0 (start) and 1 (end).<br/>
        /// Example: 0.5F
        /// </param>
        /// <param name="color">
        /// Color at this stop using hexadecimal color notation.<br/>
        /// Example: #ff0000
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RichTextGradientStop(
            double offset,
            string color)
        {
            this.Offset = offset;
            this.Color = color ?? throw new global::System.ArgumentNullException(nameof(color));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RichTextGradientStop" /> class.
        /// </summary>
        public RichTextGradientStop()
        {
        }
    }
}