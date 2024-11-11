//HintName: G.Models.ApiOverviewDomainsArtifactAttestations.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ApiOverviewDomainsArtifactAttestations
    {
        /// <summary>
        /// Example: [example]
        /// </summary>
        /// <example>[example]</example>
        [global::Newtonsoft.Json.JsonProperty("trust_domain")]
        public string? TrustDomain { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("services")]
        public global::System.Collections.Generic.IList<string>? Services { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiOverviewDomainsArtifactAttestations" /> class.
        /// </summary>
        /// <param name="trustDomain">
        /// Example: [example]
        /// </param>
        /// <param name="services"></param>
        public ApiOverviewDomainsArtifactAttestations(
            string? trustDomain,
            global::System.Collections.Generic.IList<string>? services)
        {
            this.TrustDomain = trustDomain;
            this.Services = services;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiOverviewDomainsArtifactAttestations" /> class.
        /// </summary>
        public ApiOverviewDomainsArtifactAttestations()
        {
        }
    }
}