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
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ColorPalettePresetName Name { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ColorPaletteWithPresetName" /> class.
        /// </summary>
        /// <param name="name">
        /// A color palette preset value<br/>
        /// Example: PASTEL
        /// </param>
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