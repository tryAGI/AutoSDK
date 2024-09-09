//HintName: G.Models.DependabotAlertSecurityAdvisoryCwe.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A CWE weakness assigned to the advisory.
    /// </summary>
    public sealed partial class DependabotAlertSecurityAdvisoryCwe
    {
        /// <summary>
        /// The unique CWE ID.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cwe_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string CweId { get; set; } = default!;

        /// <summary>
        /// The short, plain text name of the CWE.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}