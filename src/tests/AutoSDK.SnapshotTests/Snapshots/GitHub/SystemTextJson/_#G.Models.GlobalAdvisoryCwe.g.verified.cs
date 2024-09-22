//HintName: G.Models.GlobalAdvisoryCwe.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GlobalAdvisoryCwe
    {
        /// <summary>
        /// The Common Weakness Enumeration (CWE) identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cwe_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CweId { get; set; }

        /// <summary>
        /// The name of the CWE.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}