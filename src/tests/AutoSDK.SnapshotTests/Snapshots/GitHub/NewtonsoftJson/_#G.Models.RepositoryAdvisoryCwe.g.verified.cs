//HintName: G.Models.RepositoryAdvisoryCwe.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RepositoryAdvisoryCwe
    {
        /// <summary>
        /// The Common Weakness Enumeration (CWE) identifier.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cwe_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string CweId { get; set; } = default!;

        /// <summary>
        /// The name of the CWE.<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryAdvisoryCwe" /> class.
        /// </summary>
        /// <param name="cweId">
        /// The Common Weakness Enumeration (CWE) identifier.
        /// </param>
        /// <param name="name">
        /// The name of the CWE.<br/>
        /// Included only in responses
        /// </param>
        public RepositoryAdvisoryCwe(
            string cweId,
            string name = default!)
        {
            this.CweId = cweId ?? throw new global::System.ArgumentNullException(nameof(cweId));
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryAdvisoryCwe" /> class.
        /// </summary>
        public RepositoryAdvisoryCwe()
        {
        }
    }
}