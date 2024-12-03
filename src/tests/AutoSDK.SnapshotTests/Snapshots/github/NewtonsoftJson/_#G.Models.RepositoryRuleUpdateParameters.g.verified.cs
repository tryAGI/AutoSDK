//HintName: G.Models.RepositoryRuleUpdateParameters.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RepositoryRuleUpdateParameters
    {
        /// <summary>
        /// Branch can pull changes from its upstream repository
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("update_allows_fetch_and_merge", Required = global::Newtonsoft.Json.Required.Always)]
        public bool UpdateAllowsFetchAndMerge { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryRuleUpdateParameters" /> class.
        /// </summary>
        /// <param name="updateAllowsFetchAndMerge">
        /// Branch can pull changes from its upstream repository
        /// </param>
        public RepositoryRuleUpdateParameters(
            bool updateAllowsFetchAndMerge)
        {
            this.UpdateAllowsFetchAndMerge = updateAllowsFetchAndMerge;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryRuleUpdateParameters" /> class.
        /// </summary>
        public RepositoryRuleUpdateParameters()
        {
        }
    }
}