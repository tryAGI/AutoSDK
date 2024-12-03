//HintName: G.Models.CheermoteImages.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CheermoteImages
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("light")]
        public global::G.CheermoteImageTheme? Light { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dark")]
        public global::G.CheermoteImageTheme? Dark { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CheermoteImages" /> class.
        /// </summary>
        /// <param name="light"></param>
        /// <param name="dark"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public CheermoteImages(
            global::G.CheermoteImageTheme? light,
            global::G.CheermoteImageTheme? dark)
        {
            this.Light = light;
            this.Dark = dark;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CheermoteImages" /> class.
        /// </summary>
        public CheermoteImages()
        {
        }
    }
}