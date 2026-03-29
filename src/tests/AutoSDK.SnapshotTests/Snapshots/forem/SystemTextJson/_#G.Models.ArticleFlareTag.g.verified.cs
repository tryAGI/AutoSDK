//HintName: G.Models.ArticleFlareTag.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Flare tag of the article
    /// </summary>
    public sealed partial class ArticleFlareTag
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Background color (hexadecimal)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bg_color_hex")]
        public string? BgColorHex { get; set; }

        /// <summary>
        /// Text color (hexadecimal)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text_color_hex")]
        public string? TextColorHex { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ArticleFlareTag" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="bgColorHex">
        /// Background color (hexadecimal)
        /// </param>
        /// <param name="textColorHex">
        /// Text color (hexadecimal)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ArticleFlareTag(
            string? name,
            string? bgColorHex,
            string? textColorHex)
        {
            this.Name = name;
            this.BgColorHex = bgColorHex;
            this.TextColorHex = textColorHex;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ArticleFlareTag" /> class.
        /// </summary>
        public ArticleFlareTag()
        {
        }
    }
}