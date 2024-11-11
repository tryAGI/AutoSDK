//HintName: G.Models.WeaviateRootResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WeaviateRootResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("links")]
        public global::System.Collections.Generic.IList<global::G.Link>? Links { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WeaviateRootResponse" /> class.
        /// </summary>
        /// <param name="links"></param>
        public WeaviateRootResponse(
            global::System.Collections.Generic.IList<global::G.Link>? links)
        {
            this.Links = links;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WeaviateRootResponse" /> class.
        /// </summary>
        public WeaviateRootResponse()
        {
        }
    }
}