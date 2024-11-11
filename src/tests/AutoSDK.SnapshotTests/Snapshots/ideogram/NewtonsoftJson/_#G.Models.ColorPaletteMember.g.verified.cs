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
        [global::Newtonsoft.Json.JsonProperty("color_hex", Required = global::Newtonsoft.Json.Required.Always)]
        public string ColorHex { get; set; } = default!;

        /// <summary>
        /// The weight of the color in the color palette.<br/>
        /// Example: 0.25
        /// </summary>
        /// <example>0.25</example>
        [global::Newtonsoft.Json.JsonProperty("color_weight", Required = global::Newtonsoft.Json.Required.Always)]
        public double ColorWeight { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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