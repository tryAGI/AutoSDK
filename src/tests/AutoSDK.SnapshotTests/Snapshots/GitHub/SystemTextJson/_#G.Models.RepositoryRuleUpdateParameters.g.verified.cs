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
        [global::System.Text.Json.Serialization.JsonPropertyName("update_allows_fetch_and_merge")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool UpdateAllowsFetchAndMerge { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryRuleUpdateParameters" /> class.
        /// </summary>
        /// <param name="updateAllowsFetchAndMerge">
        /// Branch can pull changes from its upstream repository
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
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