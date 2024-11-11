//HintName: G.Models.ColorPaletteWithPresetName.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ColorPaletteWithPresetName
    {
        /// <summary>
        /// A color palette preset value<br/>
        /// Example: PASTEL
        /// </summary>
        /// <example>PASTEL</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ColorPalettePresetNameJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ColorPalettePresetName Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ColorPaletteWithPresetName" /> class.
        /// </summary>
        /// <param name="name">
        /// A color palette preset value<br/>
        /// Example: PASTEL
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ColorPaletteWithPresetName(
            global::G.ColorPalettePresetName name)
        {
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ColorPaletteWithPresetName" /> class.
        /// </summary>
        public ColorPaletteWithPresetName()
        {
        }
    }
}