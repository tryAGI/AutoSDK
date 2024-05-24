//HintName: G.Models.GlobalAdvisoryCwes.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GlobalAdvisoryCwes
    {
        /// <summary>
        /// The Common Weakness Enumeration (CWE) identifier.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cwe_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string CweId { get; set; } = default!;

        /// <summary>
        /// The name of the CWE.
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