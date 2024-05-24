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
        [global::Newtonsoft.Json.JsonProperty("domain")]
        public PagesHealthCheckDomain? Domain { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("alt_domain")]
        public PagesHealthCheckAltDomain? AltDomain { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}