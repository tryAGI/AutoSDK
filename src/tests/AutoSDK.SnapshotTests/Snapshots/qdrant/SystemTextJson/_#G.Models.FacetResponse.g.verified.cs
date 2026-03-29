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
        [global::System.Text.Json.Serialization.JsonPropertyName("hits")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.FacetValueHit> Hits { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FacetResponse" /> class.
        /// </summary>
        /// <param name="hits"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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