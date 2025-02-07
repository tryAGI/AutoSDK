//HintName: G.Models.ColorPaletteMember.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A member of a color palette.
    /// </summary>
    public sealed partial class ColorPaletteMember
    {
        /// <summary>
        /// The hexadecimal representation of the color with an optional chosen weight<br/>
        /// Example: #FFFFFF
        /// </summary>
        /// <example>#FFFFFF</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("color_hex")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ColorHex { get; set; }

        /// <summary>
        /// The weight of the color in the color palette.<br/>
        /// Example: 0.25
        /// </summary>
        /// <example>0.25</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("color_weight")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double ColorWeight { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ColorPaletteMember" /> class.
        /// </summary>
        /// <param name="colorHex">
        /// The hexadecimal representation of the color with an optional chosen weight<br/>
        /// Example: #FFFFFF
        /// </param>
        /// <param name="colorWeight">
        /// The weight of the color in the color palette.<br/>
        /// Example: 0.25
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ColorPaletteMember(
            string colorHex,
            double colorWeight)
        {
            this.ColorHex = colorHex ?? throw new global::System.ArgumentNullException(nameof(colorHex));
            this.ColorWeight = colorWeight;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ColorPaletteMember" /> class.
        /// </summary>
        public ColorPaletteMember()
        {
        }
    }
}