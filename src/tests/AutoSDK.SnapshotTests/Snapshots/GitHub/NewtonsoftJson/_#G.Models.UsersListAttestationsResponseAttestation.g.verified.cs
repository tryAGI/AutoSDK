//HintName: G.Models.UsersListAttestationsResponseAttestation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UsersListAttestationsResponseAttestation
    {
        /// <summary>
        /// Sigstore Bundle v0.1
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("bundle")]
        public global::G.SigstoreBundle0? Bundle { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("repository_id")]
        public int? RepositoryId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UsersListAttestationsResponseAttestation" /> class.
        /// </summary>
        /// <param name="bundle">
        /// Sigstore Bundle v0.1
        /// </param>
        /// <param name="repositoryId"></param>
        public UsersListAttestationsResponseAttestation(
            global::G.SigstoreBundle0? bundle,
            int? repositoryId)
        {
            this.Bundle = bundle;
            this.RepositoryId = repositoryId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UsersListAttestationsResponseAttestation" /> class.
        /// </summary>
        public UsersListAttestationsResponseAttestation()
        {
        }
    }
}