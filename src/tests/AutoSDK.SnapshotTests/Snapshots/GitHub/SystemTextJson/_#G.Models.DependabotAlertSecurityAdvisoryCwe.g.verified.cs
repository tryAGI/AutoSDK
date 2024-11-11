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
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("cwe_id")]
        public string CweId { get; set; } = default!;

        /// <summary>
        /// The short, plain text name of the CWE.<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DependabotAlertSecurityAdvisoryCwe" /> class.
        /// </summary>
        /// <param name="cweId">
        /// The unique CWE ID.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="name">
        /// The short, plain text name of the CWE.<br/>
        /// Included only in responses
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public DependabotAlertSecurityAdvisoryCwe(
            string cweId = default!,
            string name = default!)
        {
            this.CweId = cweId;
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DependabotAlertSecurityAdvisoryCwe" /> class.
        /// </summary>
        public DependabotAlertSecurityAdvisoryCwe()
        {
        }
    }
}