//HintName: G.Models.DependabotAlertSecurityAdvisoryCwe.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A CWE weakness assigned to the advisory.<br/>
    /// Included only in responses
    /// </summary>
    public sealed partial class DependabotAlertSecurityAdvisoryCwe
    {
        /// <summary>
        /// The unique CWE ID.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cwe_id")]
        public string CweId { get; set; } = default!;

        /// <summary>
        /// The short, plain text name of the CWE.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}