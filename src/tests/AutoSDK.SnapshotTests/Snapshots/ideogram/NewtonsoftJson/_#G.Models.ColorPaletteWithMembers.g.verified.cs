//HintName: G.Models.ColorPaletteWithMembers.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A color palette represented only via its members
    /// </summary>
    public sealed partial class ColorPaletteWithMembers
    {
        /// <summary>
        /// A list of ColorPaletteMembers that define the color palette.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("members", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.ColorPaletteMember> Members { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ColorPaletteWithMembers" /> class.
        /// </summary>
        /// <param name="members">
        /// A list of ColorPaletteMembers that define the color palette.
        /// </param>
        public ColorPaletteWithMembers(
            global::System.Collections.Generic.IList<global::G.ColorPaletteMember> members)
        {
            this.Members = members ?? throw new global::System.ArgumentNullException(nameof(members));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ColorPaletteWithMembers" /> class.
        /// </summary>
        public ColorPaletteWithMembers()
        {
        }
    }
}