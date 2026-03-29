//HintName: G.Models.ScrapeResponseDataBrandingFont.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ScrapeResponseDataBrandingFont
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("family")]
        public string? Family { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ScrapeResponseDataBrandingFont" /> class.
        /// </summary>
        /// <param name="family"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ScrapeResponseDataBrandingFont(
            string? family)
        {
            this.Family = family;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScrapeResponseDataBrandingFont" /> class.
        /// </summary>
        public ScrapeResponseDataBrandingFont()
        {
        }
    }
}