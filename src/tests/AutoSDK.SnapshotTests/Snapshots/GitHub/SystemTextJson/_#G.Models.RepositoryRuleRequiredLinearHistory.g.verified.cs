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
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.RepositoryRuleRequiredLinearHistoryTypeJsonConverter))]
        public global::G.RepositoryRuleRequiredLinearHistoryType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryRuleRequiredLinearHistory" /> class.
        /// </summary>
        /// <param name="type"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
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