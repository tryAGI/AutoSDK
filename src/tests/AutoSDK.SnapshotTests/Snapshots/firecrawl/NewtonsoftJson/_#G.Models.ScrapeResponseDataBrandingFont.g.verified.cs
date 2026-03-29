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
        [global::Newtonsoft.Json.JsonProperty("family")]
        public string? Family { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ScrapeResponseDataBrandingFont" /> class.
        /// </summary>
        /// <param name="family"></param>
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