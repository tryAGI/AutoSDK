//HintName: G.Models.RepositoryAdvisoryCvss.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RepositoryAdvisoryCvss
    {
        /// <summary>
        /// The CVSS vector.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("vector_string", Required = global::Newtonsoft.Json.Required.Always)]
        public string? VectorString { get; set; } = default!;

        /// <summary>
        /// The CVSS score.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("score")]
        public double? Score { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}