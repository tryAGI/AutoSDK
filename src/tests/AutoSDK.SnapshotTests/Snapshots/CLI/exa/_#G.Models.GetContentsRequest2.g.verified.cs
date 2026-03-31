//HintName: G.Models.GetContentsRequest2.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetContentsRequest2
    {
        /// <summary>
        /// Array of URLs to crawl (backwards compatible with 'ids' parameter).<br/>
        /// Example: [https://arxiv.org/pdf/2307.06435]
        /// </summary>
        /// <example>[https://arxiv.org/pdf/2307.06435]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("urls")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Urls { get; set; }

        /// <summary>
        /// Deprecated - use 'urls' instead. Array of document IDs obtained from searches.<br/>
        /// Example: [https://arxiv.org/pdf/2307.06435]
        /// </summary>
        /// <example>[https://arxiv.org/pdf/2307.06435]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("ids")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::System.Collections.Generic.IList<string>? Ids { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetContentsRequest2" /> class.
        /// </summary>
        /// <param name="urls">
        /// Array of URLs to crawl (backwards compatible with 'ids' parameter).<br/>
        /// Example: [https://arxiv.org/pdf/2307.06435]
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetContentsRequest2(
            global::System.Collections.Generic.IList<string> urls)
        {
            this.Urls = urls ?? throw new global::System.ArgumentNullException(nameof(urls));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetContentsRequest2" /> class.
        /// </summary>
        public GetContentsRequest2()
        {
        }
    }
}