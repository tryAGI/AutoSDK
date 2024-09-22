//HintName: G.Models.DependabotAlertSecurityAdvisoryCvss.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Details for the advisory pertaining to the Common Vulnerability Scoring System.<br/>
    /// Included only in responses
    /// </summary>
    public sealed partial class DependabotAlertSecurityAdvisoryCvss
    {
        /// <summary>
        /// The overall CVSS score of the advisory.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("score")]
        public double Score { get; set; } = default!;

        /// <summary>
        /// The full CVSS vector string for the advisory.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("vector_string")]
        public string? VectorString { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}