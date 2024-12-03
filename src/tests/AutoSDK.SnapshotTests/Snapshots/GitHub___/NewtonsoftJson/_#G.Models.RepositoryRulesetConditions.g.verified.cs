//HintName: G.Models.RepositoryRulesetConditions.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Parameters for a repository ruleset ref name condition
    /// </summary>
    public sealed partial class RepositoryRulesetConditions
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ref_name")]
        public global::G.RepositoryRulesetConditionsRefName? RefName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryRulesetConditions" /> class.
        /// </summary>
        /// <param name="refName"></param>
        public RepositoryRulesetConditions(
            global::G.RepositoryRulesetConditionsRefName? refName)
        {
            this.RefName = refName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryRulesetConditions" /> class.
        /// </summary>
        public RepositoryRulesetConditions()
        {
        }
    }
}