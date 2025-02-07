//HintName: G.Models.OrgsListAttestationsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OrgsListAttestationsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attestations")]
        public global::System.Collections.Generic.IList<global::G.OrgsListAttestationsResponseAttestation>? Attestations { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OrgsListAttestationsResponse" /> class.
        /// </summary>
        /// <param name="attestations"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OrgsListAttestationsResponse(
            global::System.Collections.Generic.IList<global::G.OrgsListAttestationsResponseAttestation>? attestations)
        {
            this.Attestations = attestations;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrgsListAttestationsResponse" /> class.
        /// </summary>
        public OrgsListAttestationsResponse()
        {
        }
    }
}