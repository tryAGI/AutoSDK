//HintName: G.Models.GetKnowledgeBaseDependentAgentsResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetKnowledgeBaseDependentAgentsResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agents")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.AgentsItem2> Agents { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("branches")]
        public global::System.Collections.Generic.IList<global::G.DependentBranchInfo>? Branches { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_cursor")]
        public string? NextCursor { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_more")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HasMore { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetKnowledgeBaseDependentAgentsResponseModel" /> class.
        /// </summary>
        /// <param name="agents"></param>
        /// <param name="branches"></param>
        /// <param name="nextCursor"></param>
        /// <param name="hasMore"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetKnowledgeBaseDependentAgentsResponseModel(
            global::System.Collections.Generic.IList<global::G.AgentsItem2> agents,
            bool hasMore,
            global::System.Collections.Generic.IList<global::G.DependentBranchInfo>? branches,
            string? nextCursor)
        {
            this.Agents = agents ?? throw new global::System.ArgumentNullException(nameof(agents));
            this.HasMore = hasMore;
            this.Branches = branches;
            this.NextCursor = nextCursor;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetKnowledgeBaseDependentAgentsResponseModel" /> class.
        /// </summary>
        public GetKnowledgeBaseDependentAgentsResponseModel()
        {
        }
    }
}