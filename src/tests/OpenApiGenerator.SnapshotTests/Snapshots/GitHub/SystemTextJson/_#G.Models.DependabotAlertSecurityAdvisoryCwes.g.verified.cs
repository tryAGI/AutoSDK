//HintName: G.Models.DependabotAlertSecurityAdvisoryCwes.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A CWE weakness assigned to the advisory.
    /// </summary>
    public sealed partial class DependabotAlertSecurityAdvisoryCwes
    {
        /// <summary>
        /// The unique CWE ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cwe_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CweId { get; set; }

        /// <summary>
        /// The short, plain text name of the CWE.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}