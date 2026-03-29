//HintName: G.Models.FacetResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FacetResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("hits", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.FacetValueHit> Hits { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FacetResponse" /> class.
        /// </summary>
        /// <param name="hits"></param>
        public FacetResponse(
            global::System.Collections.Generic.IList<global::G.FacetValueHit> hits)
        {
            this.Hits = hits ?? throw new global::System.ArgumentNullException(nameof(hits));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FacetResponse" /> class.
        /// </summary>
        public FacetResponse()
        {
        }
    }
}