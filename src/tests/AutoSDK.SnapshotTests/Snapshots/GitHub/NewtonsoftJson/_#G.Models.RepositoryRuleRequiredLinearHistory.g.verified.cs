//HintName: G.Models.RepositoryRuleRequiredLinearHistory.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Prevent merge commits from being pushed to matching refs.
    /// </summary>
    public sealed partial class RepositoryRuleRequiredLinearHistory
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.RepositoryRuleRequiredLinearHistoryType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryRuleRequiredLinearHistory" /> class.
        /// </summary>
        /// <param name="type"></param>
        public RepositoryRuleRequiredLinearHistory(
            global::G.RepositoryRuleRequiredLinearHistoryType type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryRuleRequiredLinearHistory" /> class.
        /// </summary>
        public RepositoryRuleRequiredLinearHistory()
        {
        }
    }
}