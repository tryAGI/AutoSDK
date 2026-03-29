//HintName: G.Models.WebsiteCrawlRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebsiteCrawlRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("websites")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.WebsiteCrawlRequestWebsite> Websites { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebsiteCrawlRequest" /> class.
        /// </summary>
        /// <param name="websites"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebsiteCrawlRequest(
            global::System.Collections.Generic.IList<global::G.WebsiteCrawlRequestWebsite> websites)
        {
            this.Websites = websites ?? throw new global::System.ArgumentNullException(nameof(websites));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebsiteCrawlRequest" /> class.
        /// </summary>
        public WebsiteCrawlRequest()
        {
        }
    }
}