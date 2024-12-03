//HintName: G.Models.PagesHealthCheck.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Pages Health Check Status
    /// </summary>
    public sealed partial class PagesHealthCheck
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("domain")]
        public global::G.PagesHealthCheckDomain? Domain { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("alt_domain")]
        public global::G.PagesHealthCheckAltDomain? AltDomain { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PagesHealthCheck" /> class.
        /// </summary>
        /// <param name="domain"></param>
        /// <param name="altDomain"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public PagesHealthCheck(
            global::G.PagesHealthCheckDomain? domain,
            global::G.PagesHealthCheckAltDomain? altDomain)
        {
            this.Domain = domain;
            this.AltDomain = altDomain;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PagesHealthCheck" /> class.
        /// </summary>
        public PagesHealthCheck()
        {
        }
    }
}