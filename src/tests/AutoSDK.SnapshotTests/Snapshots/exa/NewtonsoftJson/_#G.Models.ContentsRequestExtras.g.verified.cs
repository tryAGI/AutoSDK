//HintName: G.Models.ContentsRequestExtras.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Extra parameters to pass.
    /// </summary>
    public sealed partial class ContentsRequestExtras
    {
        /// <summary>
        /// Number of URLs to return from each webpage.<br/>
        /// Default Value: 0<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::Newtonsoft.Json.JsonProperty("links")]
        public int? Links { get; set; }

        /// <summary>
        /// Number of images to return for each result.<br/>
        /// Default Value: 0<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::Newtonsoft.Json.JsonProperty("imageLinks")]
        public int? ImageLinks { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ContentsRequestExtras" /> class.
        /// </summary>
        /// <param name="links">
        /// Number of URLs to return from each webpage.<br/>
        /// Default Value: 0<br/>
        /// Example: 1
        /// </param>
        /// <param name="imageLinks">
        /// Number of images to return for each result.<br/>
        /// Default Value: 0<br/>
        /// Example: 1
        /// </param>
        public ContentsRequestExtras(
            int? links,
            int? imageLinks)
        {
            this.Links = links;
            this.ImageLinks = imageLinks;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContentsRequestExtras" /> class.
        /// </summary>
        public ContentsRequestExtras()
        {
        }
    }
}