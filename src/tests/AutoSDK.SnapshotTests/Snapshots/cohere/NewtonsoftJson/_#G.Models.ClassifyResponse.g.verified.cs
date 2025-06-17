//HintName: G.Models.ClassifyResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ClassifyResponse
    {
        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("classifications")]
        public global::System.Collections.Generic.IList<global::G.ClassifyResponseClassification> Classifications { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("meta")]
        public global::G.ApiMeta? Meta { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ClassifyResponse" /> class.
        /// </summary>
        /// <param name="classifications">
        /// Included only in responses
        /// </param>
        /// <param name="id">
        /// Included only in responses
        /// </param>
        /// <param name="meta"></param>
        public ClassifyResponse(
            global::G.ApiMeta? meta,
            global::System.Collections.Generic.IList<global::G.ClassifyResponseClassification> classifications = default!,
            string id = default!)
        {
            this.Classifications = classifications;
            this.Id = id;
            this.Meta = meta;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClassifyResponse" /> class.
        /// </summary>
        public ClassifyResponse()
        {
        }
    }
}