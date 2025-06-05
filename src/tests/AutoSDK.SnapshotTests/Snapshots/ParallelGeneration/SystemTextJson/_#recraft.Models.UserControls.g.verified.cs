//HintName: recraft.Models.UserControls.g.cs

#nullable enable

namespace recraft
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UserControls
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("background_color")]
        public global::recraft.ImageColor? BackgroundColor { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("colors")]
        public global::System.Collections.Generic.IList<global::recraft.ImageColor>? Colors { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserControls" /> class.
        /// </summary>
        /// <param name="backgroundColor"></param>
        /// <param name="colors"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserControls(
            global::recraft.ImageColor? backgroundColor,
            global::System.Collections.Generic.IList<global::recraft.ImageColor>? colors)
        {
            this.BackgroundColor = backgroundColor;
            this.Colors = colors;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserControls" /> class.
        /// </summary>
        public UserControls()
        {
        }
    }
}