//HintName: G.Models.UsersListAttestationsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UsersListAttestationsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attestations")]
        public global::System.Collections.Generic.IList<global::G.UsersListAttestationsResponseAttestation>? Attestations { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UsersListAttestationsResponse" /> class.
        /// </summary>
        /// <param name="attestations"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public UsersListAttestationsResponse(
            global::System.Collections.Generic.IList<global::G.UsersListAttestationsResponseAttestation>? attestations)
        {
            this.Attestations = attestations;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UsersListAttestationsResponse" /> class.
        /// </summary>
        public UsersListAttestationsResponse()
        {
        }
    }
}