//HintName: G.Models.CheermoteImageTheme.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CheermoteImageTheme
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("animated")]
        public global::G.CheermoteImageFormat? Animated { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("static")]
        public global::G.CheermoteImageFormat? Static { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CheermoteImageTheme" /> class.
        /// </summary>
        /// <param name="animated"></param>
        /// <param name="static"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CheermoteImageTheme(
            global::G.CheermoteImageFormat? animated,
            global::G.CheermoteImageFormat? @static)
        {
            this.Animated = animated;
            this.Static = @static;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CheermoteImageTheme" /> class.
        /// </summary>
        public CheermoteImageTheme()
        {
        }
    }
}