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
        [global::System.Text.Json.Serialization.JsonPropertyName("color_hex")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ColorHex { get; set; }

        /// <summary>
        /// The weight of the color in the color palette.<br/>
        /// Example: 0.25
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("color_weight")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double ColorWeight { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}