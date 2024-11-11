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
        [global::Newtonsoft.Json.JsonProperty("attestations")]
        public global::System.Collections.Generic.IList<global::G.OrgsListAttestationsResponseAttestation>? Attestations { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OrgsListAttestationsResponse" /> class.
        /// </summary>
        /// <param name="attestations"></param>
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